public class RectangleFactory : ShapeFactory
{
    public override IShape CreateShape()
    {
        return new Rectangle();
    }
}