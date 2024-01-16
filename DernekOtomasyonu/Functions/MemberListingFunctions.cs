using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout;
using System.Net.Mail;
using System.Net;
using Org.BouncyCastle.Crypto.Macs;
using iText.IO.Font.Otf.Lookuptype7;
using System.IO;

namespace DernekOtomasyonu
{
    internal class MemberListingFunctions
    {

        static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        readonly OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Dernek.accdb");
        OleDbDataAdapter dataAdapter;
        OleDbCommand command;

        public DataTable ListTable(string tablename)
        {
            connection.Open();
            string query = "SELECT * FROM " + tablename;
            dataAdapter = new OleDbDataAdapter(query,connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            connection.Close();
            
            return table;
        }

        public DataTable ListTableWithOptions(string tablename, string column, string value)
        {
            connection.Open();
            string query = "SELECT * FROM " + tablename + " WHERE " + column + " = @value";
            command = new OleDbCommand(query,connection);
            if(value == "true" || value == "false")
                command.Parameters.AddWithValue("@value", bool.Parse(value));
            else
                command.Parameters.AddWithValue("@value", value);

            dataAdapter = new OleDbDataAdapter();
            dataAdapter.SelectCommand = command;
            
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            connection.Close();

            return table;
        }

        public DataTable ListIndebted()
        {
            OleDbDataReader dataReader;
            DateTime dateNow = DateTime.Now.AddMonths(-1);
            string x = dateNow.ToString("dd/MM/yyyy");
            connection.Open();
            string query = "SELECT * FROM [Members] WHERE EXISTS " +
                "(SELECT [TCNumber] FROM Payments GROUP BY [TCNumber] HAVING Max([Date]) < @datenow AND Members.TCNumber = Payments.TCNumber) AND [Status] = True";

            command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@dateNow", x);
            command.ExecuteNonQuery();
            dataReader = command.ExecuteReader();
            DataTable table = new DataTable();

            

            table.Load(dataReader);

            connection.Close();
            return table;
        }

        public void ExportIndebtedPDF()
        {

            FolderBrowserDialog file = new FolderBrowserDialog();
            if(file.ShowDialog() == DialogResult.OK)
            {
                string filePath = file.SelectedPath;

                OleDbDataReader dataReader;
                DateTime dateNow = DateTime.Now.AddMonths(-1);
                string x = dateNow.ToString("dd/MM/yyyy");
                connection.Open();
                string query = "SELECT * FROM [Members] WHERE EXISTS " +
                "(SELECT [TCNumber] FROM Payments GROUP BY [TCNumber] HAVING Max([Date]) < @datenow AND Members.TCNumber = Payments.TCNumber) AND [Status] = True";
                command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@dateNow", x);
                command.ExecuteNonQuery();
                dataReader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(dataReader);

                PdfWriter writer = new PdfWriter(filePath + "\\Indebted.pdf");

                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                Paragraph header = new Paragraph("Borçlu Üyeler")
                   .SetTextAlignment(TextAlignment.CENTER)
                   .SetFontSize(20);
                Table tablePDF = new Table(7);

                document.Add(header);

                tablePDF.AddCell(new Paragraph("TC Kimlik Numarasi"));
                tablePDF.AddCell(new Paragraph("Isim"));
                tablePDF.AddCell(new Paragraph("Soyisim"));
                tablePDF.AddCell(new Paragraph("Sehir"));
                tablePDF.AddCell(new Paragraph("Kan Grubu"));
                tablePDF.AddCell(new Paragraph("E-mail"));
                tablePDF.AddCell(new Paragraph("Durum"));

                foreach (DataRow row in table.Rows)
                {

                    tablePDF.AddCell(new Cell().Add(new Paragraph(row[0].ToString())));
                    tablePDF.AddCell(new Cell().Add(new Paragraph(row[1].ToString())));
                    tablePDF.AddCell(new Cell().Add(new Paragraph(row[2].ToString())));
                    tablePDF.AddCell(new Cell().Add(new Paragraph(row[3].ToString())));
                    tablePDF.AddCell(new Cell().Add(new Paragraph(row[4].ToString())));
                    tablePDF.AddCell(new Cell().Add(new Paragraph(row[5].ToString())));
                    if (row[6].ToString() == "True")
                        tablePDF.AddCell(new Cell().Add(new Paragraph("Aktif")));
                    else
                        tablePDF.AddCell(new Cell().Add(new Paragraph("Pasif")));

                }


                document.Add(tablePDF);
                document.Close();


                connection.Close();

                MessageBox.Show("Son 1 ay içinde ödeme yapmayan Üyeler PDF dosyasına kaydedildi");
            }

            
        }

        public void SendEmail(string messageToSend)
        {
            string senderMail = "mehmet.kablant@gmail.com";
            string password = "bwem mffz uxho gweo";
            MailMessage message = new MailMessage();

            message.From = new MailAddress(senderMail);
            message.Subject = "Dernek Borcu";


            DataTable indebted = ListIndebted();

            foreach (DataRow row in indebted.Rows)
            {
                if (row[5].ToString().Contains("@") || row[5].ToString().Contains(".com"))
                    message.To.Add(row[5].ToString());
            }

            message.Body = messageToSend;
            message.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential(senderMail, password);
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(message);

                MessageBox.Show("Borçlu üyeler listesindeki tüm üyelere mail mesajı gönderildi");
            }
            catch (SmtpException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public DataTable ListPaymentsBetween(DateTime start,DateTime end)
        {
            connection.Open();
            string query = "SELECT * FROM Payments WHERE [Date] BETWEEN @start AND + @end";
            dataAdapter = new OleDbDataAdapter(query, connection);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@start", start);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@end", end);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            connection.Close();

            return table;
        }

    }


}
