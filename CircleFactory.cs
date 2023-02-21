public class CircleFactory : ShapeFactory
{
    public override IShape CreateShape()
    {
        return new Circle();
    }
}