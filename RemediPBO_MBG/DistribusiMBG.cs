using System;

namespace RemediPBO_MBG
{
    class DistribusiMBG : DapatDidistribusikan
    {
        private Sekolah sekolahTujuan;
        private PaketMBG paketDikirim;
        private int jumlah;

        public DistribusiMBG(Sekolah sekolahTujuan, PaketMBG paketDikirim, int jumlah)
        {
            this.sekolahTujuan = sekolahTujuan;
            this.paketDikirim = paketDikirim;
            this.jumlah = jumlah;
        }

        public void KirimPaket()
        {
            if (jumlah <= 0)
            {
                Console.WriteLine("Distribusi MBG gagal! Jumlah paket harus lebih dari 0 (jumlah yang dikirim: " + jumlah + ").");
                return;
            }

            if (jumlah > paketDikirim.StokDapur)
            {
                Console.WriteLine("Distribusi MBG gagal! Jumlah paket (" + jumlah + ") melebihi stok dapur yang tersedia (" + paketDikirim.StokDapur + ").");
                return;
            }

            paketDikirim.KurangiStok(jumlah);
            sekolahTujuan.jumlahPaketDiterima = sekolahTujuan.jumlahPaketDiterima + jumlah;

            Console.WriteLine("Distribusi MBG berhasil! Sebanyak " + jumlah + " paket makanan telah dikirim ke sekolah " + sekolahTujuan.namaSekolah);
        }
    }
}