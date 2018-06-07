using System.Collections.Generic;
using System.Drawing;

namespace my_primitive_paint
{
    public class ListOfFigures
    {
        private List<MainFigure> figures;

        public ListOfFigures(List<MainFigure> figures)
        {
            this.figures = figures;
        }
    }
}
