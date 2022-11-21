using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Geometry
    {
        public int СylinderVolume(int S, int h)
        {
            return S * h;
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
