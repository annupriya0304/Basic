using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime dt = DateTime.Now;
            string abc = dt.Date.ToShortDateString(); 

            Console.WriteLine(abc);
            Console.ReadKey();
        }
    }
}
