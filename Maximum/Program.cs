using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> list = new List<int>();

            int maximum = 0;

            for (int i = 0; i < 20; i++)
            {
                int szam = rnd.Next(1, 101);
                list.Add(szam);
                Console.WriteLine(szam);
                if (maximum < szam) maximum = szam;
            }
            Console.WriteLine(" ");
            Console.WriteLine($"A legnagyobb elem a listában: {maximum}");
            Console.ReadKey();
        }
    }
}
