namespace DernekOtomasyonu.Forms
{
    partial class GraphicsForm
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
            this.components = new System.ComponentModel.Container();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Last5Year = new System.Windows.Forms.Button();
            this.btn_listInputYear = new System.Windows.Forms.Button();
            this.btn_plotCities = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.AutoSize = true;
            this.zedGraphControl1.Location = new System.Drawing.Point(285, 12);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(664, 484);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(15, 151);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aylık Veri Görmek İstediğiniz Yılı Giriniz:";
            // 
            // btn_Last5Year
            // 
            this.btn_Last5Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Last5Year.Location = new System.Drawing.Point(15, 45);
            this.btn_Last5Year.Name = "btn_Last5Year";
            this.btn_Last5Year.Size = new System.Drawing.Size(237, 47);
            this.btn_Last5Year.TabIndex = 1;
            this.btn_Last5Year.Text = "Son 5 Yılın Verisini Görmek İçin Tıklayınız";
            this.btn_Last5Year.UseVisualStyleBackColor = true;
            this.btn_Last5Year.Click += new System.EventHandler(this.btn_Last5Year_Click);
            // 
            // btn_listInputYear
            // 
            this.btn_listInputYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_listInputYear.Location = new System.Drawing.Point(15, 178);
            this.btn_listInputYear.Name = "btn_listInputYear";
            this.btn_listInputYear.Size = new System.Drawing.Size(120, 27);
            this.btn_listInputYear.TabIndex = 3;
            this.btn_listInputYear.Text = "Görüntüle";
            this.btn_listInputYear.UseVisualStyleBackColor = true;
            this.btn_listInputYear.Click += new System.EventHandler(this.btn_listInputYear_Click);
            // 
            // btn_plotCities
            // 
            this.btn_plotCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_plotCities.Location = new System.Drawing.Point(15, 244);
            this.btn_plotCities.Name = "btn_plotCities";
            this.btn_plotCities.Size = new System.Drawing.Size(237, 60);
            this.btn_plotCities.TabIndex = 4;
            this.btn_plotCities.Text = "Şehirlere göre üye dağılımlarını görmek için tıklayın\r\n";
            this.btn_plotCities.UseVisualStyleBackColor = true;
            this.btn_plotCities.Click += new System.EventHandler(this.btn_plotCities_Click);
            // 
            // GraphicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 508);
            this.Controls.Add(this.btn_plotCities);
            this.Controls.Add(this.btn_listInputYear);
            this.Controls.Add(this.btn_Last5Year);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.zedGraphControl1);
            this.Name = "GraphicsForm";
            this.Text = "Grafik İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Last5Year;
        private System.Windows.Forms.Button btn_listInputYear;
        private System.Windows.Forms.Button btn_plotCities;
    }
}