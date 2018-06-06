using System.Drawing;

namespace my_primitive_paint
{
    class SquareFabric : Fabric
    {
        public override MainFigure FactoryMethod(float fatness, Color color, Point upperLeft, Point lowerRight)
        {
            return new Square(fatness, color, upperLeft, lowerRight);
        }
    }
}
