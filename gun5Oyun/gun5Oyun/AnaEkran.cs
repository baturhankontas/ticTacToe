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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            // pc ile oynayacaksa kullaniciSayisi = 1
            // kişi ile oynayacaksa kullaniciSayisi = 2
            int kullaniciSayisi = rbPC.Checked == true ? 1 : 2;
            KullaniciGiris ke = new KullaniciGiris();
            ke.Show();
            ke.kullaniciGir(kullaniciSayisi);
        }

		private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
		{

		}
	}
}
