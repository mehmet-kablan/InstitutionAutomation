namespace DernekOtomasyonu
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ActionsTab = new System.Windows.Forms.Button();
            this.btn_ListingTab = new System.Windows.Forms.Button();
            this.btn_GraphicsPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(112, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dernek Takip Programına Hoşgeldiniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(200, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(494, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lüttfen yapmak istediğiniz işlemi seçiniz";
            // 
            // btn_ActionsTab
            // 
            this.btn_ActionsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ActionsTab.Location = new System.Drawing.Point(120, 177);
            this.btn_ActionsTab.Name = "btn_ActionsTab";
            this.btn_ActionsTab.Size = new System.Drawing.Size(319, 305);
            this.btn_ActionsTab.TabIndex = 2;
            this.btn_ActionsTab.Text = "Bireysel Üye İşlemleri";
            this.btn_ActionsTab.UseVisualStyleBackColor = true;
            this.btn_ActionsTab.Click += new System.EventHandler(this.btn_ActionsTab_Click);
            // 
            // btn_ListingTab
            // 
            this.btn_ListingTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ListingTab.Location = new System.Drawing.Point(461, 177);
            this.btn_ListingTab.Name = "btn_ListingTab";
            this.btn_ListingTab.Size = new System.Drawing.Size(342, 305);
            this.btn_ListingTab.TabIndex = 3;
            this.btn_ListingTab.Text = "Listeleme ve E-Posta İşlemleri";
            this.btn_ListingTab.UseVisualStyleBackColor = true;
            this.btn_ListingTab.Click += new System.EventHandler(this.btn_ListingTab_Click);
            // 
            // btn_GraphicsPage
            // 
            this.btn_GraphicsPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_GraphicsPage.Location = new System.Drawing.Point(356, 488);
            this.btn_GraphicsPage.Name = "btn_GraphicsPage";
            this.btn_GraphicsPage.Size = new System.Drawing.Size(182, 99);
            this.btn_GraphicsPage.TabIndex = 4;
            this.btn_GraphicsPage.Text = "Grafikler";
            this.btn_GraphicsPage.UseVisualStyleBackColor = true;
            this.btn_GraphicsPage.Click += new System.EventHandler(this.btn_GraphicsPage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 616);
            this.Controls.Add(this.btn_GraphicsPage);
            this.Controls.Add(this.btn_ListingTab);
            this.Controls.Add(this.btn_ActionsTab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dernek Otomasyonu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ActionsTab;
        private System.Windows.Forms.Button btn_ListingTab;
        private System.Windows.Forms.Button btn_GraphicsPage;
    }
}

