using System;
using System.Collections.Generic;

namespace RemediPBO_MBG
{
    class PengelolaMBG
    {
        private List<Sekolah> daftarSekolah = new List<Sekolah>();
        private List<PaketMBG> daftarPaket = new List<PaketMBG>();

        public void TambahSekolah(Sekolah sekolah)
        {
            daftarSekolah.Add(sekolah);
        }

        public void TambahPaket(PaketMBG paket)
        {
            daftarPaket.Add(paket);
        }

        public void TampilkanDataMBG()
        {
            Console.WriteLine("Daftar Sekolah Penerima:");
            for (int i = 0; i < daftarSekolah.Count; i++)
            {
                Sekolah s = daftarSekolah[i];
                Console.WriteLine((i + 1) + ". " + s.idSekolah + " - " + s.namaSekolah + " | Paket diterima: " + s.jumlahPaketDiterima);
            }

            Console.WriteLine();
            Console.WriteLine("Daftar Paket & Stok Dapur:");
            for (int i = 0; i < daftarPaket.Count; i++)
            {
                PaketMBG p = daftarPaket[i];
                Console.WriteLine((i + 1) + ". " + p.IdPaket + " - " + p.NamaPaket + " | Stok: " + p.StokDapur);
            }
        }
    }
}