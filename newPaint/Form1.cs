using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newPaint
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Boolean cursorMoving = false;
        Pen cursorPen;
        int cursorX = -1;
        int cursorY = -1;
        float size = 10;
        

        public Form1()
        {
            InitializeComponent();            
            graphics = canvas.CreateGraphics();
            cursorPen = new Pen(Color.Black, size);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            cursorPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            cursorPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;          

        }

        

        private void blackBox_Click(object sender, EventArgs e)
        {
            PictureBox color = (PictureBox)sender;
            cursorPen.Color = color.BackColor;

        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            cursorMoving = true;
            cursorX = e.X;
            cursorY = e.Y;
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            cursorMoving = false;
            cursorX = -1;
            cursorY = -1;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (cursorX != -1 && cursorY != -1 && cursorMoving == true)
            {
                graphics.DrawLine(cursorPen, new Point(cursorX, cursorY), e.Location);
                cursorX = e.X;
                cursorY = e.Y;
            }
        }

        private void eraseAll_Click(object sender, EventArgs e)
        {
            graphics.Clear(color: Color.White);
        }

        private void brushIco_Click(object sender, EventArgs e)
        {
            PictureBox color = (PictureBox)sender;
            cursorPen.Color = canvas.BackColor;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            size = (float)numericUpDown1.Value;
            cursorPen.Width = size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = selectedColor.BackColor;


            if (MyDialog.ShowDialog() == DialogResult.OK)
            {                
                selectedColor.BackColor = MyDialog.Color;
                cursorPen.Color = MyDialog.Color;
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
