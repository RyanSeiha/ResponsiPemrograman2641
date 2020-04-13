using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace responsi
{
    class karyawan
    {
        public string Nama1 { get; set; }
        public string Nik1 { get; set; }
        public int Gaji1 { get; set; }
        public string Nama2 { get; set; }
        public string Nik2 { get; set; }
        public int Gaji2 { get; set; }


        public void infoGaji()
        {
            Console.WriteLine("No\tNim/Nama\t\tGaji");
            Console.WriteLine("=======================================");
            Console.WriteLine("1\t{0}\t{1}\t\t{2}", Nik1, Nama1, Gaji1);
            Console.WriteLine("2\t{0}\t{1}\t\t{2}", Nik2, Nama2, Gaji2);
        }
        public void kenaikanGaji()
        {
            if (Gaji1 < 0)
            {
                Gaji1 = 0;
            }
            else if (Gaji2 < 0)
            {
                Gaji2 = 0;
            }
            Console.WriteLine("\nAduh Pusing Gajiku Naik 10%");
            Console.WriteLine("\nNo\tNik/Nama\t\tGaji");
            Console.WriteLine("=======================================");
            Console.WriteLine("1\t{0}\t{1}\t\t{2}", Nik1, Nama1, Gaji1 + (Gaji1 * 0.1));
            Console.WriteLine("2\t{0}\t{1}\t\t{2}", Nik2, Nama2, Gaji2 + (Gaji2 * 0.1));
        }
    }
}