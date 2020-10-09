using System.Drawing;
using System.Windows.Forms;

namespace TestCoz
{
    partial class FrmOgrenci
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.FullStackedBarSeriesView fullStackedBarSeriesView1 = new DevExpress.XtraCharts.FullStackedBarSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.FullStackedBarSeriesView fullStackedBarSeriesView2 = new DevExpress.XtraCharts.FullStackedBarSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.FullStackedBarSeriesView fullStackedBarSeriesView3 = new DevExpress.XtraCharts.FullStackedBarSeriesView();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.FullStackedBarSeriesView fullStackedBarSeriesView4 = new DevExpress.XtraCharts.FullStackedBarSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenci));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.chrtİstatistik = new DevExpress.XtraCharts.ChartControl();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOgrenciAd = new System.Windows.Forms.Label();
            this.lblOgrenciEPosta = new System.Windows.Forms.Label();
            this.lblOgrenciTel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.chrtSinav = new DevExpress.XtraCharts.ChartControl();
            this.BtnD = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.txtCozulenSoru = new System.Windows.Forms.Label();
            this.btnSonrakisoru = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.lblDakika = new System.Windows.Forms.Label();
            this.btnSınavaBasla = new System.Windows.Forms.Button();
            this.picCevapC = new System.Windows.Forms.PictureBox();
            this.picCevapD = new System.Windows.Forms.PictureBox();
            this.picCevapB = new System.Windows.Forms.PictureBox();
            this.picCevapA = new System.Windows.Forms.PictureBox();
            this.picSoru = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rchCevapD = new System.Windows.Forms.RichTextBox();
            this.rchCevapC = new System.Windows.Forms.RichTextBox();
            this.rchCevapB = new System.Windows.Forms.RichTextBox();
            this.rchCevapA = new System.Windows.Forms.RichTextBox();
            this.rchSoru = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sınavSuresi = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtİstatistik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedBarSeriesView2)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtSinav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedBarSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedBarSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCevapC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCevapD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCevapB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCevapA)).BeginInit();
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
            this.xtraTabControl1.Size = new System.Drawing.Size(877, 594);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.chrtİstatistik);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.lblOgrenciAd);
            this.xtraTabPage1.Controls.Add(this.lblOgrenciEPosta);
            this.xtraTabPage1.Controls.Add(this.lblOgrenciTel);
            this.xtraTabPage1.Controls.Add(this.label5);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabPage1.Size = new System.Drawing.Size(871, 566);
            this.xtraTabPage1.Text = "Öğrenci Bilgileri";
            // 
            // chrtİstatistik
            // 
            xyDiagram1.AxisX.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisX.Title.MaxLineCount = 5;
            xyDiagram1.AxisX.Title.Text = "Konular";
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.GridLines.Visible = false;
            xyDiagram1.AxisY.MinorCount = 1;
            xyDiagram1.AxisY.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisY.Title.Text = "Başarı Oranları";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisualRange.Auto = false;
            xyDiagram1.AxisY.VisualRange.MaxValueSerializable = "1";
            xyDiagram1.AxisY.VisualRange.MinValueSerializable = "0";
            this.chrtİstatistik.Diagram = xyDiagram1;
            this.chrtİstatistik.Legend.Name = "Default Legend";
            this.chrtİstatistik.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chrtİstatistik.Location = new System.Drawing.Point(12, 151);
            this.chrtİstatistik.Name = "chrtİstatistik";
            series1.Name = "dogrular";
            fullStackedBarSeriesView1.BarWidth = 0.5D;
            fullStackedBarSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            series1.View = fullStackedBarSeriesView1;
            series2.Name = "yanlislar";
            fullStackedBarSeriesView2.BarWidth = 0.5D;
            fullStackedBarSeriesView2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series2.View = fullStackedBarSeriesView2;
            this.chrtİstatistik.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chrtİstatistik.SeriesTemplate.SeriesColorizer = null;
            this.chrtİstatistik.Size = new System.Drawing.Size(851, 411);
            this.chrtİstatistik.TabIndex = 9;
            chartTitle1.Text = "İstatistikleriniz";
            this.chrtİstatistik.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Öğrenci Bilgileri:";
            // 
            // lblOgrenciAd
            // 
            this.lblOgrenciAd.AutoSize = true;
            this.lblOgrenciAd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenciAd.Location = new System.Drawing.Point(177, 38);
            this.lblOgrenciAd.Name = "lblOgrenciAd";
            this.lblOgrenciAd.Size = new System.Drawing.Size(59, 19);
            this.lblOgrenciAd.TabIndex = 7;
            this.lblOgrenciAd.Text = "xxxxx";
            // 
            // lblOgrenciEPosta
            // 
            this.lblOgrenciEPosta.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lblOgrenciEPosta.AutoSize = true;
            this.lblOgrenciEPosta.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenciEPosta.Location = new System.Drawing.Point(177, 73);
            this.lblOgrenciEPosta.Name = "lblOgrenciEPosta";
            this.lblOgrenciEPosta.Size = new System.Drawing.Size(59, 19);
            this.lblOgrenciEPosta.TabIndex = 6;
            this.lblOgrenciEPosta.Text = "xxxxx";
            // 
            // lblOgrenciTel
            // 
            this.lblOgrenciTel.AutoSize = true;
            this.lblOgrenciTel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenciTel.Location = new System.Drawing.Point(177, 108);
            this.lblOgrenciTel.Name = "lblOgrenciTel";
            this.lblOgrenciTel.Size = new System.Drawing.Size(59, 19);
            this.lblOgrenciTel.TabIndex = 5;
            this.lblOgrenciTel.Text = "xxxxx";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(66, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adı Soyadı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(76, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-Postası :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon Numarası :";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.chrtSinav);
            this.xtraTabPage2.Controls.Add(this.BtnD);
            this.xtraTabPage2.Controls.Add(this.BtnC);
            this.xtraTabPage2.Controls.Add(this.btnB);
            this.xtraTabPage2.Controls.Add(this.btnA);
            this.xtraTabPage2.Controls.Add(this.txtCozulenSoru);
            this.xtraTabPage2.Controls.Add(this.btnSonrakisoru);
            this.xtraTabPage2.Controls.Add(this.label12);
            this.xtraTabPage2.Controls.Add(this.lblSaniye);
            this.xtraTabPage2.Controls.Add(this.lblDakika);
            this.xtraTabPage2.Controls.Add(this.btnSınavaBasla);
            this.xtraTabPage2.Controls.Add(this.picCevapC);
            this.xtraTabPage2.Controls.Add(this.picCevapD);
            this.xtraTabPage2.Controls.Add(this.picCevapB);
            this.xtraTabPage2.Controls.Add(this.picCevapA);
            this.xtraTabPage2.Controls.Add(this.picSoru);
            this.xtraTabPage2.Controls.Add(this.progressBar1);
            this.xtraTabPage2.Controls.Add(this.rchCevapD);
            this.xtraTabPage2.Controls.Add(this.rchCevapC);
            this.xtraTabPage2.Controls.Add(this.rchCevapB);
            this.xtraTabPage2.Controls.Add(this.rchCevapA);
            this.xtraTabPage2.Controls.Add(this.rchSoru);
            this.xtraTabPage2.Controls.Add(this.label2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabPage2.Size = new System.Drawing.Size(871, 566);
            this.xtraTabPage2.Text = "Test Çöz";
            // 
            // chrtSinav
            // 
            xyDiagram2.AxisX.Tickmarks.MinorVisible = false;
            xyDiagram2.AxisX.Title.MaxLineCount = 5;
            xyDiagram2.AxisX.Title.Text = "Konular";
            xyDiagram2.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.GridLines.Visible = false;
            xyDiagram2.AxisY.MinorCount = 1;
            xyDiagram2.AxisY.Tickmarks.MinorVisible = false;
            xyDiagram2.AxisY.Title.Text = "Başarı Oranları";
            xyDiagram2.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram2.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisualRange.Auto = false;
            xyDiagram2.AxisY.VisualRange.MaxValueSerializable = "1";
            xyDiagram2.AxisY.VisualRange.MinValueSerializable = "0";
            this.chrtSinav.Diagram = xyDiagram2;
            this.chrtSinav.Legend.Name = "Default Legend";
            this.chrtSinav.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chrtSinav.Location = new System.Drawing.Point(9, 258);
            this.chrtSinav.Name = "chrtSinav";
            series3.Name = "dogrular";
            fullStackedBarSeriesView3.BarWidth = 0.5D;
            fullStackedBarSeriesView3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            series3.View = fullStackedBarSeriesView3;
            series4.Name = "yanlislar";
            fullStackedBarSeriesView4.BarWidth = 0.5D;
            fullStackedBarSeriesView4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series4.View = fullStackedBarSeriesView4;
            this.chrtSinav.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3,
        series4};
            this.chrtSinav.SeriesTemplate.SeriesColorizer = null;
            this.chrtSinav.Size = new System.Drawing.Size(854, 275);
            this.chrtSinav.TabIndex = 31;
            chartTitle2.Text = "Sınav İstatistikleriniz";
            this.chrtSinav.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
            this.chrtSinav.Visible = false;
            // 
            // BtnD
            // 
            this.BtnD.Enabled = false;
            this.BtnD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnD.Location = new System.Drawing.Point(440, 405);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(23, 128);
            this.BtnD.TabIndex = 30;
            this.BtnD.Text = "D";
            this.BtnD.UseVisualStyleBackColor = true;
            this.BtnD.Visible = false;
            this.BtnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // BtnC
            // 
            this.BtnC.Enabled = false;
            this.BtnC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnC.Location = new System.Drawing.Point(7, 405);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(23, 128);
            this.BtnC.TabIndex = 29;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Visible = false;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // btnB
            // 
            this.btnB.Enabled = false;
            this.btnB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnB.Location = new System.Drawing.Point(436, 258);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(23, 128);
            this.btnB.TabIndex = 28;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Visible = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnA
            // 
            this.btnA.Enabled = false;
            this.btnA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnA.Location = new System.Drawing.Point(7, 258);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(23, 128);
            this.btnA.TabIndex = 27;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Visible = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // txtCozulenSoru
            // 
            this.txtCozulenSoru.AutoSize = true;
            this.txtCozulenSoru.Location = new System.Drawing.Point(410, 551);
            this.txtCozulenSoru.Name = "txtCozulenSoru";
            this.txtCozulenSoru.Size = new System.Drawing.Size(13, 13);
            this.txtCozulenSoru.TabIndex = 26;
            this.txtCozulenSoru.Text = "0";
            // 
            // btnSonrakisoru
            // 
            this.btnSonrakisoru.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSonrakisoru.Location = new System.Drawing.Point(720, 539);
            this.btnSonrakisoru.Name = "btnSonrakisoru";
            this.btnSonrakisoru.Size = new System.Drawing.Size(151, 27);
            this.btnSonrakisoru.TabIndex = 23;
            this.btnSonrakisoru.Text = "Sonraki Soru";
            this.btnSonrakisoru.UseVisualStyleBackColor = true;
            this.btnSonrakisoru.Visible = false;
            this.btnSonrakisoru.Click += new System.EventHandler(this.btnSonrakisoru_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(436, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 18);
            this.label12.TabIndex = 22;
            this.label12.Text = ":";
            this.label12.UseMnemonic = false;
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.BackColor = System.Drawing.Color.Transparent;
            this.lblSaniye.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.ForeColor = System.Drawing.Color.Black;
            this.lblSaniye.Location = new System.Drawing.Point(448, 6);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(28, 18);
            this.lblSaniye.TabIndex = 21;
            this.lblSaniye.Text = "00";
            this.lblSaniye.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSaniye.UseMnemonic = false;
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.BackColor = System.Drawing.Color.Transparent;
            this.lblDakika.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDakika.ForeColor = System.Drawing.Color.Black;
            this.lblDakika.Location = new System.Drawing.Point(409, 6);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDakika.Size = new System.Drawing.Size(28, 18);
            this.lblDakika.TabIndex = 20;
            this.lblDakika.Text = "00";
            this.lblDakika.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDakika.UseMnemonic = false;
            // 
            // btnSınavaBasla
            // 
            this.btnSınavaBasla.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSınavaBasla.Location = new System.Drawing.Point(3, 217);
            this.btnSınavaBasla.Name = "btnSınavaBasla";
            this.btnSınavaBasla.Size = new System.Drawing.Size(861, 35);
            this.btnSınavaBasla.TabIndex = 19;
            this.btnSınavaBasla.Text = "Sınava Başla ";
            this.btnSınavaBasla.UseVisualStyleBackColor = true;
            this.btnSınavaBasla.Click += new System.EventHandler(this.btnSınavaBasla_Click);
            // 
            // picCevapC
            // 
            this.picCevapC.Location = new System.Drawing.Point(33, 405);
            this.picCevapC.Name = "picCevapC";
            this.picCevapC.Size = new System.Drawing.Size(401, 128);
            this.picCevapC.TabIndex = 18;
            this.picCevapC.TabStop = false;
            this.picCevapC.Visible = false;
            // 
            // picCevapD
            // 
            this.picCevapD.Location = new System.Drawing.Point(466, 405);
            this.picCevapD.Name = "picCevapD";
            this.picCevapD.Size = new System.Drawing.Size(401, 128);
            this.picCevapD.TabIndex = 17;
            this.picCevapD.TabStop = false;
            this.picCevapD.Visible = false;
            // 
            // picCevapB
            // 
            this.picCevapB.Location = new System.Drawing.Point(463, 258);
            this.picCevapB.Name = "picCevapB";
            this.picCevapB.Size = new System.Drawing.Size(401, 128);
            this.picCevapB.TabIndex = 16;
            this.picCevapB.TabStop = false;
            this.picCevapB.Visible = false;
            // 
            // picCevapA
            // 
            this.picCevapA.Location = new System.Drawing.Point(33, 258);
            this.picCevapA.Name = "picCevapA";
            this.picCevapA.Size = new System.Drawing.Size(401, 128);
            this.picCevapA.TabIndex = 15;
            this.picCevapA.TabStop = false;
            this.picCevapA.Visible = false;
            // 
            // picSoru
            // 
            this.picSoru.Location = new System.Drawing.Point(248, 35);
            this.picSoru.Name = "picSoru";
            this.picSoru.Size = new System.Drawing.Size(374, 148);
            this.picSoru.TabIndex = 14;
            this.picSoru.TabStop = false;
            this.picSoru.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 4);
            this.progressBar1.Maximum = 3600;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(865, 25);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Tag = "";
            // 
            // rchCevapD
            // 
            this.rchCevapD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rchCevapD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchCevapD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.rchCevapD.Location = new System.Drawing.Point(468, 408);
            this.rchCevapD.Name = "rchCevapD";
            this.rchCevapD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rchCevapD.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rchCevapD.Size = new System.Drawing.Size(379, 125);
            this.rchCevapD.TabIndex = 12;
            this.rchCevapD.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" +
    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n";
            this.rchCevapD.Visible = false;
            // 
            // rchCevapC
            // 
            this.rchCevapC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rchCevapC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchCevapC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.rchCevapC.Location = new System.Drawing.Point(33, 412);
            this.rchCevapC.Name = "rchCevapC";
            this.rchCevapC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rchCevapC.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rchCevapC.Size = new System.Drawing.Size(379, 125);
            this.rchCevapC.TabIndex = 11;
            this.rchCevapC.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" +
    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n";
            this.rchCevapC.Visible = false;
            // 
            // rchCevapB
            // 
            this.rchCevapB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rchCevapB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchCevapB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.rchCevapB.Location = new System.Drawing.Point(468, 261);
            this.rchCevapB.Name = "rchCevapB";
            this.rchCevapB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rchCevapB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rchCevapB.Size = new System.Drawing.Size(379, 125);
            this.rchCevapB.TabIndex = 10;
            this.rchCevapB.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" +
    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n";
            this.rchCevapB.Visible = false;
            // 
            // rchCevapA
            // 
            this.rchCevapA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rchCevapA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchCevapA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.rchCevapA.Location = new System.Drawing.Point(33, 261);
            this.rchCevapA.Name = "rchCevapA";
            this.rchCevapA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rchCevapA.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rchCevapA.Size = new System.Drawing.Size(379, 125);
            this.rchCevapA.TabIndex = 9;
            this.rchCevapA.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" +
    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n";
            this.rchCevapA.Visible = false;
            // 
            // rchSoru
            // 
            this.rchSoru.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rchSoru.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchSoru.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.rchSoru.Location = new System.Drawing.Point(58, 35);
            this.rchSoru.Name = "rchSoru";
            this.rchSoru.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rchSoru.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rchSoru.Size = new System.Drawing.Size(780, 217);
            this.rchSoru.TabIndex = 2;
            this.rchSoru.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" +
    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n";
            this.rchSoru.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soru :";
            // 
            // sınavSuresi
            // 
            this.sınavSuresi.Interval = 1000;
            this.sınavSuresi.Tick += new System.EventHandler(this.sınavSuresi_Tick);
            // 
            // FrmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 594);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOgrenci";
            this.Text = "TestCoz - Öğrenci";
            this.Load += new System.EventHandler(this.FrmOgrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedBarSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtİstatistik)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedBarSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedBarSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtSinav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCevapC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCevapD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCevapB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCevapA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSoru)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.Label lblOgrenciAd;
        private System.Windows.Forms.Label lblOgrenciEPosta;
        private System.Windows.Forms.Label lblOgrenciTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rchSoru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rchCevapD;
        private System.Windows.Forms.RichTextBox rchCevapC;
        private System.Windows.Forms.RichTextBox rchCevapB;
        private System.Windows.Forms.RichTextBox rchCevapA;
        private System.Windows.Forms.PictureBox picSoru;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox picCevapC;
        private System.Windows.Forms.PictureBox picCevapD;
        private System.Windows.Forms.PictureBox picCevapB;
        private System.Windows.Forms.PictureBox picCevapA;
        private System.Windows.Forms.Button btnSınavaBasla;
        private System.Windows.Forms.Timer sınavSuresi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Label lblDakika;
        private Button btnSonrakisoru;
        private Button BtnD;
        private Button BtnC;
        private Button btnB;
        private Button btnA;
        private Label txtCozulenSoru;
        private DevExpress.XtraCharts.ChartControl chrtİstatistik;
        private DevExpress.XtraCharts.ChartControl chrtSinav;
    }
}