using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public class Rectangle
    {
        private int length = 1;
        private int width = 1;
        public Rectangle(int length, int width) { length = length; width = width; }
        public int Length
        {
            get { return this.length; }
            set {
                if (value <= 0) _ = this.length;
                else
                    this.length = value;
            }

        }
        public int Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0) _ = this.width;
                else
                {
                    this.width=value;
                }
            }
        }

        public int GetGetPerimeter
        {
            get
            {
                 return (length + width) * 2;
            }

        }
        public int GetArea
        {
            get
            {
                return length * width;
            }
        }
        public override string ToString()
        {
            return string.Format("perimeter is {0:F2}and area is {1:F2}",GetArea, GetGetPerimeter);
        }
    }  
}
