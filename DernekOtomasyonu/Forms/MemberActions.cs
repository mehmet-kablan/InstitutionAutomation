using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DernekOtomasyonu
{
    public partial class MemberActions : Form
    {
        public MemberActions()
        {
            InitializeComponent();
        }

        MemberActionFunctions memberActionFunctions = new MemberActionFunctions();
        
        private void btn_AddMember_Click(object sender, EventArgs e)
        {
            

            if (long.TryParse(TB_TCKimlik.Text, out _))
            {
                if (long.Parse(TB_TCKimlik.Text).ToString().Length == 11)
                {
                    long tcKimlik = long.Parse(TB_TCKimlik.Text);
                    string name = TB_Name.Text;
                    string surname = TB_Surname.Text;
                    string city = TB_City.Text;
                    string bloodGroup = CB_BloodGroup.Text;
                    string mail = TB_Mail.Text;
                    memberActionFunctions.AddMember(tcKimlik, name, surname, city, bloodGroup, mail);
                }
                else
                    MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır.");
                
            }
            else
                MessageBox.Show("TC Kimlik Numarası rakamlardan oluşmalı.");

           
        }

        private void btn_DeleteMember_Click(object sender, EventArgs e)
        {
            if (long.TryParse(TB_DeleteTC.Text, out _))
                memberActionFunctions.DeleteMember(long.Parse(TB_DeleteTC.Text));
            else
                MessageBox.Show("TC Kimlik Numarası rakamlardan oluşmalı.");
        }

        private void btn_MakePayment_Click(object sender, EventArgs e)
        {
            if (float.TryParse(TB_payment.Text, out _) && long.TryParse(TB_PayTCNumber.Text, out _))
                memberActionFunctions.AddPayment(long.Parse(TB_PayTCNumber.Text), float.Parse(TB_payment.Text), DT_PayDate.Value.ToString());
            else
                MessageBox.Show("TC Kimlik Numarası ve Ödeme Miktarı rakamlardan oluşmalı.");
            
        }

        private void btn_ChangeStatus_Click(object sender, EventArgs e)
        {
            string newStatus;
            if (RB_Active.Checked)
                newStatus = "true";
            else
                newStatus = "false";


            if (long.TryParse(TB_StatusChangeTC.Text, out _))
                memberActionFunctions.ChangeMemberStatus(long.Parse(TB_StatusChangeTC.Text), newStatus);
            else
                MessageBox.Show("TC Kimlik Numarası rakamlardan oluşmalı");
        }

        private void RB_Active_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Active.Checked)
                RB_Passive.Checked = false;
        }

        private void RB_Passive_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Passive.Checked)
                RB_Active.Checked = false;
        }

        private void MemberActions_Load(object sender, EventArgs e)
        {
            DT_PayDate.MaxDate = DateTime.Now;
        }

    }
}
