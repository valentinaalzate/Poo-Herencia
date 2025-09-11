using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooHerencia.core
{
    public class Trapeze : Triangle
    {
        private double _d;

        public double D
        {
            get => _d;
            set => _d = ValidateD(value);
        }

        public override double GetArea() => ((B + D) * H) / 2;

        public override double GetPerimeter() => A + B + C + D;


        public Trapeze(string name, double a, double b, double c, double h, double d) : base(name, a, b, c, h)
        {
            D = d;
        }
        private double ValidateD(double d)
        {

            if (d < 0)
            {
                throw new Exception($"The height {d} must be greater than zero");
            }
            return d;
        }
    }

}
