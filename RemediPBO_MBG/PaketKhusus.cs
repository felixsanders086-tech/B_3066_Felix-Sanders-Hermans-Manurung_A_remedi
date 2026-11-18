using System;

namespace RemediPBO_MBG
{
    class PaketKhusus : PaketMBG
    {

        public string jenisDiet;

        public PaketKhusus(string idPaket, string namaPaket, int stokDapur, string jenisDiet)
            : base(idPaket, namaPaket, stokDapur)
        {
            this.jenisDiet = jenisDiet;
        }

        public override int HitungBiaya(int jumlah)
        {
            return jumlah * 20000;
        }

        public override void TampilInfo()
        {
            base.TampilInfo();
            Console.WriteLine("Jenis Diet : " + jenisDiet);
            Console.WriteLine("Harga      : Rp20000 per paket");
        }
    }
}