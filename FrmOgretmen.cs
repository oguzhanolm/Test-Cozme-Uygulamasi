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
using System.IO;

namespace TestCoz
{



    public partial class FrmOgretmen : DevExpress.XtraEditors.XtraForm
    {
        public FrmOgretmen frmOgretmen;
        clsKullaniciGirisi clskullanicigirisi = new clsKullaniciGirisi();
        clsSoruEkleGorsel clssorueklegorsel = new clsSoruEkleGorsel();
        clsSoruEkle clssoruekle = new clsSoruEkle();
        public String Kullanici;
        public String kullaniciid;
        public FrmOgretmen()
        {
            InitializeComponent();
        }

   
        private void FrmOgretmen_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dtbSoruCozDataSet1.tblKonular' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblKonularTableAdapter.Fill(this.dtbSoruCozDataSet1.tblKonular);
            kullaniciid = clskullanicigirisi.kullaniciBilgileriYaz(Kullanici, LblogretmenAd, LblOgretmenEposta, LblOgretmenTel);
        }     
       
        private void chkSoruGorseliEkle_CheckedChanged(object sender, EventArgs e)
        {

            clssorueklegorsel.GorselSoru(chkSoruGorseliEkle, picSoru, rchSoru, btnSoruGorselisec, txtSoruGorseliuzantisi);
            if (chkSoruGorseliEkle.Checked == false)
            {
                chkCevapGorseliEkle.Checked = false;
                chkCevapGorseliEkle.Enabled = false;
            }
            else {
                chkCevapGorseliEkle.Enabled = true;
            }

        }//sadece Soruya Görsel eklenecekse Gerekli Form objelerinin Ayarlarını yapar
        private void chkCevapGorseliEkle_CheckedChanged(object sender, EventArgs e)
        {
               clssorueklegorsel.GorselCevap(chkCevapGorseliEkle, picDogruCevap, picYanlisCevap1, picYanlisCevap2, picYanlisCevap3, txtDogruCevapGorseli, txtYanlisCevapGorseli1, txtYanlisCevapGorseli2, txtYanlisCevapGorseli3, btnDogruCevapGorseliSec, btnYanlisCevap1GorseliSec, btnYanlisCevap2GorseliSec, btnYanlisCevap3GorseliSec, rchDogruCevap, rchYanlisCevap1, rchYanlisCevap2, rchYanlisCevap3);
        }//Soruya ve cevaba Görsel eklenecekse gerekli form objelerinin ayarlarını Yapar
       
        
        
        


        
        private void btnSoruGorselisec_Click(object sender, EventArgs e)
        {
            ofdSoru.ShowDialog();
            txtSoruGorseliuzantisi.Text = ofdSoru.FileName.ToString();
            picSoru.ImageLocation=ofdSoru.FileName;
        }

        private void btnDogruCevapGorseliSec_Click(object sender, EventArgs e)
        {
            ofdDogruCevap.ShowDialog();
            txtDogruCevapGorseli.Text = ofdDogruCevap.FileName.ToString();
            picDogruCevap.ImageLocation = ofdDogruCevap.FileName;
        }

        private void btnYanlisCevap1GorseliSec_Click(object sender, EventArgs e)
        {
            ofdYanlisCevap1.ShowDialog();
            txtYanlisCevapGorseli1.Text = ofdYanlisCevap1.FileName.ToString();
            picYanlisCevap1.ImageLocation = ofdYanlisCevap1.FileName;
        }

        private void btnYanlisCevap2GorseliSec_Click(object sender, EventArgs e)
        {
            ofdYanlisCevap2.ShowDialog();
            txtYanlisCevapGorseli2.Text = ofdYanlisCevap2.FileName.ToString();
            picYanlisCevap2.ImageLocation = ofdYanlisCevap2.FileName;
        }

        private void btnYanlisCevap3GorseliSec_Click(object sender, EventArgs e)
        {
            ofdYanlisCevap3.ShowDialog();
            txtYanlisCevapGorseli3.Text = ofdYanlisCevap3.FileName.ToString();
            picYanlisCevap3.ImageLocation = ofdYanlisCevap3.FileName;
        }

        private void btnSoruEkle_Click(object sender, EventArgs e)
        {
            
            clssoruekle.mtdsoruEkle(chkSoruGorseliEkle, chkCevapGorseliEkle, rchSoru, rchDogruCevap, rchYanlisCevap1, rchYanlisCevap2,
             rchYanlisCevap3, cmbKonu, txtSoruGorseliuzantisi, picDogruCevap, picYanlisCevap1, picYanlisCevap2, picYanlisCevap3,
             picSoru, ofdDogruCevap, ofdYanlisCevap1, ofdYanlisCevap2, ofdYanlisCevap3, ofdSoru);
        }

   
    }
}
