using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Geometry
    {
        public int RectangleArea(int a, int b)
        {
            return a * b;
        }
    }

    static class Program
    {
        static void Main(String[] args)
        {
            Geometry geometry = new Geometry();
        }
    }
}
