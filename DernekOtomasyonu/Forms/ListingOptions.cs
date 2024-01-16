using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;

namespace DernekOtomasyonu
{
    public partial class ListingOptions : Form
    {
        public ListingOptions()
        {
            InitializeComponent();
        }

        MemberListingFunctions memberListingObj = new MemberListingFunctions();
        private void btn_listMembers_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = memberListingObj.ListTable("Members");
        }

        private void btn_listPayments_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = memberListingObj.ListTable("Payments");
        }

        private void btn_ListBloodGroup_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = memberListingObj.ListTableWithOptions("Members", "[Blood Group]", CB_BloodGroupList.Text);
        }

        private void btn_ListCity_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = memberListingObj.ListTableWithOptions("Members", "[City]", TB_CityList.Text);
        }

        private void btn_ListActives_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = memberListingObj.ListTableWithOptions("Members", "[Status]", "true");
        }

        private void btn_ListPassives_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = memberListingObj.ListTableWithOptions("Members", "Status", "false");
        }

        private void btn_ListTCPayments_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = memberListingObj.ListTableWithOptions("Payments", "TCNumber", TB_ListPaymentsTC.Text);
        }

        private void btn_ListIndebted_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = memberListingObj.ListIndebted();
        }

        private void btn_ExportPDF_Click(object sender, EventArgs e)
        {
            memberListingObj.ExportIndebtedPDF();
        }
        private void btn_SendEmail_Click(object sender, EventArgs e)
        {
            MemberListingFunctions memberListing = new MemberListingFunctions();
            memberListing.SendEmail(TB_MailMessage.Text);
        }

        private void btn_ListBetweenDates_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = memberListingObj.ListPaymentsBetween(DT_StartDate.Value.Date, DT_EndTime.Value.Date);
        }

        private void ListingOptions_Load(object sender, EventArgs e)
        {
            DT_StartDate.MaxDate = DateTime.Now;
            DT_EndTime.MaxDate = DateTime.Now;
        }

        
    }
}
