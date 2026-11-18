using System;

namespace RemediPBO_MBG
{
    class Sekolah
    {
        public string idSekolah;
        public string namaSekolah;
        public int jumlahPaketDiterima;

        public Sekolah(string idSekolah, string namaSekolah, int jumlahPaketDiterima)
        {
            this.idSekolah = idSekolah;
            this.namaSekolah = namaSekolah;
            this.jumlahPaketDiterima = jumlahPaketDiterima;
        }

        public void TampilInfo()
        {
            Console.WriteLine("ID Sekolah            : " + idSekolah);
            Console.WriteLine("Nama Sekolah          : " + namaSekolah);
            Console.WriteLine("Jumlah Paket Diterima : " + jumlahPaketDiterima + " paket");
        }
    }
}