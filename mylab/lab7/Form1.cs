using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace my_primitive_paint
{

    
    public partial class mainForm : Form
    {
        public Bitmap bmap;
        public Graphics graphics;
        public List<Fabric> allFabrics = new List<Fabric>()
        {
            new RectangleFabric(),
            new CircleFabric(),
            new SquareFabric(),
            new EllipseFabric()
        };

        public mainForm()
        {
            InitializeComponent();
            bmap = new Bitmap(picture.Width, picture.Height);
            graphics = Graphics.FromImage(bmap);
            CustomFigure.OpenCustomFigures(cmb_custom_figures, allFabrics);
        }

        private MainFigure figure;
        public Fabric maker;
        private List<JSON> jsonList = new List<JSON>();
        private List<Fabric> currentFabrics = new List<Fabric>();
        private const int fatness = 3;
        private Color color = Color.Pink;

        private void btn_clear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            jsonList.Clear();
            figureList.Clear();
            picture.Image = bmap;
            currentFabrics.Clear();
        }

        private void cb_figures_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_custom_figures.SelectedIndex = -1;
            maker = allFabrics[cb_figures.SelectedIndex];
        }


        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (customFigureIsChange)
            {
                if (CustomFigure.savedFigures.Count > 0)
                {
                    CustomFigure.SavingCustomFigures();
                }
            }
            
        }

        private bool customFigureIsChange = false;
        private bool isDrawing = false;
        private Point start, finish;
        private Bitmap tempBm;
        private List<MainFigure> figureList = new List<MainFigure>();

        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
                if (cmb_custom_figures.SelectedIndex >= 0)
                {
                    int index = cmb_custom_figures.SelectedIndex;
                    CustomFigure.DrawCustomFigure(index, graphics, e.Location);
                    picture.Invalidate();
                    picture.Image = bmap;
                }
                else
                {
                    if (cb_figures.SelectedIndex >= 0)
                    {
                        isDrawing = true;
                        start = new Point(e.X, e.Y);
                        figure = maker.FactoryMethod(fatness, color, start, start);
                        currentFabrics.Add(maker);
                    }
                }         
        }

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                finish = new Point(e.X, e.Y);
                tempBm = new Bitmap(bmap);
                picture.Image = tempBm;
                Graphics g = Graphics.FromImage(tempBm);
                figure.MouseDraw(g, finish);
                g.Dispose();
                picture.Invalidate();
            }
        }

        private void picture_MouseUp(object sender, MouseEventArgs e)
        {

            if (isDrawing)
            {
                finish = new Point(e.X, e.Y);
                Graphics g = Graphics.FromImage(bmap);
                figure.MouseDraw(g, finish);
                isDrawing = false;
                picture.Invalidate();
                figureList.Add(figure);
                jsonList.Add(new JSON() { fatness = fatness, color = color, topLeft = start, bottomRight = finish, figureName = maker.ToString() });
            }
        }

        private void cmb_custom_figures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_custom_figures.SelectedIndex >= 0)
            {
                cb_figures.SelectedIndex = -1;
            }   
        }

        private void btn_delete_custom_figure_Click(object sender, EventArgs e)
        {
            if(cmb_custom_figures.SelectedIndex >= 0)
            {
                customFigureIsChange = true;
                CustomFigure.DeleteCustomFigure(cmb_custom_figures.SelectedIndex, cmb_custom_figures);
            }
            else
            {
                MessageBox.Show("Выберите фигуру", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_add_custom_figure_Click(object sender, EventArgs e)
        {
            if (figureList.Count <= 1)
            {
                MessageBox.Show("Нарисуйте больше одной фигуры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                customFigureIsChange = true;
                CustomFigure.AddCustomFigure(currentFabrics, figureList, cmb_custom_figures);
            }
        }
    }
}