using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shahmat
{
    class Program
    {
        static void Main(string[] args)
        {
           
            OT far = new OT();
           
            while (true)
            {
                Console.WriteLine("Otni turgan joyni kiriting");
                Console.WriteLine("X o'qdagi nuqtasi");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Y o'qdagi nuqtasi");
                int y = int.Parse(Console.ReadLine());
                far.Uradi(x-1, y-1);
            }
        }


    }
}
