using System.Drawing;

namespace my_primitive_paint
{
    class EllipseFabric : Fabric
    {
        public override MainFigure FactoryMethod(float fatness, Color color, Point upperLeft, Point lowerRight)
        {
            return new Ellipse(fatness, color, upperLeft, lowerRight);
        }
    }
}
