using System.Collections.Generic;

namespace APPPInCSharp_CompositePattern
{
    public class CompositeShape : Shape
    {
        private List<Shape> itsShapes = new List<Shape>();

        public void Add(Shape s)
        {
            itsShapes.Add(s);
        }

        public void Draw()
        {
            foreach (var shape in itsShapes)
            {
                shape.Draw();
            }
        }
    }
}