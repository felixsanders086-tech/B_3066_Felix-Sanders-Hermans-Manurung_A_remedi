using System;

namespace RemediPBO_MBG
{
    class Program
    {
        static void CetakStatus(Sekolah sekolah, PaketMBG paket)
        {
            Console.WriteLine("Stok " + paket.NamaPaket + " : " + paket.StokDapur);
            Console.WriteLine("Paket diterima " + sekolah.namaSekolah + " : " + sekolah.jumlahPaketDiterima);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== 1. INFORMASI SEKOLAH ===");
            Sekolah sekolah1 = new Sekolah("SKL001", "SDN 1 Jember", 0);
            Sekolah sekolah2 = new Sekolah("SKL002", "SMPN 2 Jember", 100);
            sekolah1.TampilInfo();
            Console.WriteLine();
            sekolah2.TampilInfo();

            Console.WriteLine();
            Console.WriteLine("=== 2. INFORMASI PAKET ===");
            PaketReguler reguler = new PaketReguler("PKT01", "Paket Reguler", 100);
            PaketKhusus khusus = new PaketKhusus("PKT02", "Paket Khusus", 50, "Vegetarian");
            reguler.TampilInfo();
            Console.WriteLine();
            khusus.TampilInfo();

            Console.WriteLine();
            Console.WriteLine("=== 3. HITUNG BIAYA ===");
            Console.WriteLine("Biaya 10 Paket Reguler : Rp" + reguler.HitungBiaya(10));
            Console.WriteLine("Biaya 10 Paket Khusus  : Rp" + khusus.HitungBiaya(10));

            Console.WriteLine();
            Console.WriteLine("=== 4. POLYMORPHISM ===");
            PaketMBG[] daftarPaketUji = { reguler, khusus };
            foreach (PaketMBG p in daftarPaketUji)
            {
                Console.WriteLine(p.NamaPaket + " x 5 = Rp" + p.HitungBiaya(5));
            }

            Console.WriteLine();
            Console.WriteLine("=== 5. DISTRIBUSI VALID ===");
            Console.WriteLine("Sebelum:");
            CetakStatus(sekolah1, reguler);
            DistribusiMBG distribusi1 = new DistribusiMBG(sekolah1, reguler, 30);
            distribusi1.KirimPaket();
            Console.WriteLine("Sesudah:");
            CetakStatus(sekolah1, reguler);

            Console.WriteLine();
            Console.WriteLine("=== 6. DISTRIBUSI GAGAL (MELEBIHI STOK) ===");
            Console.WriteLine("Sebelum:");
            CetakStatus(sekolah2, reguler);
            DistribusiMBG distribusi2 = new DistribusiMBG(sekolah2, reguler, 200);
            distribusi2.KirimPaket();
            Console.WriteLine("Sesudah (harus sama):");
            CetakStatus(sekolah2, reguler);

            Console.WriteLine();
            Console.WriteLine("=== 7. DISTRIBUSI GAGAL (JUMLAH 0 / NEGATIF) ===");
            Console.WriteLine("Sebelum:");
            CetakStatus(sekolah2, khusus);
            DistribusiMBG distribusi3 = new DistribusiMBG(sekolah2, khusus, 0);
            distribusi3.KirimPaket();
            DistribusiMBG distribusi4 = new DistribusiMBG(sekolah2, khusus, -5);
            distribusi4.KirimPaket();
            Console.WriteLine("Sesudah (harus sama):");
            CetakStatus(sekolah2, khusus);

            Console.WriteLine();
            Console.WriteLine("=== 8. DISTRIBUSI PAKET KHUSUS ===");
            DistribusiMBG distribusi5 = new DistribusiMBG(sekolah2, khusus, 20);
            distribusi5.KirimPaket();
            CetakStatus(sekolah2, khusus);

            Console.WriteLine();
            Console.WriteLine("=== 9. DATA MBG (PengelolaMBG) ===");
            PengelolaMBG pengelola = new PengelolaMBG();
            pengelola.TambahSekolah(sekolah1);
            pengelola.TambahSekolah(sekolah2);
            pengelola.TambahPaket(reguler);
            pengelola.TambahPaket(khusus);
            pengelola.TampilkanDataMBG();

            Console.ReadLine();
        }
    }
}