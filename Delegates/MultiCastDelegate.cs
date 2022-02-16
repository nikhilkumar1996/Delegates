using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MultiCast(int length, int breadth); 
    public class MultiCastDelegate
    {
        public void RectangleArea(int width, int height)
        {
            int area=width*height;
            Console.WriteLine("Area of Rectangle:"+"\t"+area);
        }
        public void RectanglePerimeter(int width, int height)
        {
            int perimeter=2*(width+height);
            Console.WriteLine("Perimeter of Rectangle:"+"\t"+perimeter);
        }
    }
}
