using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestCoz
{
    class clsSoruEkle
    {
        clsSoruEkleDb soruEkleDb = new clsSoruEkleDb();
        String[] eklenecekSoru = new string[10];


        //Database ClasınaGönderen Methodlar ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        public void mtdsoruEkle(CheckBox chkSoruGorseliEkle,CheckBox chkCevapGorseliEkle,RichTextBox rchSoru,RichTextBox rchDogruCevap,RichTextBox rchYanlisCevap1, RichTextBox rchYanlisCevap2,
            RichTextBox rchYanlisCevap3,ComboBox cmbKonu,TextBox txtSoruGorseliuzantisi,PictureBox picDogruCevap,PictureBox picYanlisCevap1,PictureBox picYanlisCevap2,PictureBox picYanlisCevap3,
            PictureBox picSoru, OpenFileDialog ofdDogruCevap,OpenFileDialog ofdYanlisCevap1,OpenFileDialog ofdYanlisCevap2,OpenFileDialog ofdYanlisCevap3,OpenFileDialog ofdSoru)
        {
            if (cmbKonu.Text != "")
            {
                if (chkSoruGorseliEkle.Checked == false){
                        metinicerikli(rchSoru, rchDogruCevap, rchYanlisCevap1, rchYanlisCevap2, rchYanlisCevap3, cmbKonu);
                }//Görsel içermeyen Soru verisini methoda Gönderir    

               if (chkSoruGorseliEkle.Checked == true){
                        sadeceSorudaGorselİceren(rchSoru, rchDogruCevap, rchYanlisCevap1, rchYanlisCevap2, rchYanlisCevap3, cmbKonu, ofdSoru,txtSoruGorseliuzantisi);
                }//sadece Soruda Gorselli olan sorunun verilerini methoda Gönderir



                if (chkCevapGorseliEkle.Checked == true && chkSoruGorseliEkle.Checked == true){
                    soruVeCevaptaGorseliceren( rchSoru,  picDogruCevap,  picYanlisCevap1,  picYanlisCevap2,  picYanlisCevap3,  ofdDogruCevap,  ofdYanlisCevap1,  ofdYanlisCevap2,  ofdYanlisCevap3,  cmbKonu,  picSoru,  ofdSoru);
                }//Soru ve Cevapta göreseli olan soruların Verilerini methoda gönderir
            }
            else
            {
                MessageBox.Show("lütfen Soru ve Şıkların Tümünü Doldurun !!!");
            }


        }//eklenecek Soruların Verilerini methoda Gönderir














        //Database ClasınaGönderen Methodlar ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        public void objeTemizle(CheckBox chkSoruGorseliEkle, CheckBox chkCevapGorseliEkle, RichTextBox rchSoru, RichTextBox rchDogruCevap, RichTextBox rchYanlisCevap1, RichTextBox rchYanlisCevap2,
            RichTextBox rchYanlisCevap3, ComboBox cmbKonu, TextBox txtSoruGorseliuzantisi, PictureBox picDogruCevap, PictureBox picYanlisCevap1, PictureBox picYanlisCevap2, PictureBox picYanlisCevap3,
            PictureBox picSoru, OpenFileDialog ofdDogruCevap, OpenFileDialog ofdYanlisCevap1, OpenFileDialog ofdYanlisCevap2, OpenFileDialog ofdYanlisCevap3, OpenFileDialog ofdSoru) {

           
                chkSoruGorseliEkle.Checked = false;
                chkCevapGorseliEkle.Checked = false;
                rchSoru.Text = "";
                rchDogruCevap.Text = "";
                rchYanlisCevap1.Text = "";
                rchYanlisCevap2.Text = "";
                rchYanlisCevap3.Text = "";
                cmbKonu.Text = "";
                txtSoruGorseliuzantisi.Text = "";
                picDogruCevap.Image = null;
                picYanlisCevap1.Image = null;
                picYanlisCevap2.Image = null;
                picYanlisCevap3.Image = null;
                picSoru.Image = null;
                ofdDogruCevap.FileName = null;
                ofdYanlisCevap1.FileName = null;
                ofdYanlisCevap2.FileName = null;
                ofdYanlisCevap3.FileName = null;
                ofdSoru.FileName = null;

        }


        //Database ClasınaGönderen Methodlar ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        public void metinicerikli(RichTextBox rchSoru, RichTextBox rchDogruCevap, RichTextBox rchYanlisCevap1, RichTextBox rchYanlisCevap2,RichTextBox rchYanlisCevap3, ComboBox cmbKonu) {

            if (rchSoru.Text != "" && rchDogruCevap.Text != "" && rchYanlisCevap1.Text != "" && rchYanlisCevap2.Text != "" && rchYanlisCevap3.Text != "" )
            {
                eklenecekSoru[0] = "0";//soruturu
                eklenecekSoru[1] = (cmbKonu.SelectedIndex + 1).ToString();//konu
                eklenecekSoru[2] = rchSoru.Text;//Soru
                eklenecekSoru[3] = rchDogruCevap.Text;
                eklenecekSoru[4] = rchYanlisCevap1.Text;
                eklenecekSoru[5] = rchYanlisCevap2.Text;
                eklenecekSoru[6] = rchYanlisCevap3.Text;
                soruEkleDb.metinSoruEkle(eklenecekSoru);
                rchSoru.Text = "";
                rchDogruCevap.Text = "";
                rchYanlisCevap1.Text = "";
                rchYanlisCevap2.Text = "";
                rchYanlisCevap3.Text = "";
                cmbKonu.Text = "";

      
            }
            else
            {
                MessageBox.Show("lütfen Soru ve Şıkların Tümünü Doldurun !!!");

            }
        }
        //Görsel içermeyen Soru Eklemek için gerekli veriyi database Classına Gönderir 


        public int rchKontrol(RichTextBox rchSoru, RichTextBox rchDogruCevap, RichTextBox rchYanlisCevap1, RichTextBox rchYanlisCevap2, RichTextBox rchYanlisCevap3,TextBox txtsorugorsel)
        {

            if (rchSoru.Text != "" && rchDogruCevap.Text != "" && rchYanlisCevap1.Text != "" && rchYanlisCevap2.Text != "" && rchYanlisCevap3.Text != "" && txtsorugorsel.Text!="")
            {
                return 1;
            }
            return 0;

        }

        public void sadeceSorudaGorselİceren(RichTextBox rchSoru, RichTextBox rchDogruCevap, RichTextBox rchYanlisCevap1, RichTextBox rchYanlisCevap2, RichTextBox rchYanlisCevap3,ComboBox cmbKonu,OpenFileDialog @ofdSoru,TextBox txtsorugorsel) {

            if (rchKontrol(rchSoru,rchDogruCevap,rchYanlisCevap1,rchYanlisCevap2,rchYanlisCevap3,txtsorugorsel) ==1)
            {
                string ad = "image\\" + DateTime.Now.Ticks.ToString() + ".jpg";
                File.Copy(@ofdSoru.FileName, @ad);

                eklenecekSoru[0] = "2";//soruturu
                eklenecekSoru[1] = (cmbKonu.SelectedIndex + 1).ToString();//konu
                eklenecekSoru[2] = rchSoru.Text;//Soru
                eklenecekSoru[3] = rchDogruCevap.Text;
                eklenecekSoru[4] = rchYanlisCevap1.Text;
                eklenecekSoru[5] = rchYanlisCevap2.Text;
                eklenecekSoru[6] = rchYanlisCevap3.Text;
                eklenecekSoru[7] = ad;
                soruEkleDb.sadecSorudaGorselliSoruEkle(eklenecekSoru);
                rchSoru.Text="";//Soru
                rchDogruCevap.Text="";
                rchYanlisCevap1.Text="";
                rchYanlisCevap2.Text="";
                rchYanlisCevap3.Text="";
                ad="";
            }
            else
            {
                MessageBox.Show("lütfen Soru ve Şıkların Tümünü Doldurun !!!");

            }


        }
        //sadece Soruda Gorselli olan soru Eklemek için gerekli veriyi database Classına Gönderir 

        public void soruVeCevaptaGorseliceren(RichTextBox rchSoru, PictureBox picDogruCevap, PictureBox picYanlisCevap1, PictureBox picYanlisCevap2, PictureBox picYanlisCevap3, OpenFileDialog ofdDogruCevap,
            OpenFileDialog ofdYanlisCevap1, OpenFileDialog ofdYanlisCevap2, OpenFileDialog ofdYanlisCevap3, ComboBox cmbKonu,PictureBox picSoru,OpenFileDialog ofdSoru) {


            if (picSoru.ImageLocation != null && picDogruCevap.ImageLocation != null && picYanlisCevap1.ImageLocation != null && picYanlisCevap2.ImageLocation != null && picYanlisCevap3.ImageLocation != null && rchSoru.Text != "")
            {
                String[] imgAdres = new string[5];
                imgAdres[0] = "image\\" + DateTime.Now.Ticks.ToString() + ".jpg";
                File.Copy(ofdSoru.FileName, imgAdres[0]);
                imgAdres[1] = "image\\" + DateTime.Now.Ticks.ToString() + ".jpg";
                File.Copy(ofdDogruCevap.FileName, imgAdres[1]);
                imgAdres[2] = "image\\" + DateTime.Now.Ticks.ToString() + ".jpg";
                File.Copy(ofdYanlisCevap1.FileName, imgAdres[2]);
                imgAdres[3] = "image\\" + DateTime.Now.Ticks.ToString() + ".jpg";
                File.Copy(ofdYanlisCevap2.FileName, imgAdres[3]);
                imgAdres[4] = "image\\" + DateTime.Now.Ticks.ToString() + ".jpg";
                File.Copy(ofdYanlisCevap3.FileName, imgAdres[4]);


                eklenecekSoru[0] = "1";//soruturu
                eklenecekSoru[1] = (cmbKonu.SelectedIndex + 1).ToString();//konu
                eklenecekSoru[2] = rchSoru.Text;//Soru
                eklenecekSoru[3] = imgAdres[1];
                eklenecekSoru[4] = imgAdres[2];
                eklenecekSoru[5] = imgAdres[3];
                eklenecekSoru[6] = imgAdres[4];
                eklenecekSoru[7] = imgAdres[0];
                soruEkleDb.soruVeCevaptaGorselliSoruEkle(eklenecekSoru);
                rchSoru.Text="";//Soru
            }
            else
            {
                MessageBox.Show("lütfen Soru ve Şıkların Tümünü Doldurun !!!");
            }


        } 
        //Soru ve Cevapta Görseli olan Sorunun Eklemek için gerekli veriyi database Classına Gönderir 




    }
}
