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
    public partial class OyunTahtasi : Form
    {
        Tahta tahta;
        int zorlukDuzeyi;

        public OyunTahtasi()
        {
            InitializeComponent();
            // default olarak bir radiobutton seçili olacak ve hamle sırası o kullanıcıda olacak
            rbKullanici1.Checked = true;
            // kullanıcı radiobuttonları değiştiremeyecek
            rbKullanici1.Enabled = false;
            rbKullanici2.Enabled = false;
        }

        public void OyunaBasla(int zorlukDuzeyi, string[] kullaniciIsimleri)
        {
            this.zorlukDuzeyi = zorlukDuzeyi;

            oyunTahtasiTablo.AutoSize = true;

            oyunTahtasiTablo.RowCount = zorlukDuzeyi;
            oyunTahtasiTablo.ColumnCount = zorlukDuzeyi;

            tahta = new Tahta(zorlukDuzeyi, zorlukDuzeyi);

            // kullanıcı isimleri dizisinde 1 eleman varsa bir radio button
            // iki eleman varsa iki radio button gözükür
            if (kullaniciIsimleri.Length == 1)
            {
                rbKullanici1.Text = kullaniciIsimleri[0];
                rbKullanici2.Text = "PC";
            }
            else
            {
                rbKullanici1.Text = kullaniciIsimleri[0];
                rbKullanici2.Text = kullaniciIsimleri[1];
            }
        }

        /// <summary>
        /// Bir hücreye iki defa tıklandığında hamle sırasına göre hücreye değer yerleştiriyor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void oyunTahtasiTablo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int y;
            int x;
            x = e.ColumnIndex;
            y = e.RowIndex;

            if (tahta.KonumDoluMu(y, x))
            {
                MessageBox.Show("Konum Dolu Başka konuma hamle yapınız");
                return;
            }


            if (rbKullanici1.Checked)
            {

                tahta.setTahtaElemanDizisi(0, y, x);
                oyunTahtasiTablo[x, y].Value = "0";
                rbKullanici1.Checked = false;
                rbKullanici2.Checked = true;


                // pc hamlesi
                if (rbKullanici2.Text == "PC")
                {
                    if (tahta.TahtadaBosYerVarmi())
                    {
                        do
                        {
                            Random rnd = new Random();
                            x = rnd.Next(this.zorlukDuzeyi);
                            y = rnd.Next(this.zorlukDuzeyi);
                        } while (tahta.KonumDoluMu(y, x) == true);

                        tahta.setTahtaElemanDizisi(1, y, x);
                        oyunTahtasiTablo[x, y].Value = "1";
                        rbKullanici1.Checked = true;

                        rbKullanici2.Checked = false;
                    }

                }
            }
            else
            {
                if (rbKullanici2.Text != "PC")
                {
                    tahta.setTahtaElemanDizisi(1, y, x);
                    oyunTahtasiTablo[x, y].Value = "1";
                    rbKullanici1.Checked = true;
                    rbKullanici2.Checked = false;
                }

            }
        }

        private void btnOyunBitir_Click(object sender, EventArgs e)
        {
            // tahtada boş yer yoksa methoddan çıksın
            if (tahta.TahtadaBosYerVarmi())
            {
                MessageBox.Show("Henüz Tahta Dolmadı");
                return;

            }

            int satirSayisi = oyunTahtasiTablo.RowCount;
            int sutunSayisi = oyunTahtasiTablo.ColumnCount;

            int eldekiDeger = 0;
            bool ayniMi = true;
            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < sutunSayisi; j++)
                {
                    if (eldekiDeger != int.Parse(oyunTahtasiTablo[i, j].Value.ToString()))
                        ayniMi = false;
                }
            }
            if (ayniMi == true)
                MessageBox.Show(rbKullanici2.Text + " Kazandı");
            else
            {
                if (rbKullanici2.Text == "PC")
                    MessageBox.Show("pc kazandı");
                else
                {
                    MessageBox.Show(rbKullanici2.Text + " kazandı");
                }
            }
        }

      
    }
}
