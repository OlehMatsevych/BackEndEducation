using System;
using System.Collections.Generic;
using System.Linq;

namespace Patterns
{
    public interface Shape
    {
        void draw();
    }
    public class Circle : Shape
    {
        private string Color { get; set; }
        private int X { get; set; }
        private int Y { get; set; }
        private int Radius { get; set; }

        public void draw()
        {
            throw new NotImplementedException();
        }
    }
    public class FlyweightFactory
    {
        private Dictionary<string, Shape> Shapes { get; set; }

        public Shape GetShape(string type)
        {
            Shape shape = null;
            if (Shapes.Keys.Contains(type))
            {
                return Shapes[type];
            }
            else
            {
                switch (type)
                {
                    case "Circle":
                        shape = new Circle();
                        break;
                }
                return shape;
            }
        }
    }
}
