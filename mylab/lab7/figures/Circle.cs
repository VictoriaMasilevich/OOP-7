using System.Drawing;

namespace my_primitive_paint
{
    public class Circle : MainFigure
    {
        private int radius;

        public Circle(float fatness, Color color, Point topLeft, Point bottomRight) : base(fatness, color, topLeft, bottomRight)
        {
            radius = bottomRight.X - topLeft.X;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(pen, topLeft.X, topLeft.Y, radius, radius);
        }

        public override void MouseDraw(Graphics g, Point finish)
        {
            g.DrawEllipse(pen, topLeft.X, topLeft.Y, finish.Y - topLeft.Y, finish.Y - topLeft.Y);
            radius = finish.Y - topLeft.Y;
            bottomRight = new Point(topLeft.X + radius, finish.Y);
            g.Dispose();
        }
    }
}
