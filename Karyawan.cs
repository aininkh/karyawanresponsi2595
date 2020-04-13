using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2595
{
    public class Karyawan
    {
        public int No { get; set; }
        public string NIK { get; set; }
        public string Nama { get; set; }
        public double GajiBulanan { get; set; }

        public Karyawan(int _No, string _NIK, string _Nama, int _GajiBulanan)
        {

            No = _No;
            NIK = _NIK;
            Nama = _Nama;
            GajiBulanan = _GajiBulanan;

            if(GajiBulanan<0)
            {
                Console.WriteLine("Gaji tidak boleh kurang dari 0");
                GajiBulanan = 0;
            }

        }
    }
}
