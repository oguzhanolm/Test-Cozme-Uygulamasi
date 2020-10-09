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
    public partial class FrmKullaniciGirisi : DevExpress.XtraEditors.XtraForm
    {
        public FrmKullaniciGirisi()
        {
            InitializeComponent();
        }

        private void formDegistir(String ekranid,String Kullanici)
        {


            if (ekranid == "0")
            {
                FrmOgrenci frmogrenci = new FrmOgrenci();
                frmogrenci.kullanici = Kullanici;
                frmogrenci.Show();
            }
            else if (ekranid == "1")
            {
                FrmOgretmen frmogretmen = new FrmOgretmen();
                frmogretmen.Kullanici = Kullanici;
                frmogretmen.Show();
            }
            this.Hide();

        }//Başarılı Kullanıcı Girişlerinde Formlar Arası Geçişin Yapılmasını Sağlar 


        private void Admin_Load(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            clsKullaniciGirisi kulgir = new clsKullaniciGirisi();

            if (txtKullaniciAdi.Text != "" && txtPass.Text != "" && cmbKullaniciTuru.Text != "")
            {
                kulgir.kimlikDogrulama(txtKullaniciAdi.Text, txtPass.Text, cmbKullaniciTuru.SelectedIndex.ToString());

                if (kulgir.girisDurum == 1)
                {
                    formDegistir(cmbKullaniciTuru.SelectedIndex.ToString(),txtKullaniciAdi.Text);
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcıadi veya Parrola");
                }
            }
            else
            {
                MessageBox.Show("Yukarıdaki Bilgiler Boş Bırakılamaz");
            }
        }
    }
}