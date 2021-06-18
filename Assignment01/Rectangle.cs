using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle(int alength, int awidth) { length = alength; width = awidth; }
       
        public int GetLength
        {
            get { return length; }
        }

        public void SetLength(int value)
        {
            length = value;
        }


        public int Width
        {
            get { return width; }
          
        }

        public void SetWidth(int value)
        {
            width = value;

        }

        public int GetGetPerimeter()
        {
          return (length + width) * 2;
        }
        public int GetArea()
        {
            return length * width;
        }
    }  
}

