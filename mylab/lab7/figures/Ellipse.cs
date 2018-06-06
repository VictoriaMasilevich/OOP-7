using System.Drawing;

namespace my_primitive_paint
{
    public class Ellipse : MainFigure
    {
        public Ellipse(float fatness, Color color, Point topLeft, Point bottomRight) : base(fatness, color, topLeft, bottomRight) { }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(pen, topLeft.X, topLeft.Y, bottomRight.X - topLeft.X, bottomRight.Y - topLeft.Y);
        }

        public override void MouseDraw(Graphics g, Point finish)
        {
            g.DrawEllipse(pen, topLeft.X, topLeft.Y, finish.X - topLeft.X, finish.Y - topLeft.Y);
            bottomRight = finish;
        }
    }
}
