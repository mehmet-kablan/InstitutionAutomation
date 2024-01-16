using DernekOtomasyonu.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DernekOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MemberActions memberActForm = new MemberActions();
        ListingOptions listingOptsForm = new ListingOptions();
        GraphicsForm graphicsForm = new GraphicsForm();
        private void btn_ActionsTab_Click(object sender, EventArgs e)
        {
            OpenTab(memberActForm);
        }

        private void btn_ListingTab_Click(object sender, EventArgs e)
        {
            OpenTab(listingOptsForm);
        }

        private void btn_GraphicsPage_Click(object sender, EventArgs e)
        {
            OpenTab(graphicsForm);   
        }

        private void OpenTab(Form form)
        {
            form.Show();
        }
    }
}
