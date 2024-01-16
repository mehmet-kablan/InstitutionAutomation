using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace DernekOtomasyonu.Functions
{
    internal class GraphicFunctions
    {


        static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        readonly OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Dernek.accdb");
        OleDbDataAdapter dataAdapter;
        OleDbCommand command;

        public void PlotMonthlyData(ZedGraphControl graph, int year)
        {

            graph.GraphPane.CurveList.Clear();
            graph.GraphPane.GraphObjList.Clear();

            connection.Open();

            double[] monthlyTotals = new double[12];
            double[] months = {1,2,3,4,5,6,7,8,9,10,11,12 };
            string[] labels = {"Ocak","Şubat","Mart","Nisan","Mayıs","Haziran","Temmuz","Ağustos","Eylül","Ekim","Kasım","Aralık"};
            
            for(int i = 1;i<13;i++)
            {
                string query = "SELECT [Payment(₺)] FROM Payments WHERE (MONTH([Date]) = @month) AND (YEAR([Date]) = @year)";
                dataAdapter = new OleDbDataAdapter(query, connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@month", i);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@year", year);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                float total = 0;

                foreach(DataRow row in table.Rows)
                {

                    
                    total += int.Parse(row[0].ToString());
                    monthlyTotals[i-1] = total;
                }


            }
            int maxPayment = int.Parse(monthlyTotals.Max().ToString());

            if (maxPayment > 0)
            {

                graph.GraphPane.AddBar("Aylık Ödemeler", months, monthlyTotals, color: System.Drawing.Color.Blue);
                graph.GraphPane.XAxis.Scale.Min = 1;
                graph.GraphPane.XAxis.Scale.Max = months.Length;
                graph.GraphPane.XAxis.Scale.MinorStep = 1;
                graph.GraphPane.XAxis.Scale.MinorStepAuto = false;
                graph.GraphPane.XAxis.Scale.Format = "0";
                graph.GraphPane.XAxis.Scale.MajorStep = 1;
                graph.GraphPane.XAxis.Scale.MajorStepAuto = false;
                graph.GraphPane.XAxis.Scale.TextLabels = labels;
                graph.GraphPane.XAxis.Title.IsVisible = true;
                graph.GraphPane.XAxis.Type = AxisType.Text;

                graph.GraphPane.YAxis.Scale.Min = 0;
                graph.GraphPane.YAxis.Scale.Max = maxPayment;
                graph.GraphPane.YAxis.Scale.MinorStepAuto = true;
                graph.GraphPane.YAxis.Scale.Format = "0";
                graph.GraphPane.YAxis.Scale.MajorStepAuto = true;
                graph.GraphPane.YAxis.Scale.TextLabels = labels;
                graph.GraphPane.YAxis.Title.IsVisible = true;

                graph.GraphPane.AxisChange();
                graph.Invalidate();

            }
            else
                MessageBox.Show("Bu yıl için ödeme kaydı bulunmuyor.");
            connection.Close();

        }

        public void PlotLastYears(ZedGraphControl graph, int year)
        {
            graph.GraphPane.CurveList.Clear();
            graph.GraphPane.GraphObjList.Clear();

            connection.Open();

            
            double[] yearlyTotals = new double[5];
            double[] years = { year - 5, year - 4, year - 3, year - 2, year - 1, year };
            for (int i = 0; i <= 4; i++)
            {
                
                
                for (int j = 1; j < 13; j++)
                {
                    double yearTotal = 0;
                    float total = 0;
                    double[] monthlyTotals = new double[12];
                    string query = "SELECT [Payment(₺)] FROM Payments WHERE (MONTH([Date]) = @month) AND (YEAR([Date]) = @year)";
                    dataAdapter = new OleDbDataAdapter(query, connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@month", j);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@year", years[i]);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);

                    

                    foreach (DataRow row in table.Rows)
                    {
                        total += int.Parse(row[0].ToString());
                        
                        monthlyTotals[j - 1] = total;
                    }

                    

                    foreach (double item in monthlyTotals)
                    {
                        yearTotal += item;

                    }

                    yearlyTotals[i] += yearTotal;

                }

                
            }
            
            int maxPayment = int.Parse(yearlyTotals.Max().ToString());

            

            graph.GraphPane.AddBar("Yıllık Ödeme Toplamları", years, yearlyTotals, color: System.Drawing.Color.Red);
            graph.GraphPane.XAxis.Scale.Min = year - 5;
            graph.GraphPane.XAxis.Scale.Max = year + 5;
            graph.GraphPane.XAxis.Scale.MinorStep = 1;
            graph.GraphPane.XAxis.Scale.MinorStepAuto = false;
            graph.GraphPane.XAxis.Scale.Format = "0";
            graph.GraphPane.XAxis.Scale.MajorStep = 1;
            graph.GraphPane.XAxis.Scale.MajorStepAuto = false;
            graph.GraphPane.XAxis.Title.IsVisible = true;
            graph.GraphPane.XAxis.Title.Text = "Yıllar";
            graph.GraphPane.XAxis.Type = AxisType.Linear;

            graph.GraphPane.YAxis.Scale.Min = 0;
            graph.GraphPane.YAxis.Scale.Max = maxPayment;
            graph.GraphPane.YAxis.Scale.MinorStepAuto = true;
            graph.GraphPane.YAxis.Scale.Format = "F0";
            graph.GraphPane.YAxis.Scale.MajorStepAuto = true;
            graph.GraphPane.YAxis.Title.IsVisible = true;
            graph.GraphPane.YAxis.Title.Text = "Ödemeler(₺)";

            graph.GraphPane.AxisChange();
            graph.Invalidate();

            connection.Close();
        }

        public void PlotMemberCities(ZedGraphControl graph)
        {
            graph.GraphPane.CurveList.Clear();
            graph.GraphPane.GraphObjList.Clear();

            connection.Open();
            string query = "SELECT [City], count(*) FROM Members GROUP BY [City]";
            dataAdapter = new OleDbDataAdapter(query, connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            connection.Close();

            string[] cities = new string[table.Rows.Count];
            double[] counts = new double[table.Rows.Count]; 

            for(int i = 0; i < table.Rows.Count; i++)
            {
                cities[i] = table.Rows[i][0].ToString();
                counts[i] = double.Parse(table.Rows[i][1].ToString());
            }

            graph.GraphPane.AddBar("Şehirlere göre üye dağılımı", counts, counts, color: System.Drawing.Color.Red);
            graph.GraphPane.XAxis.Scale.Min = 1;
            graph.GraphPane.XAxis.Scale.Max = cities.Length;
            graph.GraphPane.XAxis.Scale.MinorStep = 1;
            graph.GraphPane.XAxis.Scale.MinorStepAuto = false;
            graph.GraphPane.XAxis.Scale.Format = "0";
            graph.GraphPane.XAxis.Scale.MajorStep = 1;
            graph.GraphPane.XAxis.Scale.MajorStepAuto = false;
            graph.GraphPane.XAxis.Scale.TextLabels = cities;
            graph.GraphPane.XAxis.Title.IsVisible = true;
            graph.GraphPane.XAxis.Type = AxisType.Text;

            graph.GraphPane.YAxis.Scale.Min = 0;
            graph.GraphPane.YAxis.Scale.Max = counts.Max();
            graph.GraphPane.YAxis.Scale.MinorStep = 1;
            graph.GraphPane.YAxis.Scale.MinorStepAuto = false;
            graph.GraphPane.YAxis.Scale.Format = "0";
            graph.GraphPane.YAxis.Scale.MajorStep = 1;
            graph.GraphPane.YAxis.Scale.MajorStepAuto = false;

            graph.GraphPane.AxisChange();
            graph.Invalidate();

        }

    }
}
