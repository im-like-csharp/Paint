namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eraserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primitivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.clearBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.primitivesToolStripMenuItem,
            this.brushToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.eraserToolStripMenuItem,
            this.clearBackgroundToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // eraserToolStripMenuItem
            // 
            this.eraserToolStripMenuItem.Name = "eraserToolStripMenuItem";
            this.eraserToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.eraserToolStripMenuItem.Text = "Eraser";
            this.eraserToolStripMenuItem.Click += new System.EventHandler(this.eraserToolStripMenuItem_Click);
            // 
            // primitivesToolStripMenuItem
            // 
            this.primitivesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineToolStripMenuItem,
            this.rectangleToolStripMenuItem,
            this.ellipsToolStripMenuItem});
            this.primitivesToolStripMenuItem.Name = "primitivesToolStripMenuItem";
            this.primitivesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.primitivesToolStripMenuItem.Text = "Primitives";
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.lineToolStripMenuItem.Text = "Line";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // ellipsToolStripMenuItem
            // 
            this.ellipsToolStripMenuItem.Name = "ellipsToolStripMenuItem";
            this.ellipsToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ellipsToolStripMenuItem.Text = "Ellipse";
            this.ellipsToolStripMenuItem.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // brushToolStripMenuItem
            // 
            this.brushToolStripMenuItem.Name = "brushToolStripMenuItem";
            this.brushToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.brushToolStripMenuItem.Text = "Brush";
            this.brushToolStripMenuItem.Click += new System.EventHandler(this.brushToolStripMenuItem_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(722, 0);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(130, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(858, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(860, 435);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // clearBackgroundToolStripMenuItem
            // 
            this.clearBackgroundToolStripMenuItem.Name = "clearBackgroundToolStripMenuItem";
            this.clearBackgroundToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.clearBackgroundToolStripMenuItem.Text = "Clear Background";
            this.clearBackgroundToolStripMenuItem.Click += new System.EventHandler(this.clearBackgroundToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 483);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eraserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primitivesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearBackgroundToolStripMenuItem;
    }
}

