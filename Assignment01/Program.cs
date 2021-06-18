using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter length");
            var length = int.Parse(Console.ReadLine());

            Console.WriteLine("enter length");
            var width = int.Parse(Console.ReadLine());

            Rectangle defaultRectangle = new Rectangle(length,width);

            Console.WriteLine(defaultRectangle.GetArea);

        }
    }
}
