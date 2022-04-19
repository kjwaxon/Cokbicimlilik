using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppÇokbiçimlilik
{
    class BritishPeople : İnsan
    {
        public override void change()
        {

            Console.Title = "This is an Example";
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello mr and ms ...");
        }
    }
}
