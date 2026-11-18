using System;

namespace RemediPBO_MBG
{
    class PaketReguler : PaketMBG
    {
        private string isiPaket = "Nasi, Ayam, Sayur, Buah";

        public PaketReguler(string idPaket, string namaPaket, int stokDapur)
            : base(idPaket, namaPaket, stokDapur)
        {
        }
        public override int HitungBiaya(int jumlah)
        {
            return jumlah * 15000;
        }

        public override void TampilInfo()
        {
            base.TampilInfo(); 
            Console.WriteLine("Isi Paket  : " + isiPaket);
            Console.WriteLine("Harga      : Rp15000 per paket");
        }
    }
}