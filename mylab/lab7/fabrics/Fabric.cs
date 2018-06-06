using System.Drawing;

namespace my_primitive_paint
{
    public abstract class Fabric
    {
        public abstract MainFigure FactoryMethod(float fatness, Color color, Point upperLeft, Point lowerRight);
    }
}
