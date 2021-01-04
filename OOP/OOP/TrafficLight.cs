using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class TrafficLight
    {
        private string color;

        private void ChangeColor(string newColor)
        {
            if (color != newColor)
                color = newColor;
        }

        public string GetColor()
        {
            return color;
        }
    }
}
