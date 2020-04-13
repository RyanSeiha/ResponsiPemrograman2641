using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsi
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawan pegawai = new karyawan
            {  Nama1 = "Ryan",Nik1 = "2641", Gaji1 = 4000000,
               Nama2 = "Arya", Nik2 = "2627", Gaji2 = 5000000
            };

            pegawai.infoGaji();
            Console.WriteLine();

            pegawai.kenaikanGaji();
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}