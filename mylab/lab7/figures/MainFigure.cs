using System.Drawing;

namespace my_primitive_paint
{

    public abstract class MainFigure 
    {

        public Color color;
   
        public float fatness;
        public Pen pen;

        public Point topLeft;
  
        public Point bottomRight;

        public Point[] points;


        public MainFigure(float fatness, Color color, Point topLeft, Point bottomRight)
        {
            this.fatness = fatness;
            this.color = color;
            this.topLeft = topLeft;
            this.bottomRight = bottomRight;
            pen = new Pen(color, fatness);
        }

        public MainFigure(float fatness, Color color, Point[] points)
        {
            this.points = points;
            this.fatness = fatness;
            this.color = color;
            pen = new Pen(color, fatness);
        }


        public virtual void Draw(Graphics graphics) { }

        public virtual void MouseDraw(Graphics g, Point finish) { }
    }
}
