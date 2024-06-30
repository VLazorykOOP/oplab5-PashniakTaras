using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hraf5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            // Get coordinates and vectors from input fields
            float x1 = float.Parse(txtX1.Text);
            float y1 = float.Parse(txtY1.Text);
            float x2 = float.Parse(txtX2.Text);
            float y2 = float.Parse(txtY2.Text);
            float vx1 = float.Parse(txtVx1.Text);
            float vy1 = float.Parse(txtVy1.Text);
            float vx2 = float.Parse(txtVx2.Text);
            float vy2 = float.Parse(txtVy2.Text);

            // Create graphics object
            Graphics g = pnlDrawingArea.CreateGraphics();
            g.Clear(Color.White);

            // Draw Hermite curve
            DrawHermiteCurve(g, x1, y1, x2, y2, vx1, vy1, vx2, vy2);
        }

        private void DrawHermiteCurve(Graphics g, float x1, float y1, float x2, float y2, float vx1, float vy1, float vx2, float vy2)
        {
            Pen pen = new Pen(Color.Black);
            int steps = 100;
            for (int i = 0; i < steps; i++)
            {
                float t1 = (float)i / steps;
                float t2 = (float)(i + 1) / steps;

                float[] p1 = Hermite(t1, x1, y1, x2, y2, vx1, vy1, vx2, vy2);
                float[] p2 = Hermite(t2, x1, y1, x2, y2, vx1, vy1, vx2, vy2);

                g.DrawLine(pen, p1[0], p1[1], p2[0], p2[1]);
            }
        }

        private float[] Hermite(float t, float x1, float y1, float x2, float y2, float vx1, float vy1, float vx2, float vy2)
        {
            float h1 = 2 * t * t * t - 3 * t * t + 1;
            float h2 = -2 * t * t * t + 3 * t * t;
            float h3 = t * t * t - 2 * t * t + t;
            float h4 = t * t * t - t * t;

            float x = h1 * x1 + h2 * x2 + h3 * vx1 + h4 * vx2;
            float y = h1 * y1 + h2 * y2 + h3 * vy1 + h4 * vy2;

            return new float[] { x, y };
        }
    }
}
