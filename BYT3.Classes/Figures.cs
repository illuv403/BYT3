namespace BYT3_Classes
{
    public interface IShape
    {
        double CalculateArea();
        double CalculateVolume();
    }

}


/*
 * All shape classes where modified to check for edge case scenario (one or more elements being <= 0)
 */
namespace BYT3_Classes
{
    public class Cube : IShape
    {
        private readonly double _side;

        public Cube(double side)
        {
            if (side <= 0)
            {
                throw new Exception("Cube side must be positive");
            }
            
            _side = side;
        }
        
        public double CalculateArea()
        {
            return 6 * Math.Pow(_side, 2);
        }

        public double CalculateVolume()
        {
            return Math.Pow(_side, 3);
        }
    }
}



namespace BYT3_Classes
{
    public class Rectangle : IShape
    {
        private readonly double _length;
        private readonly double _width;

        public Rectangle(double length, double width)
        {
            if (length <= 0 || width <= 0)
            {
                throw new Exception("Either rectangle width or length must be positive");
            }
            
            _length = length;
            _width = width;
        }

        public double CalculateArea()
        {
            return _length * _width;
        }

        public double CalculateVolume()
        {
            // For 2D shapes, volume is not applicable.
            // Height of 2D shape is 0, therefore volume is 0
            return 0;
        }
    }
}



namespace BYT3_Classes
{
    public class Cylinder : IShape
    {
        private readonly double _radius;
        private readonly double _height;

        public Cylinder(double radius, double height)
        {
            if (radius <= 0 || height <= 0)
            {
                throw new Exception("Either cylinder radius or height must be positive");
            }
            
            _radius = radius;
            _height = height;
        }

        public double CalculateArea()
        {
            return 2 * Math.PI * _radius * (_radius + _height);
        }

        public double CalculateVolume()
        {
            return Math.PI * Math.Pow(_radius, 2) * _height;
        }

    }
}


namespace BYT3_Classes
{
    public class Sphere : IShape
    {
        private readonly double _radius;

        public Sphere(double radius)
        {
            if (radius <= 0)
            {
                throw new Exception("Sphere radius must be positive");
            }
            
            _radius = radius;
        }
        
        public double CalculateArea()
        {
            return 4 * Math.PI * Math.Pow(_radius, 2);
        }

        public double CalculateVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(_radius, 3);
        }
    }
}