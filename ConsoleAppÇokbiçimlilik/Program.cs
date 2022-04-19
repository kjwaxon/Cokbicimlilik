using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppÇokbiçimlilik
{
    class Program
    {
        static void Main(string[] args)
        {
            /* İnsan ins = new İnsan();
             ins.change();
             Console.ReadKey();
            */
            BritishPeople eng = new BritishPeople();

            eng.change();

            Console.ReadKey();
        }
    }
}
