namespace DernekOtomasyonu
{
    partial class ListingOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_listMembers = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_listPayments = new System.Windows.Forms.Button();
            this.btn_ListBloodGroup = new System.Windows.Forms.Button();
            this.CB_BloodGroupList = new System.Windows.Forms.ComboBox();
            this.TB_CityList = new System.Windows.Forms.TextBox();
            this.btn_ListCity = new System.Windows.Forms.Button();
            this.btn_ListIndebted = new System.Windows.Forms.Button();
            this.btn_ListPassives = new System.Windows.Forms.Button();
            this.btn_ListActives = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ExportPDF = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ListBetweenDates = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DT_EndTime = new System.Windows.Forms.DateTimePicker();
            this.DT_StartDate = new System.Windows.Forms.DateTimePicker();
            this.btn_ListTCPayments = new System.Windows.Forms.Button();
            this.TB_ListPaymentsTC = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_SendEmail = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_MailMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_listMembers
            // 
            this.btn_listMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_listMembers.Location = new System.Drawing.Point(6, 19);
            this.btn_listMembers.Name = "btn_listMembers";
            this.btn_listMembers.Size = new System.Drawing.Size(160, 28);
            this.btn_listMembers.TabIndex = 1;
            this.btn_listMembers.Text = "Tüm Üyeleri Listele";
            this.btn_listMembers.UseVisualStyleBackColor = true;
            this.btn_listMembers.Click += new System.EventHandler(this.btn_listMembers_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1058, 204);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_listPayments
            // 
            this.btn_listPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_listPayments.Location = new System.Drawing.Point(6, 25);
            this.btn_listPayments.Name = "btn_listPayments";
            this.btn_listPayments.Size = new System.Drawing.Size(159, 28);
            this.btn_listPayments.TabIndex = 10;
            this.btn_listPayments.Text = "Ödemeleri Listele";
            this.btn_listPayments.UseVisualStyleBackColor = true;
            this.btn_listPayments.Click += new System.EventHandler(this.btn_listPayments_Click);
            // 
            // btn_ListBloodGroup
            // 
            this.btn_ListBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ListBloodGroup.Location = new System.Drawing.Point(172, 53);
            this.btn_ListBloodGroup.Name = "btn_ListBloodGroup";
            this.btn_ListBloodGroup.Size = new System.Drawing.Size(271, 28);
            this.btn_ListBloodGroup.TabIndex = 3;
            this.btn_ListBloodGroup.Text = "Seçili kan grubuna ait üyeleri listele";
            this.btn_ListBloodGroup.UseVisualStyleBackColor = true;
            this.btn_ListBloodGroup.Click += new System.EventHandler(this.btn_ListBloodGroup_Click);
            // 
            // CB_BloodGroupList
            // 
            this.CB_BloodGroupList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CB_BloodGroupList.FormattingEnabled = true;
            this.CB_BloodGroupList.Items.AddRange(new object[] {
            "A-",
            "A+",
            "B-",
            "B+",
            "AB-",
            "AB+",
            "0-",
            "0+"});
            this.CB_BloodGroupList.Location = new System.Drawing.Point(6, 53);
            this.CB_BloodGroupList.Name = "CB_BloodGroupList";
            this.CB_BloodGroupList.Size = new System.Drawing.Size(160, 28);
            this.CB_BloodGroupList.TabIndex = 2;
            // 
            // TB_CityList
            // 
            this.TB_CityList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_CityList.Location = new System.Drawing.Point(7, 88);
            this.TB_CityList.Name = "TB_CityList";
            this.TB_CityList.Size = new System.Drawing.Size(159, 26);
            this.TB_CityList.TabIndex = 4;
            // 
            // btn_ListCity
            // 
            this.btn_ListCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ListCity.Location = new System.Drawing.Point(172, 86);
            this.btn_ListCity.Name = "btn_ListCity";
            this.btn_ListCity.Size = new System.Drawing.Size(271, 28);
            this.btn_ListCity.TabIndex = 5;
            this.btn_ListCity.Text = "Seçili şehre ait üyeleri listele";
            this.btn_ListCity.UseVisualStyleBackColor = true;
            this.btn_ListCity.Click += new System.EventHandler(this.btn_ListCity_Click);
            // 
            // btn_ListIndebted
            // 
            this.btn_ListIndebted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ListIndebted.Location = new System.Drawing.Point(7, 120);
            this.btn_ListIndebted.Name = "btn_ListIndebted";
            this.btn_ListIndebted.Size = new System.Drawing.Size(159, 28);
            this.btn_ListIndebted.TabIndex = 6;
            this.btn_ListIndebted.Text = "Borçlu Üyeleri Listele";
            this.btn_ListIndebted.UseVisualStyleBackColor = true;
            this.btn_ListIndebted.Click += new System.EventHandler(this.btn_ListIndebted_Click);
            // 
            // btn_ListPassives
            // 
            this.btn_ListPassives.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ListPassives.Location = new System.Drawing.Point(172, 154);
            this.btn_ListPassives.Name = "btn_ListPassives";
            this.btn_ListPassives.Size = new System.Drawing.Size(271, 28);
            this.btn_ListPassives.TabIndex = 9;
            this.btn_ListPassives.Text = "Pasif Üyeleri Listele";
            this.btn_ListPassives.UseVisualStyleBackColor = true;
            this.btn_ListPassives.Click += new System.EventHandler(this.btn_ListPassives_Click);
            // 
            // btn_ListActives
            // 
            this.btn_ListActives.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ListActives.Location = new System.Drawing.Point(7, 154);
            this.btn_ListActives.Name = "btn_ListActives";
            this.btn_ListActives.Size = new System.Drawing.Size(159, 28);
            this.btn_ListActives.TabIndex = 8;
            this.btn_ListActives.Text = "Aktif Üyeleri Listele";
            this.btn_ListActives.UseVisualStyleBackColor = true;
            this.btn_ListActives.Click += new System.EventHandler(this.btn_ListActives_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ExportPDF);
            this.groupBox1.Controls.Add(this.btn_listMembers);
            this.groupBox1.Controls.Add(this.btn_ListActives);
            this.groupBox1.Controls.Add(this.btn_ListBloodGroup);
            this.groupBox1.Controls.Add(this.btn_ListPassives);
            this.groupBox1.Controls.Add(this.CB_BloodGroupList);
            this.groupBox1.Controls.Add(this.btn_ListIndebted);
            this.groupBox1.Controls.Add(this.TB_CityList);
            this.groupBox1.Controls.Add(this.btn_ListCity);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 198);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Listeleme İşlemleri";
            // 
            // btn_ExportPDF
            // 
            this.btn_ExportPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ExportPDF.Location = new System.Drawing.Point(172, 120);
            this.btn_ExportPDF.Name = "btn_ExportPDF";
            this.btn_ExportPDF.Size = new System.Drawing.Size(271, 28);
            this.btn_ExportPDF.TabIndex = 7;
            this.btn_ExportPDF.Text = "Borçlu Üyelerin PDF\'ini kaydet";
            this.btn_ExportPDF.UseVisualStyleBackColor = true;
            this.btn_ExportPDF.Click += new System.EventHandler(this.btn_ExportPDF_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ListBetweenDates);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DT_EndTime);
            this.groupBox2.Controls.Add(this.DT_StartDate);
            this.groupBox2.Controls.Add(this.btn_ListTCPayments);
            this.groupBox2.Controls.Add(this.TB_ListPaymentsTC);
            this.groupBox2.Controls.Add(this.btn_listPayments);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(498, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 198);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ödeme Listeleme İşlemleri";
            // 
            // btn_ListBetweenDates
            // 
            this.btn_ListBetweenDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ListBetweenDates.Location = new System.Drawing.Point(9, 152);
            this.btn_ListBetweenDates.Name = "btn_ListBetweenDates";
            this.btn_ListBetweenDates.Size = new System.Drawing.Size(321, 30);
            this.btn_ListBetweenDates.TabIndex = 29;
            this.btn_ListBetweenDates.Text = "Tarihler Arası Ödemeleri Listele";
            this.btn_ListBetweenDates.UseVisualStyleBackColor = true;
            this.btn_ListBetweenDates.Click += new System.EventHandler(this.btn_ListBetweenDates_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Bitiş tarihi seçiniz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Başlangıç tarihi seçiniz:";
            // 
            // DT_EndTime
            // 
            this.DT_EndTime.CustomFormat = "dd/MM/yyyy";
            this.DT_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DT_EndTime.Location = new System.Drawing.Point(171, 120);
            this.DT_EndTime.Name = "DT_EndTime";
            this.DT_EndTime.ShowUpDown = true;
            this.DT_EndTime.Size = new System.Drawing.Size(159, 26);
            this.DT_EndTime.TabIndex = 14;
            // 
            // DT_StartDate
            // 
            this.DT_StartDate.CustomFormat = "dd/MM/yyyy";
            this.DT_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DT_StartDate.Location = new System.Drawing.Point(171, 88);
            this.DT_StartDate.Name = "DT_StartDate";
            this.DT_StartDate.ShowUpDown = true;
            this.DT_StartDate.Size = new System.Drawing.Size(159, 26);
            this.DT_StartDate.TabIndex = 13;
            // 
            // btn_ListTCPayments
            // 
            this.btn_ListTCPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ListTCPayments.Location = new System.Drawing.Point(171, 54);
            this.btn_ListTCPayments.Name = "btn_ListTCPayments";
            this.btn_ListTCPayments.Size = new System.Drawing.Size(329, 28);
            this.btn_ListTCPayments.TabIndex = 12;
            this.btn_ListTCPayments.Text = "Seçili Kimlik Numarasına ait ödemeleri listele";
            this.btn_ListTCPayments.UseVisualStyleBackColor = true;
            this.btn_ListTCPayments.Click += new System.EventHandler(this.btn_ListTCPayments_Click);
            // 
            // TB_ListPaymentsTC
            // 
            this.TB_ListPaymentsTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_ListPaymentsTC.Location = new System.Drawing.Point(6, 55);
            this.TB_ListPaymentsTC.Name = "TB_ListPaymentsTC";
            this.TB_ListPaymentsTC.Size = new System.Drawing.Size(159, 26);
            this.TB_ListPaymentsTC.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_SendEmail);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.TB_MailMessage);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(19, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(517, 100);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mail Gönder";
            // 
            // btn_SendEmail
            // 
            this.btn_SendEmail.Location = new System.Drawing.Point(387, 49);
            this.btn_SendEmail.Name = "btn_SendEmail";
            this.btn_SendEmail.Size = new System.Drawing.Size(115, 45);
            this.btn_SendEmail.TabIndex = 16;
            this.btn_SendEmail.Text = "Gönder";
            this.btn_SendEmail.UseVisualStyleBackColor = true;
            this.btn_SendEmail.Click += new System.EventHandler(this.btn_SendEmail_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Borçlu üyelere göndermek istediğiniz mesajı yazınız :";
            // 
            // TB_MailMessage
            // 
            this.TB_MailMessage.Location = new System.Drawing.Point(6, 49);
            this.TB_MailMessage.Multiline = true;
            this.TB_MailMessage.Name = "TB_MailMessage";
            this.TB_MailMessage.Size = new System.Drawing.Size(375, 45);
            this.TB_MailMessage.TabIndex = 15;
            // 
            // ListingOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 537);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListingOptions";
            this.Text = "Listeleme İşlemleri";
            this.Load += new System.EventHandler(this.ListingOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_listMembers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_listPayments;
        private System.Windows.Forms.Button btn_ListBloodGroup;
        private System.Windows.Forms.ComboBox CB_BloodGroupList;
        private System.Windows.Forms.TextBox TB_CityList;
        private System.Windows.Forms.Button btn_ListCity;
        private System.Windows.Forms.Button btn_ListIndebted;
        private System.Windows.Forms.Button btn_ListPassives;
        private System.Windows.Forms.Button btn_ListActives;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ListTCPayments;
        private System.Windows.Forms.TextBox TB_ListPaymentsTC;
        private System.Windows.Forms.Button btn_ExportPDF;
        private System.Windows.Forms.DateTimePicker DT_StartDate;
        private System.Windows.Forms.DateTimePicker DT_EndTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ListBetweenDates;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_MailMessage;
        private System.Windows.Forms.Button btn_SendEmail;
    }
}