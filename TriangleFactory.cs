public class TriangleFactory : ShapeFactory
{
    public override IShape CreateShape()
    {
        return new Triangle();
    }
}