using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hraf5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            try
            {
                float x1 = float.Parse(textBoxX1.Text);
                float y1 = float.Parse(textBoxY1.Text);
                float x2 = float.Parse(textBoxX2.Text);
                float y2 = float.Parse(textBoxY2.Text);
                int K = int.Parse(textBoxK.Text);

                PointF P1 = new PointF(x1, y1);
                PointF P2 = new PointF(x2, y2);

                using (Graphics g = drawPanel.CreateGraphics())
                {
                    g.Clear(Color.White);
                    DrawDandelionFractal(g, P1, P2, K);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid numeric values for coordinates and order K.");
            }
        }

        private void DrawDandelionFractal(Graphics g, PointF P1, PointF P2, int K)
        {
            if (K == 0)
            {
                g.DrawLine(Pens.Black, P1, P2);
            }
            else
            {
                float dx = P2.X - P1.X;
                float dy = P2.Y - P1.Y;
                PointF P3 = new PointF(P1.X + dx / 3, P1.Y + dy / 3);
                PointF P4 = new PointF(P1.X + 2 * dx / 3, P1.Y + 2 * dy / 3);
                PointF P5 = new PointF(
                    (float)(P1.X + dx / 2 - Math.Sqrt(3) * dy / 6),
                    (float)(P1.Y + dy / 2 + Math.Sqrt(3) * dx / 6));

                DrawDandelionFractal(g, P1, P3, K - 1);
                DrawDandelionFractal(g, P3, P5, K - 1);
                DrawDandelionFractal(g, P5, P4, K - 1);
                DrawDandelionFractal(g, P4, P2, K - 1);
            }
        }
    }
}
