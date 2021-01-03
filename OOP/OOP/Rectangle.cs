using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Rectangle
    {
        public int a;
        public int b;

        public int Square()
        {
            return a * b;
        }

        public Rectangle(int value1, int value2)
        {
            a = value1;
            b = value2;
        }

        public Rectangle(int value)
        {
            a = value;
            b = value;
        }

        public Rectangle()
        {
            a = 6;
            b = 4;
        }
    }
}
