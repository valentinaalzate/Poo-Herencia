using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooHerencia.core
{
    public class Circle : GeometricFigure
    {
        private double _r;
        public double R
        {
            get => _r;
            set => _r = ValidateR(value);
        }


        public Circle(string name, double r)
        {
            Name = name;
            R = r;
        }


        public override double GetArea()
        {
            return (Math.PI * Math.Pow(R, 2));
        }

        public override double GetPerimeter()
        {
            return (2 * Math.PI * R);
        }


        private double ValidateR(double r)
        {
            if (r < 0)
            {
                throw new Exception($"El radio {r} debe ser mayor a cero.");
            }
            return r;
        }


    }

}
