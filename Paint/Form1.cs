using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int xd, yd;

        bool paint = false, rectangle = false, brush = false, ellipse = false, line = false, eraser = false;

        public 
            Bitmap bmp;

        Color penColor = new Color(), penColorLast;

        public void ClearBack()
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            pictureBox1.Image = bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearBack();
            penColor = penColorLast = Color.Black;
            brush = true;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            penColor = colorDialog1.Color;
            penColorLast = penColor;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Visible = true;
            label2.Text = trackBar1.Value.ToString();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmpSave = (Bitmap)pictureBox1.Image;
            saveFileDialog1.DefaultExt = "bmp";
            saveFileDialog1.Filter = "(*.bmp)|*.bmp|(*.jpeg)|*.jpeg|(*.png)|*.png|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                bmpSave.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            xd = e.X;
            yd = e.Y;
            bmp = new Bitmap(pictureBox1.Image);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Pen myPen = new Pen(penColor, trackBar1.Value);
            if (paint && line)
            {
                    Bitmap bmp2 = new Bitmap(bmp);
                    Graphics g = Graphics.FromImage(bmp2);
                    g.DrawLine(myPen, xd, yd, e.X, e.Y);
                    g.Dispose();
                    pictureBox1.Image = bmp2;
                    pictureBox1.Invalidate();
            }
            if (paint && brush)
            {
                    bmp = new Bitmap(pictureBox1.Image);
                    Graphics g = Graphics.FromImage(bmp);
                    g.DrawLine(myPen, xd - trackBar1.Value / 2, yd - trackBar1.Value / 2, e.X + trackBar1.Value / 2, e.Y + trackBar1.Value / 2);
                    xd = e.X;
                    yd = e.Y;
                    pictureBox1.Image = bmp;
                    g.Dispose();
            }
            if (paint && rectangle)
            {
                    Bitmap bmp2 = new Bitmap(bmp);
                    Graphics g = Graphics.FromImage(bmp2);
                    if (xd < e.X && yd < e.Y)
                        g.DrawRectangle(myPen, xd, yd, Math.Abs(e.X - xd), Math.Abs(e.Y - yd));
                    else
                    if (xd < e.X && yd > e.Y)
                        g.DrawRectangle(myPen, xd, e.Y, Math.Abs(e.X - xd), Math.Abs(e.Y - yd));
                    else
                    if (xd > e.X && yd < e.Y)
                        g.DrawRectangle(myPen, e.X, yd, Math.Abs(e.X - xd), Math.Abs(e.Y - yd));
                    else
                    if (xd > e.X && yd > e.Y)
                        g.DrawRectangle(myPen, e.X, e.Y, Math.Abs(e.X - xd), Math.Abs(e.Y - yd));
                    g.Dispose();
                    pictureBox1.Image = bmp2;
                    pictureBox1.Invalidate();
            }
            if (paint && ellipse)
            {
                    Bitmap bmp2 = new Bitmap(bmp);
                    Graphics g = Graphics.FromImage(bmp2);
                    if (xd < e.X && yd < e.Y)
                        g.DrawEllipse(myPen, xd, yd, Math.Abs(e.X - xd), Math.Abs(e.Y - yd));
                    else
                    if (xd < e.X && yd > e.Y)
                        g.DrawEllipse(myPen, xd, e.Y, Math.Abs(e.X - xd), Math.Abs(e.Y - yd));
                    else
                    if (xd > e.X && yd < e.Y)
                        g.DrawEllipse(myPen, e.X, yd, Math.Abs(e.X - xd), Math.Abs(e.Y - yd));
                    else
                    if (xd > e.X && yd > e.Y)
                        g.DrawEllipse(myPen, e.X, e.Y, Math.Abs(e.X - xd), Math.Abs(e.Y - yd));
                    g.Dispose();
                    pictureBox1.Image = bmp2;
                    pictureBox1.Invalidate();
            }
            myPen.Dispose();
        }
   
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            bmp = (Bitmap)pictureBox1.Image;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (eraser)
                this.Cursor = System.Windows.Forms.Cursors.No;
            if (!eraser)
                this.Cursor = new Cursor("C:\\Users\\Admin\\Documents\\Visual Studio 2015\\Projects\\Paint\\pencil (1).ico");
                //this.Cursor = System.Windows.Forms.Cursors.Arrow;
         }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YesNO yesno = new YesNO();
            yesno.bmpSave = (Bitmap)pictureBox1.Image;
            yesno.Show();
        }

        private void clearBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearBack();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) pictureBox1.Refresh();
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            penColor = penColorLast;
            brush = false;
            line = true;
            rectangle = false;
            ellipse = false;
            eraser = false;
        }

        private void eraserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            penColor = Color.White;
            brush = true;
            line = false;
            rectangle = false;
            ellipse = false;
            eraser = true;
            //Cursor.Current = new Cursor("C:\\Users\\Admin\\Documents\\Visual Studio 2015\\Projects\\Paint\\pencil_2.ico");
            //Cursor.Current = Cursors.Hand;
            //this.Cursor = new Cursor("C:\\Users\\Admin\\Documents\\Visual Studio 2015\\Projects\\Paint\\pencil_2-2.png");
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            penColor = penColorLast;
            brush = false;
            line = false;
            rectangle = false;
            ellipse = true;
            eraser = false;
        }

        private void brushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            penColor = penColorLast;
            brush = true;
            line = false;
            rectangle = false;
            ellipse = false;
            eraser = false;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            penColor = penColorLast;
            brush = false;
            line = false;
            rectangle = true;
            ellipse = false;
            eraser = false;
        }
    }
}
