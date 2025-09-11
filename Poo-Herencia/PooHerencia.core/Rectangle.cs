using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooHerencia.core
{
    public class Rectangle : Square
    {
        private double _b;

        public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }

        public Rectangle(String name, double b, double a) : base(name, a)
        {
            B = b;
        }

        public override double GetArea() => A * B;

        public override double GetPerimeter() => 2 * (A + B);


        private double ValidateB(double b)
        {

            if (b < 0)
            {
                throw new Exception($"The side {b} must be greater than zero");
            }
            return b;
        }


    }

}
