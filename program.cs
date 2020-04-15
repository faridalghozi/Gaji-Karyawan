using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2824
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan(12345678, "Adit", 1000000);
            Karyawan karyawan2 = new Karyawan(98765432, "Sandi", 4000000);


            Console.WriteLine("NIK \t\t Nama \t Gaji");
            Console.WriteLine("=================================");
            karyawan.showKaryawan();
            karyawan2.showKaryawan();

            Console.WriteLine("\nMANTAPPPP!!!!! GAJI NAIK 10%\n");

            Console.WriteLine("NIK \t\t Nama \t Gaji");
            Console.WriteLine("=================================");
            karyawan.naikGaji();
            karyawan2.naikGaji();

            Console.ReadKey();
        }
    }

    class Karyawan
    {
        public int nik { get; set; }
        public string nama { get; set; }
        public int gajiBulanan { get; set; }

        public Karyawan(int nik, string nama, int gaji)
        {
            this.nik = nik;
            this.nama = nama;

            if (gaji < 0)
            {
                this.gajiBulanan = 0;
            }
            else
            {
                this.gajiBulanan = gaji;
            }
        }

        public void showKaryawan()
        {
            Console.WriteLine("{0} \t {1} \t {2}", nik, nama, gajiBulanan);
        }

        public void naikGaji()
        {
            double tmp = 0;
            tmp = 0.1 * gajiBulanan;
            gajiBulanan += Convert.ToInt32(tmp);
            Console.WriteLine("{0} \t {1} \t {2}", nik, nama, gajiBulanan);
        }
    }
}