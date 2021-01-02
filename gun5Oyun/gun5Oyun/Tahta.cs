using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gun5Oyun
{
    class Tahta
    {
        private int[,] TahtaElemanDizisi;
        private int boyut;
        public void setTahtaElemanDizisi(int deger, int i, int j)
        {
            TahtaElemanDizisi[i, j] = deger;
        }

        /// <summary>
        /// Kurucu Method
        /// </summary>
        /// <param name="tahtaBoyutSatir"> Kullanıcıdan alınan zorluk derecesine göre belirlenen Satır Saysısı </param>
        /// <param name="tahtaBoyutSutun"> Kullanıcıdan alınan zorluk derecesine göre belirlenen Sütun Saysısı </param>
        public Tahta(int tahtaBoyutX, int tahtaBoyutY)
        {
            boyut = tahtaBoyutX;
            // tahta eleman dizisi için hafızada verilen boyutta yer ayırılır
            TahtaElemanDizisi = new int[tahtaBoyutX, tahtaBoyutY];
            for (int i = 0; i < tahtaBoyutX; i++)
            {
                for (int j = 0; j < tahtaBoyutY; j++)
                {
                    TahtaElemanDizisi[i, j] = -1;
                }
            }
        }

        // verilen konum değeri -1 ise boştur
        public bool KonumDoluMu(int x, int y)
        {
            return TahtaElemanDizisi[x, y] != -1;
        }

        public bool TahtadaBosYerVarmi()
        {
            // bir boş eleman varsa tahtada boş yer vardır
            foreach (int i in TahtaElemanDizisi)
            {
                if (i == -1)
                    return true;
            }
            // true dönmediyse döngü boyunca tahta doludur ve false döner
            return false;
        }
        

    }
}
