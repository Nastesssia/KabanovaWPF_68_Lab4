using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabanovaWPF_68_Lab4
{
    internal class Linear : Root
    {
        public double A { get; set; }
        public double B { get; set; }


        public Linear(double a, double b)
        {
            A = a;
            B = b;
        }

        public override string Roots()
        {
            return (-B / A).ToString();
        }

        public override string PrintResult()
        {
            return $"Корень линейного уравнения = {Roots()}";
        }
    }
}
