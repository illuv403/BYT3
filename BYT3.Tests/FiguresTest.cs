using BYT3_Classes;

namespace BYT3_Tests
{
    [TestFixture]
    public class Tests
    {
        private readonly IShape _sphere = new Sphere(5);
        private readonly IShape _cube = new Cube(4);
        private readonly IShape _rectangle = new Rectangle(4, 8);
        private readonly IShape _cylinder = new Cylinder(3, 7);
        
        [Test]
        public void TestSphereInvalidArgument()
        {
            var ex = Assert.Throws<Exception>(() => new Sphere(-2));
            Assert.That(ex.Message, Is.EqualTo("Sphere radius must be positive"));
        }
        
        [Test]
        public void TestSphereCalculateArea()
        {
            Assert.That(_sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
        }

        [Test]
        public void TestSphereCalculateVolume()
        {
            Assert.That(_sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
        }
        
        [Test]
        public void TestCubeInvalidArgument()
        {
            var ex = Assert.Throws<Exception>(() => new Cube(-2));
            Assert.That(ex.Message, Is.EqualTo("Cube side must be positive"));
        }
        
        [Test]
        public void TestCubeCalculateArea()
        {
            Assert.That(_cube.CalculateArea(), Is.EqualTo(96.000));
        }

        [Test]
        public void TestCubeCalculateVolume()
        {
            Assert.That(_cube.CalculateVolume(), Is.EqualTo(64.000));
        }
        
        [Test]
        public void TestRectangleInvalidArgument()
        {
            var ex = Assert.Throws<Exception>(() => new Rectangle(-2, -2));
            Assert.That(ex.Message, Is.EqualTo("Either rectangle width or length must be positive"));
        }
        
        [Test]
        public void TestRectangleCalculateArea()
        {
            Assert.That(_rectangle.CalculateArea(), Is.EqualTo(32.000));
        }

        [Test]
        public void TestRectangleCalculateVolume()
        {
            Assert.That(_rectangle.CalculateVolume(), Is.EqualTo(0));
        }

        [Test]
        public void TestCylinderInvalidArgument()
        {
            var ex = Assert.Throws<Exception>(() => new Cylinder(-2, -2));
            Assert.That(ex.Message, Is.EqualTo("Either cylinder radius or height must be positive"));
        }
            
        [Test]
        public void TestCylinderCalculateArea()
        {
            Assert.That(_cylinder.CalculateArea(), Is.EqualTo(188.496).Within(0.001));
        }

        [Test]
        public void TestCylinderCalculateVolume()
        {
            Assert.That(_cylinder.CalculateVolume(), Is.EqualTo(197.920).Within(0.001));
        }
    }
}