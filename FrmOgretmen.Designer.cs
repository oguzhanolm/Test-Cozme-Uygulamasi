namespace TestCoz
{
    partial class FrmOgretmen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgretmen));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.LblogretmenAd = new System.Windows.Forms.Label();
            this.LblOgretmenEposta = new System.Windows.Forms.Label();
            this.LblOgretmenTel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbKonu = new System.Windows.Forms.ComboBox();
            this.tblKonularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtbSoruCozDataSet1 = new TestCoz.dtbSoruCozDataSet1();
            this.btnSoruEkle = new System.Windows.Forms.Button();
            this.btnYanlisCevap3GorseliSec = new System.Windows.Forms.Button();
            this.txtYanlisCevapGorseli3 = new System.Windows.Forms.TextBox();
            this.btnYanlisCevap2GorseliSec = new System.Windows.Forms.Button();
            this.txtYanlisCevapGorseli2 = new System.Windows.Forms.TextBox();
            this.btnDogruCevapGorseliSec = new System.Windows.Forms.Button();
            this.txtDogruCevapGorseli = new System.Windows.Forms.TextBox();
            this.btnYanlisCevap1GorseliSec = new System.Windows.Forms.Button();
            this.txtYanlisCevapGorseli1 = new System.Windows.Forms.TextBox();
            this.picYanlisCevap3 = new System.Windows.Forms.PictureBox();
            this.picYanlisCevap2 = new System.Windows.Forms.PictureBox();
            this.picYanlisCevap1 = new System.Windows.Forms.PictureBox();
            this.picDogruCevap = new System.Windows.Forms.PictureBox();
            this.chkCevapGorseliEkle = new System.Windows.Forms.CheckBox();
            this.rchYanlisCevap3 = new System.Windows.Forms.RichTextBox();
            this.rchYanlisCevap2 = new System.Windows.Forms.RichTextBox();
            this.rchYanlisCevap1 = new System.Windows.Forms.RichTextBox();
            this.rchDogruCevap = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSoruGorselisec = new System.Windows.Forms.Button();
            this.txtSoruGorseliuzantisi = new System.Windows.Forms.TextBox();
            this.chkSoruGorseliEkle = new System.Windows.Forms.CheckBox();
            this.picSoru = new System.Windows.Forms.PictureBox();
            this.rchSoru = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdSoru = new System.Windows.Forms.OpenFileDialog();
            this.ofdDogruCevap = new System.Windows.Forms.OpenFileDialog();
            this.ofdYanlisCevap1 = new System.Windows.Forms.OpenFileDialog();
            this.ofdYanlisCevap2 = new System.Windows.Forms.OpenFileDialog();
            this.ofdYanlisCevap3 = new System.Windows.Forms.OpenFileDialog();
            this.tblKonularTableAdapter = new TestCoz.dtbSoruCozDataSet1TableAdapters.tblKonularTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblKonularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbSoruCozDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYanlisCevap3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYanlisCevap2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYanlisCevap1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDogruCevap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSoru)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.MultiLine = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl1.Size = new System.Drawing.Size(922, 512);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.label10);
            this.xtraTabPage1.Controls.Add(this.LblogretmenAd);
            this.xtraTabPage1.Controls.Add(this.LblOgretmenEposta);
            this.xtraTabPage1.Controls.Add(this.LblOgretmenTel);
            this.xtraTabPage1.Controls.Add(this.label7);
            this.xtraTabPage1.Controls.Add(this.label8);
            this.xtraTabPage1.Controls.Add(this.label9);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabPage1.Size = new System.Drawing.Size(916, 484);
            this.xtraTabPage1.Text = "Öğretmen Bilgileri";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(379, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 19);
            this.label10.TabIndex = 14;
            this.label10.Text = "Öğretmen Bilgileri";
            // 
            // LblogretmenAd
            // 
            this.LblogretmenAd.AutoSize = true;
            this.LblogretmenAd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblogretmenAd.Location = new System.Drawing.Point(379, 171);
            this.LblogretmenAd.Name = "LblogretmenAd";
            this.LblogretmenAd.Size = new System.Drawing.Size(59, 19);
            this.LblogretmenAd.TabIndex = 13;
            this.LblogretmenAd.Text = "xxxxx";
            // 
            // LblOgretmenEposta
            // 
            this.LblOgretmenEposta.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.LblOgretmenEposta.AutoSize = true;
            this.LblOgretmenEposta.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOgretmenEposta.Location = new System.Drawing.Point(379, 206);
            this.LblOgretmenEposta.Name = "LblOgretmenEposta";
            this.LblOgretmenEposta.Size = new System.Drawing.Size(59, 19);
            this.LblOgretmenEposta.TabIndex = 12;
            this.LblOgretmenEposta.Text = "xxxxx";
            // 
            // LblOgretmenTel
            // 
            this.LblOgretmenTel.AutoSize = true;
            this.LblOgretmenTel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOgretmenTel.Location = new System.Drawing.Point(379, 241);
            this.LblOgretmenTel.Name = "LblOgretmenTel";
            this.LblOgretmenTel.Size = new System.Drawing.Size(59, 19);
            this.LblOgretmenTel.TabIndex = 11;
            this.LblOgretmenTel.Text = "xxxxx";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(275, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Adı Soyadı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(285, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "E-Postası :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(217, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Telefon Numarası :";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Appearance.PageClient.BackColor = System.Drawing.Color.Transparent;
            this.xtraTabPage2.Appearance.PageClient.Options.UseBackColor = true;
            this.xtraTabPage2.Controls.Add(this.label6);
            this.xtraTabPage2.Controls.Add(this.cmbKonu);
            this.xtraTabPage2.Controls.Add(this.btnSoruEkle);
            this.xtraTabPage2.Controls.Add(this.btnYanlisCevap3GorseliSec);
            this.xtraTabPage2.Controls.Add(this.txtYanlisCevapGorseli3);
            this.xtraTabPage2.Controls.Add(this.btnYanlisCevap2GorseliSec);
            this.xtraTabPage2.Controls.Add(this.txtYanlisCevapGorseli2);
            this.xtraTabPage2.Controls.Add(this.btnDogruCevapGorseliSec);
            this.xtraTabPage2.Controls.Add(this.txtDogruCevapGorseli);
            this.xtraTabPage2.Controls.Add(this.btnYanlisCevap1GorseliSec);
            this.xtraTabPage2.Controls.Add(this.txtYanlisCevapGorseli1);
            this.xtraTabPage2.Controls.Add(this.picYanlisCevap3);
            this.xtraTabPage2.Controls.Add(this.picYanlisCevap2);
            this.xtraTabPage2.Controls.Add(this.picYanlisCevap1);
            this.xtraTabPage2.Controls.Add(this.picDogruCevap);
            this.xtraTabPage2.Controls.Add(this.chkCevapGorseliEkle);
            this.xtraTabPage2.Controls.Add(this.rchYanlisCevap3);
            this.xtraTabPage2.Controls.Add(this.rchYanlisCevap2);
            this.xtraTabPage2.Controls.Add(this.rchYanlisCevap1);
            this.xtraTabPage2.Controls.Add(this.rchDogruCevap);
            this.xtraTabPage2.Controls.Add(this.label5);
            this.xtraTabPage2.Controls.Add(this.label4);
            this.xtraTabPage2.Controls.Add(this.label3);
            this.xtraTabPage2.Controls.Add(this.label2);
            this.xtraTabPage2.Controls.Add(this.btnSoruGorselisec);
            this.xtraTabPage2.Controls.Add(this.txtSoruGorseliuzantisi);
            this.xtraTabPage2.Controls.Add(this.chkSoruGorseliEkle);
            this.xtraTabPage2.Controls.Add(this.picSoru);
            this.xtraTabPage2.Controls.Add(this.rchSoru);
            this.xtraTabPage2.Controls.Add(this.label1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabPage2.Size = new System.Drawing.Size(916, 484);
            this.xtraTabPage2.Text = "Soru Ekle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(14, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Konu :";
            // 
            // cmbKonu
            // 
            this.cmbKonu.DataSource = this.tblKonularBindingSource;
            this.cmbKonu.DisplayMember = "konuAd";
            this.cmbKonu.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKonu.FormattingEnabled = true;
            this.cmbKonu.Location = new System.Drawing.Point(69, 450);
            this.cmbKonu.Name = "cmbKonu";
            this.cmbKonu.Size = new System.Drawing.Size(215, 26);
            this.cmbKonu.TabIndex = 27;
            this.cmbKonu.ValueMember = "konuid";
            // 
            // tblKonularBindingSource
            // 
            this.tblKonularBindingSource.DataMember = "tblKonular";
            this.tblKonularBindingSource.DataSource = this.dtbSoruCozDataSet1;
            // 
            // dtbSoruCozDataSet1
            // 
            this.dtbSoruCozDataSet1.DataSetName = "dtbSoruCozDataSet1";
            this.dtbSoruCozDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSoruEkle
            // 
            this.btnSoruEkle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSoruEkle.Location = new System.Drawing.Point(734, 449);
            this.btnSoruEkle.Name = "btnSoruEkle";
            this.btnSoruEkle.Size = new System.Drawing.Size(175, 23);
            this.btnSoruEkle.TabIndex = 2;
            this.btnSoruEkle.Text = "Ekle";
            this.btnSoruEkle.UseVisualStyleBackColor = true;
            this.btnSoruEkle.Click += new System.EventHandler(this.btnSoruEkle_Click);
            // 
            // btnYanlisCevap3GorseliSec
            // 
            this.btnYanlisCevap3GorseliSec.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYanlisCevap3GorseliSec.Location = new System.Drawing.Point(840, 416);
            this.btnYanlisCevap3GorseliSec.Name = "btnYanlisCevap3GorseliSec";
            this.btnYanlisCevap3GorseliSec.Size = new System.Drawing.Size(56, 23);
            this.btnYanlisCevap3GorseliSec.TabIndex = 26;
            this.btnYanlisCevap3GorseliSec.Text = "...";
            this.btnYanlisCevap3GorseliSec.UseVisualStyleBackColor = true;
            this.btnYanlisCevap3GorseliSec.Visible = false;
            this.btnYanlisCevap3GorseliSec.Click += new System.EventHandler(this.btnYanlisCevap3GorseliSec_Click);
            // 
            // txtYanlisCevapGorseli3
            // 
            this.txtYanlisCevapGorseli3.Location = new System.Drawing.Point(462, 417);
            this.txtYanlisCevapGorseli3.Name = "txtYanlisCevapGorseli3";
            this.txtYanlisCevapGorseli3.Size = new System.Drawing.Size(378, 21);
            this.txtYanlisCevapGorseli3.TabIndex = 25;
            this.txtYanlisCevapGorseli3.Visible = false;
            // 
            // btnYanlisCevap2GorseliSec
            // 
            this.btnYanlisCevap2GorseliSec.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYanlisCevap2GorseliSec.Location = new System.Drawing.Point(395, 416);
            this.btnYanlisCevap2GorseliSec.Name = "btnYanlisCevap2GorseliSec";
            this.btnYanlisCevap2GorseliSec.Size = new System.Drawing.Size(56, 23);
            this.btnYanlisCevap2GorseliSec.TabIndex = 24;
            this.btnYanlisCevap2GorseliSec.Text = "...";
            this.btnYanlisCevap2GorseliSec.UseVisualStyleBackColor = true;
            this.btnYanlisCevap2GorseliSec.Visible = false;
            this.btnYanlisCevap2GorseliSec.Click += new System.EventHandler(this.btnYanlisCevap2GorseliSec_Click);
            // 
            // txtYanlisCevapGorseli2
            // 
            this.txtYanlisCevapGorseli2.Location = new System.Drawing.Point(16, 417);
            this.txtYanlisCevapGorseli2.Name = "txtYanlisCevapGorseli2";
            this.txtYanlisCevapGorseli2.Size = new System.Drawing.Size(378, 21);
            this.txtYanlisCevapGorseli2.TabIndex = 23;
            this.txtYanlisCevapGorseli2.Visible = false;
            // 
            // btnDogruCevapGorseliSec
            // 
            this.btnDogruCevapGorseliSec.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDogruCevapGorseliSec.Location = new System.Drawing.Point(394, 268);
            this.btnDogruCevapGorseliSec.Name = "btnDogruCevapGorseliSec";
            this.btnDogruCevapGorseliSec.Size = new System.Drawing.Size(56, 23);
            this.btnDogruCevapGorseliSec.TabIndex = 22;
            this.btnDogruCevapGorseliSec.Text = "...";
            this.btnDogruCevapGorseliSec.UseVisualStyleBackColor = true;
            this.btnDogruCevapGorseliSec.Visible = false;
            this.btnDogruCevapGorseliSec.Click += new System.EventHandler(this.btnDogruCevapGorseliSec_Click);
            // 
            // txtDogruCevapGorseli
            // 
            this.txtDogruCevapGorseli.Location = new System.Drawing.Point(16, 269);
            this.txtDogruCevapGorseli.Name = "txtDogruCevapGorseli";
            this.txtDogruCevapGorseli.Size = new System.Drawing.Size(378, 21);
            this.txtDogruCevapGorseli.TabIndex = 21;
            this.txtDogruCevapGorseli.Visible = false;
            // 
            // btnYanlisCevap1GorseliSec
            // 
            this.btnYanlisCevap1GorseliSec.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYanlisCevap1GorseliSec.Location = new System.Drawing.Point(840, 268);
            this.btnYanlisCevap1GorseliSec.Name = "btnYanlisCevap1GorseliSec";
            this.btnYanlisCevap1GorseliSec.Size = new System.Drawing.Size(56, 23);
            this.btnYanlisCevap1GorseliSec.TabIndex = 20;
            this.btnYanlisCevap1GorseliSec.Text = "...";
            this.btnYanlisCevap1GorseliSec.UseVisualStyleBackColor = true;
            this.btnYanlisCevap1GorseliSec.Visible = false;
            this.btnYanlisCevap1GorseliSec.Click += new System.EventHandler(this.btnYanlisCevap1GorseliSec_Click);
            // 
            // txtYanlisCevapGorseli1
            // 
            this.txtYanlisCevapGorseli1.Location = new System.Drawing.Point(462, 269);
            this.txtYanlisCevapGorseli1.Name = "txtYanlisCevapGorseli1";
            this.txtYanlisCevapGorseli1.Size = new System.Drawing.Size(378, 21);
            this.txtYanlisCevapGorseli1.TabIndex = 19;
            this.txtYanlisCevapGorseli1.Visible = false;
            // 
            // picYanlisCevap3
            // 
            this.picYanlisCevap3.BackColor = System.Drawing.Color.Transparent;
            this.picYanlisCevap3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picYanlisCevap3.Location = new System.Drawing.Point(462, 328);
            this.picYanlisCevap3.Name = "picYanlisCevap3";
            this.picYanlisCevap3.Size = new System.Drawing.Size(432, 85);
            this.picYanlisCevap3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picYanlisCevap3.TabIndex = 18;
            this.picYanlisCevap3.TabStop = false;
            this.picYanlisCevap3.Visible = false;
            // 
            // picYanlisCevap2
            // 
            this.picYanlisCevap2.BackColor = System.Drawing.Color.Transparent;
            this.picYanlisCevap2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picYanlisCevap2.Location = new System.Drawing.Point(16, 328);
            this.picYanlisCevap2.Name = "picYanlisCevap2";
            this.picYanlisCevap2.Size = new System.Drawing.Size(432, 85);
            this.picYanlisCevap2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picYanlisCevap2.TabIndex = 17;
            this.picYanlisCevap2.TabStop = false;
            this.picYanlisCevap2.Visible = false;
            // 
            // picYanlisCevap1
            // 
            this.picYanlisCevap1.BackColor = System.Drawing.Color.Transparent;
            this.picYanlisCevap1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picYanlisCevap1.Location = new System.Drawing.Point(462, 183);
            this.picYanlisCevap1.Name = "picYanlisCevap1";
            this.picYanlisCevap1.Size = new System.Drawing.Size(432, 82);
            this.picYanlisCevap1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picYanlisCevap1.TabIndex = 16;
            this.picYanlisCevap1.TabStop = false;
            this.picYanlisCevap1.Visible = false;
            // 
            // picDogruCevap
            // 
            this.picDogruCevap.BackColor = System.Drawing.Color.Transparent;
            this.picDogruCevap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDogruCevap.Location = new System.Drawing.Point(17, 183);
            this.picDogruCevap.Name = "picDogruCevap";
            this.picDogruCevap.Size = new System.Drawing.Size(432, 82);
            this.picDogruCevap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDogruCevap.TabIndex = 15;
            this.picDogruCevap.TabStop = false;
            this.picDogruCevap.Visible = false;
            // 
            // chkCevapGorseliEkle
            // 
            this.chkCevapGorseliEkle.AutoSize = true;
            this.chkCevapGorseliEkle.CausesValidation = false;
            this.chkCevapGorseliEkle.Enabled = false;
            this.chkCevapGorseliEkle.Location = new System.Drawing.Point(47, 136);
            this.chkCevapGorseliEkle.Name = "chkCevapGorseliEkle";
            this.chkCevapGorseliEkle.Size = new System.Drawing.Size(129, 17);
            this.chkCevapGorseliEkle.TabIndex = 14;
            this.chkCevapGorseliEkle.Text = "Cevaplar Göresel Yap";
            this.chkCevapGorseliEkle.UseVisualStyleBackColor = true;
            this.chkCevapGorseliEkle.CheckedChanged += new System.EventHandler(this.chkCevapGorseliEkle_CheckedChanged);
            // 
            // rchYanlisCevap3
            // 
            this.rchYanlisCevap3.Location = new System.Drawing.Point(462, 328);
            this.rchYanlisCevap3.Name = "rchYanlisCevap3";
            this.rchYanlisCevap3.Size = new System.Drawing.Size(435, 107);
            this.rchYanlisCevap3.TabIndex = 13;
            this.rchYanlisCevap3.Text = "";
            // 
            // rchYanlisCevap2
            // 
            this.rchYanlisCevap2.Location = new System.Drawing.Point(16, 328);
            this.rchYanlisCevap2.Name = "rchYanlisCevap2";
            this.rchYanlisCevap2.Size = new System.Drawing.Size(435, 107);
            this.rchYanlisCevap2.TabIndex = 12;
            this.rchYanlisCevap2.Text = "";
            // 
            // rchYanlisCevap1
            // 
            this.rchYanlisCevap1.Location = new System.Drawing.Point(462, 183);
            this.rchYanlisCevap1.Name = "rchYanlisCevap1";
            this.rchYanlisCevap1.Size = new System.Drawing.Size(435, 107);
            this.rchYanlisCevap1.TabIndex = 11;
            this.rchYanlisCevap1.Text = "";
            // 
            // rchDogruCevap
            // 
            this.rchDogruCevap.Location = new System.Drawing.Point(16, 183);
            this.rchDogruCevap.Name = "rchDogruCevap";
            this.rchDogruCevap.Size = new System.Drawing.Size(435, 107);
            this.rchDogruCevap.TabIndex = 10;
            this.rchDogruCevap.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(459, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Diğer Cevap3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Diğer Cevap2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(459, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Diğer Cevap1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Doğru Cevap:";
            // 
            // btnSoruGorselisec
            // 
            this.btnSoruGorselisec.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSoruGorselisec.Location = new System.Drawing.Point(853, 110);
            this.btnSoruGorselisec.Name = "btnSoruGorselisec";
            this.btnSoruGorselisec.Size = new System.Drawing.Size(56, 23);
            this.btnSoruGorselisec.TabIndex = 5;
            this.btnSoruGorselisec.Text = "...";
            this.btnSoruGorselisec.UseVisualStyleBackColor = true;
            this.btnSoruGorselisec.Visible = false;
            this.btnSoruGorselisec.Click += new System.EventHandler(this.btnSoruGorselisec_Click);
            // 
            // txtSoruGorseliuzantisi
            // 
            this.txtSoruGorseliuzantisi.Location = new System.Drawing.Point(159, 111);
            this.txtSoruGorseliuzantisi.Name = "txtSoruGorseliuzantisi";
            this.txtSoruGorseliuzantisi.Size = new System.Drawing.Size(694, 21);
            this.txtSoruGorseliuzantisi.TabIndex = 4;
            this.txtSoruGorseliuzantisi.Visible = false;
            // 
            // chkSoruGorseliEkle
            // 
            this.chkSoruGorseliEkle.AutoSize = true;
            this.chkSoruGorseliEkle.CausesValidation = false;
            this.chkSoruGorseliEkle.Location = new System.Drawing.Point(47, 113);
            this.chkSoruGorseliEkle.Name = "chkSoruGorseliEkle";
            this.chkSoruGorseliEkle.Size = new System.Drawing.Size(105, 17);
            this.chkSoruGorseliEkle.TabIndex = 3;
            this.chkSoruGorseliEkle.Text = "Soru Görseli Ekle";
            this.chkSoruGorseliEkle.CheckedChanged += new System.EventHandler(this.chkSoruGorseliEkle_CheckedChanged);
            // 
            // picSoru
            // 
            this.picSoru.BackColor = System.Drawing.Color.Transparent;
            this.picSoru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSoru.Location = new System.Drawing.Point(734, 11);
            this.picSoru.Name = "picSoru";
            this.picSoru.Size = new System.Drawing.Size(175, 96);
            this.picSoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSoru.TabIndex = 2;
            this.picSoru.TabStop = false;
            this.picSoru.Visible = false;
            // 
            // rchSoru
            // 
            this.rchSoru.Location = new System.Drawing.Point(47, 11);
            this.rchSoru.Name = "rchSoru";
            this.rchSoru.Size = new System.Drawing.Size(862, 96);
            this.rchSoru.TabIndex = 1;
            this.rchSoru.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soru :";
            // 
            // ofdSoru
            // 
            this.ofdSoru.FileName = "openFileDialog1";
            // 
            // ofdDogruCevap
            // 
            this.ofdDogruCevap.FileName = "openFileDialog1";
            // 
            // ofdYanlisCevap1
            // 
            this.ofdYanlisCevap1.FileName = "openFileDialog2";
            // 
            // ofdYanlisCevap2
            // 
            this.ofdYanlisCevap2.FileName = "openFileDialog3";
            // 
            // ofdYanlisCevap3
            // 
            this.ofdYanlisCevap3.FileName = "openFileDialog4";
            // 
            // tblKonularTableAdapter
            // 
            this.tblKonularTableAdapter.ClearBeforeFill = true;
            // 
            // FrmOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 512);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOgretmen";
            this.Text = "TestCöz - Öğretmen";
            this.Load += new System.EventHandler(this.FrmOgretmen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblKonularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbSoruCozDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYanlisCevap3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYanlisCevap2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYanlisCevap1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDogruCevap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSoru)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.Button btnYanlisCevap3GorseliSec;
        private System.Windows.Forms.TextBox txtYanlisCevapGorseli3;
        private System.Windows.Forms.Button btnYanlisCevap2GorseliSec;
        private System.Windows.Forms.TextBox txtYanlisCevapGorseli2;
        private System.Windows.Forms.Button btnDogruCevapGorseliSec;
        private System.Windows.Forms.TextBox txtDogruCevapGorseli;
        private System.Windows.Forms.Button btnYanlisCevap1GorseliSec;
        private System.Windows.Forms.TextBox txtYanlisCevapGorseli1;
        private System.Windows.Forms.PictureBox picYanlisCevap3;
        private System.Windows.Forms.PictureBox picYanlisCevap2;
        private System.Windows.Forms.PictureBox picYanlisCevap1;
        private System.Windows.Forms.PictureBox picDogruCevap;
        private System.Windows.Forms.CheckBox chkCevapGorseliEkle;
        private System.Windows.Forms.RichTextBox rchYanlisCevap3;
        private System.Windows.Forms.RichTextBox rchYanlisCevap2;
        private System.Windows.Forms.RichTextBox rchYanlisCevap1;
        private System.Windows.Forms.RichTextBox rchDogruCevap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSoruGorselisec;
        private System.Windows.Forms.TextBox txtSoruGorseliuzantisi;
        private System.Windows.Forms.CheckBox chkSoruGorseliEkle;
        private System.Windows.Forms.PictureBox picSoru;
        private System.Windows.Forms.RichTextBox rchSoru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofdSoru;
        private System.Windows.Forms.OpenFileDialog ofdDogruCevap;
        private System.Windows.Forms.OpenFileDialog ofdYanlisCevap1;
        private System.Windows.Forms.OpenFileDialog ofdYanlisCevap2;
        private System.Windows.Forms.OpenFileDialog ofdYanlisCevap3;
        private System.Windows.Forms.Button btnSoruEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbKonu;
        private dtbSoruCozDataSet1 dtbSoruCozDataSet1;
        private System.Windows.Forms.BindingSource tblKonularBindingSource;
        private dtbSoruCozDataSet1TableAdapters.tblKonularTableAdapter tblKonularTableAdapter;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.Label LblogretmenAd;
        private System.Windows.Forms.Label LblOgretmenEposta;
        private System.Windows.Forms.Label LblOgretmenTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}