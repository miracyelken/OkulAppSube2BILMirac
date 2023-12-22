namespace OkulAppSube2BIL
{
    partial class frmOgrtmn
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
            this.grpOgrtmn = new System.Windows.Forms.GroupBox();
            this.lblOgrtAd = new System.Windows.Forms.Label();
            this.lblOgrtSoyad = new System.Windows.Forms.Label();
            this.lblOgrtTCNo = new System.Windows.Forms.Label();
            this.txtOgrtAd = new System.Windows.Forms.TextBox();
            this.txtOgrtSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrtTC = new System.Windows.Forms.TextBox();
            this.btnOgrtKaydet = new System.Windows.Forms.Button();
            this.grpOgrtmn.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOgrtmn
            // 
            this.grpOgrtmn.Controls.Add(this.btnOgrtKaydet);
            this.grpOgrtmn.Controls.Add(this.txtOgrtTC);
            this.grpOgrtmn.Controls.Add(this.txtOgrtSoyad);
            this.grpOgrtmn.Controls.Add(this.txtOgrtAd);
            this.grpOgrtmn.Controls.Add(this.lblOgrtTCNo);
            this.grpOgrtmn.Controls.Add(this.lblOgrtSoyad);
            this.grpOgrtmn.Controls.Add(this.lblOgrtAd);
            this.grpOgrtmn.Location = new System.Drawing.Point(29, 25);
            this.grpOgrtmn.Name = "grpOgrtmn";
            this.grpOgrtmn.Size = new System.Drawing.Size(231, 211);
            this.grpOgrtmn.TabIndex = 0;
            this.grpOgrtmn.TabStop = false;
            this.grpOgrtmn.Text = "Öğretmen Kayıt Sistemi";
            // 
            // lblOgrtAd
            // 
            this.lblOgrtAd.AutoSize = true;
            this.lblOgrtAd.Location = new System.Drawing.Point(18, 20);
            this.lblOgrtAd.Name = "lblOgrtAd";
            this.lblOgrtAd.Size = new System.Drawing.Size(20, 13);
            this.lblOgrtAd.TabIndex = 0;
            this.lblOgrtAd.Text = "Ad";
            // 
            // lblOgrtSoyad
            // 
            this.lblOgrtSoyad.AutoSize = true;
            this.lblOgrtSoyad.Location = new System.Drawing.Point(18, 58);
            this.lblOgrtSoyad.Name = "lblOgrtSoyad";
            this.lblOgrtSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblOgrtSoyad.TabIndex = 1;
            this.lblOgrtSoyad.Text = "Soyad";
            // 
            // lblOgrtTCNo
            // 
            this.lblOgrtTCNo.AutoSize = true;
            this.lblOgrtTCNo.Location = new System.Drawing.Point(18, 96);
            this.lblOgrtTCNo.Name = "lblOgrtTCNo";
            this.lblOgrtTCNo.Size = new System.Drawing.Size(38, 13);
            this.lblOgrtTCNo.TabIndex = 2;
            this.lblOgrtTCNo.Text = "TC No";
            // 
            // txtOgrtAd
            // 
            this.txtOgrtAd.Location = new System.Drawing.Point(94, 13);
            this.txtOgrtAd.Name = "txtOgrtAd";
            this.txtOgrtAd.Size = new System.Drawing.Size(100, 20);
            this.txtOgrtAd.TabIndex = 3;
            // 
            // txtOgrtSoyad
            // 
            this.txtOgrtSoyad.Location = new System.Drawing.Point(94, 51);
            this.txtOgrtSoyad.Name = "txtOgrtSoyad";
            this.txtOgrtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtOgrtSoyad.TabIndex = 4;
            // 
            // txtOgrtTC
            // 
            this.txtOgrtTC.Location = new System.Drawing.Point(94, 89);
            this.txtOgrtTC.Name = "txtOgrtTC";
            this.txtOgrtTC.Size = new System.Drawing.Size(100, 20);
            this.txtOgrtTC.TabIndex = 5;
            // 
            // btnOgrtKaydet
            // 
            this.btnOgrtKaydet.Location = new System.Drawing.Point(56, 143);
            this.btnOgrtKaydet.Name = "btnOgrtKaydet";
            this.btnOgrtKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnOgrtKaydet.TabIndex = 6;
            this.btnOgrtKaydet.Text = "KAYDET";
            this.btnOgrtKaydet.UseVisualStyleBackColor = true;
            this.btnOgrtKaydet.Click += new System.EventHandler(this.btnOgrtKaydet_Click);
            // 
            // frmOgrtmn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.grpOgrtmn);
            this.Name = "frmOgrtmn";
            this.Text = "frmOgrtmn";
            this.grpOgrtmn.ResumeLayout(false);
            this.grpOgrtmn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgrtmn;
        private System.Windows.Forms.Button btnOgrtKaydet;
        private System.Windows.Forms.TextBox txtOgrtTC;
        private System.Windows.Forms.TextBox txtOgrtSoyad;
        private System.Windows.Forms.TextBox txtOgrtAd;
        private System.Windows.Forms.Label lblOgrtTCNo;
        private System.Windows.Forms.Label lblOgrtSoyad;
        private System.Windows.Forms.Label lblOgrtAd;
    }
}