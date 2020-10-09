using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCoz
{
    class clsSoruEkleGorsel
    {


        public void soruEkleVisibleFalse(PictureBox picDogruCevap,PictureBox picYanlisCevap1,PictureBox picYanlisCevap2,PictureBox picYanlisCevap3,TextBox txtDogruCevapGorseli,
            TextBox txtYanlisCevapGorseli1, TextBox txtYanlisCevapGorseli2,TextBox txtYanlisCevapGorseli3,Button btnDogruCevapGorseliSec,Button btnYanlisCevap1GorseliSec,
            Button btnYanlisCevap2GorseliSec,Button btnYanlisCevap3GorseliSec,RichTextBox rchDogruCevap,RichTextBox rchYanlisCevap1,RichTextBox rchYanlisCevap2,RichTextBox rchYanlisCevap3)
        {
            
            picDogruCevap.Visible = false;
            picYanlisCevap1.Visible = false;
            picYanlisCevap2.Visible = false;
            picYanlisCevap3.Visible = false;
            txtDogruCevapGorseli.Visible = false;
            txtYanlisCevapGorseli1.Visible = false;
            txtYanlisCevapGorseli2.Visible = false;
            txtYanlisCevapGorseli3.Visible = false;
            btnDogruCevapGorseliSec.Visible = false;
            btnYanlisCevap1GorseliSec.Visible = false;
            btnYanlisCevap2GorseliSec.Visible = false;
            btnYanlisCevap3GorseliSec.Visible = false;
            rchDogruCevap.Visible = false;
            rchYanlisCevap1.Visible = false;
            rchYanlisCevap2.Visible = false;
            rchYanlisCevap3.Visible = false;
            rchDogruCevap.Text = "";
            rchYanlisCevap1.Text = "";
            rchYanlisCevap2.Text = "";
            rchYanlisCevap3.Text = "";


        }
        //soru ekranındaki gerekli Form objelerinin Visible Değerini False yapar

        public void GorselSoru(CheckBox soruEkle,PictureBox picSoru,RichTextBox rchSoru,Button btnSoruGorseliSec,TextBox txtSoruGorselUzantisi)
        {
            if (soruEkle.Checked == true)
            {
                picSoru.Visible = true;
                rchSoru.Width = 681;
                btnSoruGorseliSec.Visible = true;
                txtSoruGorselUzantisi.Visible = true;
            }
            else if (soruEkle.Checked == false)
            {
                picSoru.Image = null;
                picSoru.Visible = false;
                rchSoru.Width = 862;
                btnSoruGorseliSec.Visible = false;
                txtSoruGorselUzantisi.Visible = false;
                txtSoruGorselUzantisi.Text = "";
            }
        }
        //görsel içerikli soru eklenecekse gerekli Form objelierin Görünür yapar.

        public void GorselCevap(CheckBox chkCevapGorseliEkle, PictureBox picDogruCevap,PictureBox picYanlisCevap1, PictureBox picYanlisCevap2, 
            PictureBox picYanlisCevap3,TextBox txtDogruCevapGorseli,TextBox txtYanlisCevapGorseli1, TextBox txtYanlisCevapGorseli2 , TextBox txtYanlisCevapGorseli3,
            Button btnDogruCevapGorseliSec,Button btnYanlisCevap1GorseliSec,Button btnYanlisCevap2GorseliSec,Button btnYanlisCevap3GorseliSec,RichTextBox rchDogruCevap,
            RichTextBox rchYanlisCevap1,RichTextBox rchYanlisCevap2,RichTextBox rchYanlisCevap3)
        {
            soruEkleVisibleFalse(picDogruCevap, picYanlisCevap1, picYanlisCevap2, picYanlisCevap3, txtDogruCevapGorseli,
              txtYanlisCevapGorseli1,
              txtYanlisCevapGorseli2,
              txtYanlisCevapGorseli3,
              btnDogruCevapGorseliSec,
              btnYanlisCevap1GorseliSec,
              btnYanlisCevap2GorseliSec,
              btnYanlisCevap3GorseliSec,
              rchDogruCevap,
              rchYanlisCevap1,
              rchYanlisCevap2,
              rchYanlisCevap3);

            if (chkCevapGorseliEkle.Checked == true)
            {

                picDogruCevap.Visible = true;
                picYanlisCevap1.Visible = true;
                picYanlisCevap2.Visible = true;
                picYanlisCevap3.Visible = true;
                txtDogruCevapGorseli.Visible = true;
                txtYanlisCevapGorseli1.Visible = true;
                txtYanlisCevapGorseli2.Visible = true;
                txtYanlisCevapGorseli3.Visible = true;
                btnDogruCevapGorseliSec.Visible = true;
                btnYanlisCevap1GorseliSec.Visible = true;
                btnYanlisCevap2GorseliSec.Visible = true;
                btnYanlisCevap3GorseliSec.Visible = true;


                rchDogruCevap.Visible = false;
                rchYanlisCevap1.Visible = false;
                rchYanlisCevap2.Visible = false;
                rchYanlisCevap3.Visible = false;


            }
            else if (chkCevapGorseliEkle.Checked == false)
            {
                rchDogruCevap.Visible = true;
                rchYanlisCevap1.Visible = true;
                rchYanlisCevap2.Visible = true;
                rchYanlisCevap3.Visible = true;

                picDogruCevap.Visible = false;
                picYanlisCevap1.Visible = false;
                picYanlisCevap2.Visible = false;
                picYanlisCevap3.Visible = false;
                txtDogruCevapGorseli.Visible = false;
                txtYanlisCevapGorseli1.Visible = false;
                txtYanlisCevapGorseli2.Visible = false;
                txtYanlisCevapGorseli3.Visible = false;
                btnDogruCevapGorseliSec.Visible = false;
                btnYanlisCevap1GorseliSec.Visible = false;
                btnYanlisCevap2GorseliSec.Visible = false;
                btnYanlisCevap3GorseliSec.Visible = false;
            }
        }
        //Görsel İçerikli Cevap Eklenecekse gerekli Form objelerini Görünür


    }
}


