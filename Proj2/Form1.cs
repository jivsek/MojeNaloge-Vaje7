using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj2
{
    public partial class Form1 : Form
    {
        Point zadnja_tocka = Point.Empty;
        bool mouseDown = new Boolean();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            zadnja_tocka = e.Location;
            mouseDown = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                if (zadnja_tocka != null)
                {
                    if (pictureBox1.Image == null)
                    {
                        Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                        pictureBox1.Image = bmp;
                    }

                    using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                    {
                        g.DrawLine(new Pen(Color.Black, 2), zadnja_tocka, e.Location);
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    }

                    pictureBox1.Invalidate();
                    zadnja_tocka = e.Location;
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            zadnja_tocka = Point.Empty;
        }

        private void btn_Pocisti_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = null;
                Invalidate();
            }
        }

        private void btn_Shrani_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"PNG|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(saveFileDialog.FileName);
                }
            }
        }
    }
}
