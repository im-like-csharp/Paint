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
    public partial class YesNO : Form
    {
        public YesNO()
        {
            InitializeComponent();
        }

        public 
            Bitmap bmpSave;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            saveFileDialog1.DefaultExt = "bmp";
            saveFileDialog1.Filter = "(*.bmp)|*.bmp|(*.jpeg)|*.jpeg|(*.png)|*.png|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                bmpSave.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
            Form1 form1 = new Form1();
            form1.ClearBack();
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ClearBack();
            this.Close();
        }

    }
}
