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
            string length, width;

            do
            {
                Console.WriteLine("Enter length of the rectangle");
                length = Console.ReadLine();
            } while (Int32.Parse(length) < 1);
            
            do
            {
                Console.WriteLine("Enter width of the rectangle");
                width = Console.ReadLine();
            } while (Int32.Parse(width) < 1);
            
            
            Rectangle newRectangle = new Rectangle(Int32.Parse(length), Int32.Parse(width));

            DisplayOption();
            
            string option = Console.ReadLine();

            var result = DisplayMenuOption(Int32.Parse(option), Int32.Parse(length), Int32.Parse(width), newRectangle);
            
            Console.WriteLine(result);
        }
        
        static int? DisplayMenuOption(int option, int length, int width, Rectangle newRectangle)
        {
            var result = 0;
            switch (option)
            {
                case 1:
                    result = newRectangle.GetLength();
                    break;
                case 2:
                    result = newRectangle.SetLength(length);
                    break;
                case 3:
                    result = newRectangle.GetWidth();
                    break;
                case 4:
                    result = newRectangle.SetWidth(width);
                    break;
                case 5:
                    result = newRectangle.GetPerimeter();
                    break;
                case 6:
                    result = newRectangle.GetArea();
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
            }

            return result;
        }

        static void DisplayOption()
        {
            Console.WriteLine("OPTION");
            Console.WriteLine("1. Get Rectangle Length");
            Console.WriteLine("2. Change Rectangle Length");
            Console.WriteLine("3. Get Rectangle Length");
            Console.WriteLine("4. Change Rectangle Width");
            Console.WriteLine("5. Get Rectangle Perimeter");
            Console.WriteLine("6. Get Rectangle Area");
            Console.WriteLine("7. Exit");
        }
    }
}