using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4530
{
    internal class Karyawan
    {
        public int Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; } 
        public int gajinaik { get; set; }   
        
        public Karyawan (int Nik,string Nama,int GajiBulanan)
        {
            Nik = Nik;
            Nama = Nama;
            GajiBulanan = GajiBulanan;

            gajinaik = 10;
            if (GajiBulanan < 0)
            {
                GajiBulanan = 0;
            }    
        }
        public void getdapatbonus()
        {
            int bonus = GajiBulanan / gajinaik;
            GajiBulanan = GajiBulanan + bonus;
            Console.WriteLine("{0} \t{1}\t\t\t {2}", Nik,Nama,GajiBulanan);
        }
        public void PrintAndShow()
        {
            Console.WriteLine("{0}  \t{1}\t\t\t {2}", Nik, Nama, GajiBulanan);

        }
    }
}
