using System;

namespace RemediPBO_MBG
{
    abstract class PaketMBG
    {
        private string idPaket;
        private string namaPaket;
        private int stokDapur;

        public PaketMBG(string idPaket, string namaPaket, int stokDapur)
        {
            this.idPaket = idPaket;
            this.namaPaket = namaPaket;
            StokDapur = stokDapur; 
        }

        public string IdPaket
        {
            get { return idPaket; }
            set { idPaket = value; }
        }

        public string NamaPaket
        {
            get { return namaPaket; }
            set { namaPaket = value; }
        }

        public int StokDapur
        {
            get { return stokDapur; }
            private set
            {
                if (value < 0)
                {
                    stokDapur = 0;
                }
                else
                {
                    stokDapur = value;
                }
            }
        }

        public bool KurangiStok(int jumlah)
        {
            if (jumlah <= 0)
            {
                return false; 
            }
            if (jumlah > stokDapur)
            {
                return false; 
            }
            stokDapur = stokDapur - jumlah;
            return true;
        }

        public abstract int HitungBiaya(int jumlah);

        public virtual void TampilInfo()
        {
            Console.WriteLine("ID Paket   : " + idPaket);
            Console.WriteLine("Nama Paket : " + namaPaket);
            Console.WriteLine("Stok Dapur : " + stokDapur + " paket");
        }
    }
}