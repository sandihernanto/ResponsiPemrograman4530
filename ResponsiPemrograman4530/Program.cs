using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4530
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nik\t\t\t Nama \t\t\t Gaji Bulanan");
   


            Karyawan karyawan1 = new Karyawan(190302123, "Paijo", 3000000);
            Karyawan karyawan2 = new Karyawan(190302124, "Jono", 2000000);

            karyawan1.Nik = 190302123;
            karyawan2.Nik = 190302124;
            karyawan1.Nama = "Paijo";
            karyawan2.Nama = "Jono";
            karyawan1.GajiBulanan = 3000000;
            karyawan2.GajiBulanan= 2000000;
            

            karyawan1.PrintAndShow();
            karyawan2.PrintAndShow();

            Console.WriteLine("\n\n Asyiiik kenaikan gaji 10% :)");
            Console.WriteLine("\n\nNik\t\t\t Nama \t\t\t Gaji");
          
            karyawan1.Nik = 190302123;
            karyawan2.Nik = 190302124;
            karyawan1.Nama = "Paijo";
            karyawan2.Nama = "Jono";
            karyawan1.GajiBulanan = 3000000;
            karyawan2.GajiBulanan = 2000000;


            karyawan1.getdapatbonus();
            karyawan2.getdapatbonus();

            Console.ReadKey();


        }
    }
}
