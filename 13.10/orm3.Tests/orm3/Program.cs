using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orm3
{
    public class Calc
    {
        public float Div(float a, float b)
        {
            return a / b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calc x = new Calc();
        }
    }
}