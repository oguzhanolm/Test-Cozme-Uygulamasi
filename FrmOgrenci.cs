using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TestCoz
{
    public partial class FrmOgrenci : DevExpress.XtraEditors.XtraForm
    {
        clsKullaniciGirisi clskullaniciGirisi = new clsKullaniciGirisi();
        clsSoruGetir clssorugetir = new clsSoruGetir();
        clsistatistik clsistatistik = new clsistatistik();
        public String kullanici;
        public string kullaniciid;
        int[] cozulenSoruSayisi = new int[5];
        int[] konularaGoreCozulecekSoruSayisi = new int[5];
        int[,] cozulenTestVerileri = new int[5, 2];
        public int konusay = 0;
        public int soruSay = 0;
        public int toplamCozulenSoru = 0;
       
        int dakika = 0;
        int saniye = 0;
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        private void testiBitir() {
            sinavistatistik();
            btnA.Visible = false;
            btnB.Visible = false;
            BtnC.Visible = false;
            BtnD.Visible = false;
            testEkraniVisibleFalse();
            sınavSuresi.Stop();
            progressBar1.Value = 0;
            saniye = 0;
            dakika = 0;
            btnSınavaBasla.Visible = true;
            btnSonrakisoru.Text = "sonraki Soru";
            clsistatistik.sinavSonucuEkle(kullaniciid, cozulenTestVerileri);

        }//Test Bittiğinde gerekli İşlemleri yapar
        public void testsifirla() {

            for (int i = 0; i < 5; i++) {
                cozulenSoruSayisi[i] = 0;
                konularaGoreCozulecekSoruSayisi[i] = 0;
                cozulenTestVerileri[i, 0] = 0;
                cozulenTestVerileri[i, 1] = 0;        
            }
            konusay = 0;
            soruSay = 0;
            toplamCozulenSoru = 0;
        }//test Bittiğinde Gerekli Verileri Sıfırlar
        private void testEkraniVisibleFalse()
        {

            rchSoru.Visible = false;
            rchCevapA.Visible = false;
            rchCevapB.Visible = false;
            rchCevapC.Visible = false;
            rchCevapD.Visible = false;
            picSoru.Visible = false;
            picCevapA.Visible = false;
            picCevapB.Visible = false;
            picCevapC.Visible = false;
            picCevapD.Visible = false;
        } //Soru Cevaplandıktan Sonra Ekrandaki Objelerin Visible Değerini False Yapar
        private void siklarEnableFalse() {
            btnA.Enabled = false;
            btnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            btnSonrakisoru.Enabled = true;

        }//şıklarıTıklanabilir yapar
        private void siklarEnableTrue() {

            btnA.Visible = true;
            btnB.Visible = true;
            BtnC.Visible = true;
            BtnD.Visible = true;
            btnA.Enabled = true;
            btnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            btnSonrakisoru.Enabled = false;
        }//Şıkları Tıklanamaz Yapar
        private void dogru() {
        
                soruSay++;
                cozulenTestVerileri[konusay, 0]++;
            
            if (toplamCozulenSoru <= 50)
            {
                sorusayimi();
            }

        }//dogru cevap verildiğinde yapılacak işlemler
        private void yanlis() {
           
                soruSay++;
                cozulenTestVerileri[konusay, 1]++;
          
            if (toplamCozulenSoru <= 50)
            {
                sorusayimi();
            }

        }//yanlış Cevap Verildiğinde yapılacak işlemler
        public void sorusayilarigetir() {
            clssorugetir.soruSayisiverileri(kullaniciid);//buraya değer olarak kullaniciid girilecek
            for (int i = 0; i < 5; i++) {
                konularaGoreCozulecekSoruSayisi[i] = clssorugetir.sorusayisi[i];
                cozulenSoruSayisi[i] = 0;
            }

        }//konulara göre çözülecek soru sayilarini classtan formdaki bir değişkene aktarır
        private void sınavSuresi_Tick(object sender, EventArgs e)
        {

            saniye = saniye + 1;
            progressBar1.Value += 1;
            if (saniye == 60)
            {
                dakika += 1;
                saniye = 0;
            }
            lblDakika.Text = dakika.ToString();
            lblSaniye.Text = saniye.ToString();

            if (dakika == 60)
            {
                sınavSuresi.Stop();
                testiBitir();
            }


        }//Sınav Süresi
        private void sorusayimi() {
            toplamCozulenSoru++;
            txtCozulenSoru.Text = toplamCozulenSoru.ToString();
            if (konularaGoreCozulecekSoruSayisi[konusay] == 0) {
            }
            if (soruSay == konularaGoreCozulecekSoruSayisi[konusay] && konusay<4)
            {
                konusay++;
                soruSay = 0;
            }
            if (toplamCozulenSoru == 50)
            {
                btnSonrakisoru.Text = "Testi Bitir";                
            }

        }//test çözerken soru ve konu sayılarını sayar
        public void testEkrani()
        {

            if (clssorugetir.Soru[0] == "0")
            {

                rchSoru.Visible = true;
                rchCevapA.Visible = true;
                rchCevapB.Visible = true;
                rchCevapC.Visible = true;
                rchCevapD.Visible = true;
                rchSoru.Location = new Point(58, 35);
                rchSoru.Height = 197;
            }
            if (clssorugetir.Soru[0] == "1")
            {

                picSoru.Visible = true;
                rchSoru.Visible = true;
                picCevapA.Visible = true;
                picCevapB.Visible = true;
                picCevapC.Visible = true;
                picCevapD.Visible = true;
                rchSoru.Height = 73;
                rchSoru.Location = new Point(58, 181);

            }
            if (clssorugetir.Soru[0] == "2")
            {

                picSoru.Visible = true;
                rchSoru.Visible = true;
                rchCevapA.Visible = true;
                rchCevapB.Visible = true;
                rchCevapC.Visible = true;
                rchCevapD.Visible = true;
                rchSoru.Height = 73;
                rchSoru.Location = new Point(58, 181);

            }


        }// Sıradaki Sorunun Türüne Göre ekranı Ayarlar
        public void SoruGoster() {


            testEkraniVisibleFalse();
            clssorugetir.soruCek((konusay+1));
            testEkrani();

            if (clssorugetir.Soru[0] == "0")
            {

                rchSoru.Text = clssorugetir.Soru[1];
                rchCevapA.Text = clssorugetir.Soru[2];
                rchCevapB.Text = clssorugetir.Soru[3];
                rchCevapC.Text = clssorugetir.Soru[4];
                rchCevapD.Text = clssorugetir.Soru[5];

            }
            if (clssorugetir.Soru[0] == "1")
            {

                picSoru.ImageLocation = clssorugetir.Soru[6];
                rchSoru.Text = clssorugetir.Soru[1];
                picCevapA.ImageLocation = clssorugetir.Soru[2];
                picCevapB.ImageLocation = clssorugetir.Soru[3];
                picCevapC.ImageLocation = clssorugetir.Soru[4];
                picCevapD.ImageLocation = clssorugetir.Soru[5];


            }
            if (clssorugetir.Soru[0] == "2")
            {

                rchSoru.Text = clssorugetir.Soru[1];
                rchCevapA.Text = clssorugetir.Soru[2];
                rchCevapB.Text = clssorugetir.Soru[3];
                rchCevapC.Text = clssorugetir.Soru[4];
                rchCevapD.Text = clssorugetir.Soru[5];
                picSoru.ImageLocation = clssorugetir.Soru[6];

            }

        }//Veri tabanından Alınan Soruyu Ekrana Yazdırır
        public void istatistikGoruntule(){
            clsistatistik.genelistatistik(Convert.ToInt32(kullaniciid));
            chrtİstatistik.Series["dogrular"].Points.AddPoint("Olasilik",clsistatistik.genelistatistikler[0,0]);
            chrtİstatistik.Series["yanlislar"].Points.AddPoint("Olasilik", clsistatistik.genelistatistikler[0, 1]);
            chrtİstatistik.Series["dogrular"].Points.AddPoint("Dogrusal Denklemler", clsistatistik.genelistatistikler[1, 0]);
            chrtİstatistik.Series["yanlislar"].Points.AddPoint("Dogrusal Denklemler", clsistatistik.genelistatistikler[1, 1]);
            chrtİstatistik.Series["dogrular"].Points.AddPoint("Çarpanlar Ve Katları", clsistatistik.genelistatistikler[2, 0]);
            chrtİstatistik.Series["yanlislar"].Points.AddPoint("Çarpanlar Ve Katları", clsistatistik.genelistatistikler[2, 1]);
            chrtİstatistik.Series["dogrular"].Points.AddPoint("Eşitsizlikler", clsistatistik.genelistatistikler[3, 0]);
            chrtİstatistik.Series["yanlislar"].Points.AddPoint("Eşitsizlikler", clsistatistik.genelistatistikler[3, 1]);
            chrtİstatistik.Series["dogrular"].Points.AddPoint("Cebirsel İfadeler", clsistatistik.genelistatistikler[4, 0]);
            chrtİstatistik.Series["yanlislar"].Points.AddPoint("Cebirsel İfadeler", clsistatistik.genelistatistikler[4, 1]);
        }//öğrencinin konulara Göre Şimdiye Kadarki  Başarısını Gösterir


        public void sinavistatistik() {
            chrtSinav.Visible = true;
            chrtSinav.Series["dogrular"].Points.AddPoint("Olasilik", cozulenTestVerileri[0, 0]);
            chrtSinav.Series["yanlislar"].Points.AddPoint("Olasilik", cozulenTestVerileri[0, 1]);
            chrtSinav.Series["dogrular"].Points.AddPoint("Dogrusal Denklemler", cozulenTestVerileri[1, 0]);
            chrtSinav.Series["yanlislar"].Points.AddPoint("Dogrusal Denklemler", cozulenTestVerileri[1, 1]);
            chrtSinav.Series["dogrular"].Points.AddPoint("Çarpanlar Ve Katları", cozulenTestVerileri[2, 0]);
            chrtSinav.Series["yanlislar"].Points.AddPoint("Çarpanlar Ve Katları", cozulenTestVerileri[2, 1]);
            chrtSinav.Series["dogrular"].Points.AddPoint("Eşitsizlikler", cozulenTestVerileri[3, 0]);
            chrtSinav.Series["yanlislar"].Points.AddPoint("Eşitsizlikler", cozulenTestVerileri[3, 1]);
            chrtSinav.Series["dogrular"].Points.AddPoint("Cebirsel İfadeler", cozulenTestVerileri[4, 0]);
            chrtSinav.Series["yanlislar"].Points.AddPoint("Cebirsel İfadeler", cozulenTestVerileri[4, 1]);


        }


        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            kullaniciid = clskullaniciGirisi.kullaniciBilgileriYaz(kullanici, lblOgrenciAd, lblOgrenciEPosta, lblOgrenciTel);
            istatistikGoruntule();
        }

        private void btnSınavaBasla_Click(object sender, EventArgs e)
        {
            chrtSinav.Visible = false;
            testsifirla();
            sınavSuresi.Start();
            siklarEnableTrue();
            btnSonrakisoru.Visible = true;
            
            sorusayilarigetir();
            MessageBox.Show(clssorugetir.ogrencidogruYanlislar[0, 0] + "," + clssorugetir.ogrencidogruYanlislar[0, 1]);
            MessageBox.Show(kullaniciid + "," + konularaGoreCozulecekSoruSayisi[0].ToString() + "," + konularaGoreCozulecekSoruSayisi[1].ToString() + "," + konularaGoreCozulecekSoruSayisi[2].ToString() + "," + konularaGoreCozulecekSoruSayisi[3].ToString() + "," + konularaGoreCozulecekSoruSayisi[4].ToString());
            btnSınavaBasla.Visible = false;
            SoruGoster();

        }

        private void btnSonrakisoru_Click(object sender, EventArgs e)
        {

            SoruGoster();
            siklarEnableTrue();
            if (btnSonrakisoru.Text == "Testi Bitir") {
                testiBitir();
            }

        }

        private void btnA_Click(object sender, EventArgs e)
        {

            siklarEnableFalse();
            if (clssorugetir.dogruSik == 1)
            {
                dogru();
            }
            else {
                yanlis();
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {

            siklarEnableFalse();
            if (clssorugetir.dogruSik == 2)
            {
                dogru();
            }
            else
            {
                yanlis();
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {

            siklarEnableFalse();
            if (clssorugetir.dogruSik == 3)
            {
                dogru();
            }
            else
            {
                yanlis();
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {

            siklarEnableFalse();
            if (clssorugetir.dogruSik == 4)
            {
                dogru();
            }
            else
            {
                yanlis();
            }
        }


    } 
}
