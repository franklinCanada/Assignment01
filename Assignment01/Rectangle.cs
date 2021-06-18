﻿using System;
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

        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        public Rectangle(int privLength, int privWidth)
        {
            length = privLength;
            width = privWidth;
        }

        public int GetLength()
        {
            return length;
        }

        public int SetLength(int newLength)
        {
            length = newLength;
            return length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int newWidth)
        {
            width = newWidth;
            return width;
        }

        public int GetPerimeter()
        {
            return 2 * (length + width);
        }

        public int GetArea()
        {
            return length * width;
        }
        
    }
}

