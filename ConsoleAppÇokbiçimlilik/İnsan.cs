using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppÇokbiçimlilik
{
    class İnsan
    {
        public virtual void change()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Title = "Bu bir örnektir";
            Console.WriteLine("");
            Console.WriteLine("Bu yazı renk değiştirerek yazılmıştır ...");
        }
    }
}
