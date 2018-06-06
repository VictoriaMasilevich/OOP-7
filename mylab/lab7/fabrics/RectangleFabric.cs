using System.Drawing;

namespace my_primitive_paint
{
    class RectangleFabric : Fabric
    {
        public override MainFigure FactoryMethod(float fatness, Color color, Point upperLeft, Point lowerRight)
        {
            return new Rectangle(fatness, color, upperLeft, lowerRight);
        }
    }
}
