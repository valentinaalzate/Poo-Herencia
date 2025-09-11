using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooHerencia.core
{
    public class Parallelogram : Rectangle
    {
        private double _h;
        public override double GetArea() => B * H;

        public override double GetPerimeter() => 2 * (A + B);
        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        public Parallelogram(string name, double a, double b, double h) : base(name, b, a)
        {
            H = h;
        }

        private double ValidateH(double h)
        {
            if (h < 0)
            {
                throw new Exception($"The height {h} must be greater than zero");
            }
            return h;
        }
    }

}
