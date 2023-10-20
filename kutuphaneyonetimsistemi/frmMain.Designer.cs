namespace kutuphaneyonetimsistemi
{
    partial class frmMain
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
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnKitap = new System.Windows.Forms.Button();
            this.btnKitapTur = new System.Windows.Forms.Button();
            this.btnOdunc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOgrenci.Image = global::kutuphaneyonetimsistemi.Properties.Resources.student;
            this.btnOgrenci.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOgrenci.Location = new System.Drawing.Point(41, 55);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(223, 157);
            this.btnOgrenci.TabIndex = 0;
            this.btnOgrenci.Text = "Öğrenciler";
            this.btnOgrenci.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnKitap
            // 
            this.btnKitap.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitap.Image = global::kutuphaneyonetimsistemi.Properties.Resources.Everaldo_Desktoon_Library_128;
            this.btnKitap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKitap.Location = new System.Drawing.Point(270, 55);
            this.btnKitap.Name = "btnKitap";
            this.btnKitap.Size = new System.Drawing.Size(223, 157);
            this.btnKitap.TabIndex = 1;
            this.btnKitap.Text = "Kitaplar";
            this.btnKitap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitap.UseVisualStyleBackColor = true;
            this.btnKitap.Click += new System.EventHandler(this.btnKitap_Click);
            // 
            // btnKitapTur
            // 
            this.btnKitapTur.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitapTur.Image = global::kutuphaneyonetimsistemi.Properties.Resources.Asset_3;
            this.btnKitapTur.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKitapTur.Location = new System.Drawing.Point(41, 218);
            this.btnKitapTur.Name = "btnKitapTur";
            this.btnKitapTur.Size = new System.Drawing.Size(223, 158);
            this.btnKitapTur.TabIndex = 2;
            this.btnKitapTur.Text = "Kitap Türleri";
            this.btnKitapTur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitapTur.UseVisualStyleBackColor = true;
            this.btnKitapTur.Click += new System.EventHandler(this.btnKitapTur_Click);
            // 
            // btnOdunc
            // 
            this.btnOdunc.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdunc.Image = global::kutuphaneyonetimsistemi.Properties.Resources.borrow;
            this.btnOdunc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOdunc.Location = new System.Drawing.Point(270, 218);
            this.btnOdunc.Name = "btnOdunc";
            this.btnOdunc.Size = new System.Drawing.Size(223, 158);
            this.btnOdunc.TabIndex = 3;
            this.btnOdunc.Text = "Ödünç İşlemleri";
            this.btnOdunc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOdunc.UseVisualStyleBackColor = true;
            this.btnOdunc.Click += new System.EventHandler(this.btnOdunc_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(551, 439);
            this.Controls.Add(this.btnOdunc);
            this.Controls.Add(this.btnKitapTur);
            this.Controls.Add(this.btnKitap);
            this.Controls.Add(this.btnOgrenci);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnKitap;
        private System.Windows.Forms.Button btnKitapTur;
        private System.Windows.Forms.Button btnOdunc;
    }
}

