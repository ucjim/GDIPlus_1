﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace GDIPlus__1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen blackPen = new Pen(Color.Black,3);
            Point point1 = new Point(100,100);
            Point point2 = new Point(200, 200);

            g.DrawEllipse(blackPen, 10, 10, 200, 200);
            blackPen.Dispose();
            


        }
    }
}
