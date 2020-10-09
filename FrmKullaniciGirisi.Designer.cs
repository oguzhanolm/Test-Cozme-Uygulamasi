namespace TestCoz
{
    partial class FrmKullaniciGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciGirisi));
            this.btnGiris = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.cmbKullaniciTuru = new System.Windows.Forms.ComboBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(156, 109);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(181, 30);
            this.btnGiris.TabIndex = 27;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label3.Location = new System.Drawing.Point(24, 79);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(126, 20);
            this.Label3.TabIndex = 26;
            this.Label3.Text = "Kullanici Türü :";
            // 
            // cmbKullaniciTuru
            // 
            this.cmbKullaniciTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKullaniciTuru.FormattingEnabled = true;
            this.cmbKullaniciTuru.Items.AddRange(new object[] {
            "öğrenci",
            "öğretmen"});
            this.cmbKullaniciTuru.Location = new System.Drawing.Point(156, 75);
            this.cmbKullaniciTuru.Name = "cmbKullaniciTuru";
            this.cmbKullaniciTuru.Size = new System.Drawing.Size(181, 28);
            this.cmbKullaniciTuru.TabIndex = 25;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPass.Location = new System.Drawing.Point(156, 46);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(181, 26);
            this.txtPass.TabIndex = 24;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(156, 17);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(181, 26);
            this.txtKullaniciAdi.TabIndex = 23;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label2.Location = new System.Drawing.Point(93, 49);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(57, 20);
            this.Label2.TabIndex = 22;
            this.Label2.Text = "Şifre :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label1.Location = new System.Drawing.Point(34, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(116, 20);
            this.Label1.TabIndex = 21;
            this.Label1.Text = "Kullanıcı Adı :";
            // 
            // FrmKullaniciGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 143);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.cmbKullaniciTuru);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmKullaniciGirisi";
            this.Text = "TestCöz - Kullanici Girişi";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnGiris;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox cmbKullaniciTuru;
        internal System.Windows.Forms.TextBox txtPass;
        internal System.Windows.Forms.TextBox txtKullaniciAdi;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}