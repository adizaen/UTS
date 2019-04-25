using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2269
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Gaji Karyawan";
            // Membuat Objek
            Karyawan kr1 = new Karyawan("00098712", "Paijo", 2000000);
            Karyawan kr2 = new Karyawan("00098715", "Paimo", 3000000);

            Header();
            Console.WriteLine("1.\t{0}/{1}\t\t{2}", kr1.Nik, kr1.Nama, kr1.GajiBulanan);
            Console.WriteLine("2.\t{0}/{1}\t\t{2}", kr2.Nik, kr2.Nama, kr2.GajiBulanan);

            Console.WriteLine("\nAsikkk, gajiku naik 10%\n");
            Header();
            int total1, total2;
            total1 = kr1.GajiBulanan + ((kr1.GajiBulanan * 10) / 100);
            total2 = kr2.GajiBulanan + ((kr2.GajiBulanan * 10) / 100);

            Console.WriteLine("1.\t{0}/{1}\t\t{2}", kr1.Nik, kr1.Nama, total1);
            Console.WriteLine("2.\t{0}/{1}\t\t{2}", kr2.Nik, kr2.Nama, total2);

            Console.ReadKey();
        }
        static void Header()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("No.\tNik/Nama\t\tGaji Bulanan");
            Console.WriteLine("--------------------------------------------");
        }
    }
}
