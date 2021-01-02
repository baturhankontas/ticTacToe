using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gun5Oyun
{
    public partial class KullaniciGiris : Form
    {
        int kullaniciSayisi;
        public KullaniciGiris()
        {
            InitializeComponent();
            
            int[] zorlukDuzeyleri = { 3, 4, 5 };
            for (int i = 0; i < 3; i++)
            {
                comboBoxZorluk.Items.Add(zorlukDuzeyleri[i]);
            }
            comboBoxZorluk.SelectedItem = comboBoxZorluk.Items[0];
        }

        private void KullaniciGizleGoster(bool goster, int kullaniciSayisi)
        {
            this.kullaniciSayisi = kullaniciSayisi;
            // birinci kullanıcı göster
            txtKullanici2.Visible = false;
            lblKullanici2.Visible = false;

            // ikinci kullanıcı göster
            if (kullaniciSayisi == 2)
            {
                txtKullanici2.Visible = true;
                lblKullanici2.Visible = true;
            }
        }

        /// <summary>
        /// RadioButtonda seçilen değere göre kullanıcı bilgilerini alır
        /// </summary>
        /// <param name="kullanici"> 1 ise PC || 0 ise Kişi </param>
        public void kullaniciGir(int kullaniciSayisi)
        {
            KullaniciGizleGoster(true, kullaniciSayisi);
        }

        private void btnOyunaBasla_Click(object sender, EventArgs e)
        {
            int zorlukDuzeyi = int.Parse(comboBoxZorluk.SelectedItem.ToString());
            string[] kullaniciIsimleri = new string[kullaniciSayisi];

            if (kullaniciSayisi == 1)
            {
                kullaniciIsimleri[0] = txtKulanici1.Text;
            }
            else
            {
                kullaniciIsimleri[0] = txtKulanici1.Text;
                kullaniciIsimleri[1] = txtKullanici2.Text;
            }

            OyunTahtasi oyunTahtasi = new OyunTahtasi();
            oyunTahtasi.OyunaBasla(zorlukDuzeyi, kullaniciIsimleri);
            oyunTahtasi.Show();
        }

    }
}
