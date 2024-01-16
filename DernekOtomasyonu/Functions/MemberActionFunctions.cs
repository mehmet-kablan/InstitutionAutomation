using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Windows.Forms;
using System.IO;

namespace DernekOtomasyonu
{
    internal class MemberActionFunctions
    {


        static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        readonly OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Dernek.accdb");
        OleDbCommand command;

        public void AddMember(long tcNumber, string name, string surname,string city, string bloodGroup,string email)
        {

            connection.Open();
            string query = "INSERT INTO Members VALUES (@tcNumber,@name,@surname,@city,@bloodGroup,@email,1)";
            command = new OleDbCommand(query,connection);
            command.Parameters.AddWithValue("@tcNumber", tcNumber);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@surname", surname);
            command.Parameters.AddWithValue("@city", city);
            command.Parameters.AddWithValue("@bloodGroup", bloodGroup);
            command.Parameters.AddWithValue("@email", email);
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Üye başarıyla eklendi.");
        }

        public void DeleteMember(long tcNumber)
        {
            connection.Open();
            string query = "DELETE FROM Members WHERE TCNumber = @tcNumber";
            command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@tcNumber", tcNumber);
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Üye başarıyla silindi");
        }

        public void AddPayment(long tcNumber, float payment,string date)
        {
            OleDbDataReader dataReader;
            connection.Open();
            string query = "SELECT Name,Surname FROM Members WHERE TCNumber = @tcnumber";
            command = new OleDbCommand (query,connection);
            command.Parameters.AddWithValue("@tcNumber", tcNumber);
            command.ExecuteNonQuery ();
            dataReader = command.ExecuteReader ();
            string name = "", surname = "";
            while (dataReader.Read())
            {
                name = dataReader.GetValue(0).ToString();
                surname = dataReader.GetValue(1).ToString();
            }

            if(name != "")
            {
                query = "INSERT INTO Payments (TCNumber,[Name],[Surname],[Payment(₺)],[Date]) VALUES(@tcNumber,@name,@surname,@payment,@date)";
                command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@tcNumber", tcNumber);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@surname", surname);
                command.Parameters.AddWithValue("@payment", payment);
                command.Parameters.AddWithValue("@date", date);
                command.ExecuteNonQuery();
                

                MessageBox.Show("Ödeme veritabanına başarıyla eklendi.");
            }
            else
            {
                MessageBox.Show("Bu TC Kimlik Numarasına ait bir üye bulunamadı.");
            }
            connection.Close();

        }

        public void ChangeMemberStatus(long tcNumber, string newStatus)
        {
            connection.Open();
            string query = "UPDATE Members SET Status = "+newStatus+" WHERE TCNumber = @tcNumber";
            command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@tcNumber", tcNumber);
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Üye durumu başarıyla güncellendi.");
        }

        
    }
}
