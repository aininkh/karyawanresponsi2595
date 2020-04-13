using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2595
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Karyawan karyawan1 = new Karyawan(1, "190302213", "Aini", 3000000);
            Karyawan karyawan2 = new Karyawan(2, "1903021224", "Aquilae", 2000000);

            Console.WriteLine("No Nik/Nama\tGaji Bulanan");
            Console.WriteLine("---------------------------");
            CetakGaji(karyawan1);
            CetakGaji(karyawan2);

            Console.WriteLine("\nKenaikan Gaji 10%");
            Console.WriteLine("No NIK/Nama\tGaji Bulanan");
            Console.WriteLine("---------------------------");
            NaikGaji(karyawan1);
            NaikGaji(karyawan2);
            Console.ReadKey();
        }

        static void CetakGaji(Karyawan pegawai)
        {
            Console.WriteLine(pegawai.No + ". "+ pegawai.NIK + " " + pegawai.Nama + " " + pegawai.GajiBulanan);
        }

        static void NaikGaji(Karyawan pegawai)
        {
            double kenaikan;
            kenaikan = pegawai.GajiBulanan * 0.1;
            pegawai.GajiBulanan = pegawai.GajiBulanan + kenaikan;
            Console.WriteLine(pegawai.No + ". " + pegawai.NIK + " " + pegawai.Nama + " " + pegawai.GajiBulanan);
        }
    }
}
