using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01
{
     public class Rectangle
    {
        private int length;
        private int width;

        public int Lenght
        {
        get{ return length;}
        set{length = value;}
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public Rectangle()
        {
            Width = 1;
            Lenght = 1;
        }
        public Rectangle(int Lenght, int Width)
        {
            this.Lenght = length;
            this.Width = width;
        }
        public int GetLenght()
        {
            return Lenght;
        }
        public int SetLenght(int setLength)
        {
            this.Lenght = setLength;
            return this.Lenght;

        }
        public int GetWidth()
        {
            return this.Width;

        }
        public int SetWidth(int width)
        {
            return this.Width = width;
        }

        public int GetPerimeter()
        {
            int perimeter = 2 * (this.Lenght + this.Width);
            return perimeter;
        }
        public int GetArea()
        {
            int area = this.Lenght * this.Width;
            return area;
        }
    }
}

