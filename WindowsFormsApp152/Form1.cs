﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp152
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Image i = Image.FromFile(@"G:\Users\mahan.jpg");
            TextureBrush tb = new TextureBrush(i);
            g.FillRectangle(tb, new Rectangle(new Point(0, 0), new Size(600, 600)));

        }
    }
}
