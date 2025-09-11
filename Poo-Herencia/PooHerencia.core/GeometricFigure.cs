namespace PooHerencia.core
{
    public abstract class GeometricFigure
    {
        //properties
        public string Name { get; set; } = null!;

        //methods abstract
        public abstract double GetArea();
        public abstract double GetPerimeter();

        override public string ToString()
        {
            return $"{Name,-15} => Area......: {GetArea(),15:N5}     Perimeter: {GetPerimeter(),15:N5}";

        }
    }
}
