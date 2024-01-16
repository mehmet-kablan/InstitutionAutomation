using DernekOtomasyonu.Functions;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DernekOtomasyonu.Forms
{
    public partial class GraphicsForm : Form
    {
        public GraphicsForm()
        {
            InitializeComponent();
        }

        private void btn_Last5Year_Click(object sender, EventArgs e)
        {
            GraphicFunctions graphicFunction = new GraphicFunctions();
            graphicFunction.PlotLastYears(zedGraphControl1,2024);
        }

        private void btn_listInputYear_Click(object sender, EventArgs e)
        {
            GraphicFunctions graphicFunctions = new GraphicFunctions();
            graphicFunctions.PlotMonthlyData(zedGraphControl1,int.Parse(numericUpDown1.Value.ToString()));
        }

        private void btn_plotCities_Click(object sender, EventArgs e)
        {
            GraphicFunctions graphicFunctions = new GraphicFunctions();
            graphicFunctions.PlotMemberCities(zedGraphControl1);
        }

    }
}
