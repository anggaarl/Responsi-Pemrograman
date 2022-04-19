using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4384
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek Karyawan 1
            Karyawan karyawan1 = new Karyawan();

            // properties
            karyawan1.NIK = "21114384";
            karyawan1.Nama = "ANGGA";
            karyawan1.GajiBulanan = 3000000;

            // membuat objek Karyawan 2
            Karyawan karyawan2 = new Karyawan();

            // properties
            karyawan2.NIK = "21111234";
            karyawan2.Nama = "AIRUL";
            karyawan2.GajiBulanan = 2000000;

            Console.WriteLine("No. NIK\t\t\tNama\t\tGaji Bulanan (Rp.)");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("1. {0}\t\t{1}\t\t{2}", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2. {0}\t\t{1}\t\t{2}", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);
            Console.WriteLine("\n");
            Console.WriteLine("HOREEE NAIK GAJI 10%!! ");
            Console.WriteLine("\n");
            Console.WriteLine("----------Gaji Setelah Kenaikan 10%---------");
            Console.WriteLine("\n");
            Console.WriteLine("No. NIK\t\t\tNama\t\tGaji Bulanan (Rp.)");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("1. {0}\t\t{1}\t\t{2}", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan + (karyawan1.GajiBulanan * 0.10));
            Console.WriteLine("2. {0}\t\t{1}\t\t{2}", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan + (karyawan2.GajiBulanan * 0.10));
            Console.ReadKey();
        }
    }
}
