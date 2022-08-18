using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void ekle (Musteri musteri)
        {
            Console.WriteLine("Yeni Musteri Eklendi... \n" + musteri.Adi);
        }
        public  void listele (Musteri musteri)
        {
            Console.WriteLine(musteri.Adi);
        }
        public void sil (Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi... \n" + musteri.Adi);
        }
    }
}
