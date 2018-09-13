using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace customButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // make a star out of button1
            System.Drawing.Point[] p = new System.Drawing.Point[8];
            /*
            p[0] = new Point(0, 25);
            p[1] = new Point(20, 20);
            p[2] = new Point(25, 0);
            p[3] = new Point(30, 20);
            p[4] = new Point(50, 25);
            p[5] = new Point(30, 30);
            p[6] = new Point(25, 50);
            p[7] = new Point(20, 30);
      
            p[0] = new Point(0, 50);
            p[1] = new Point(40, 40);
            p[2] = new Point(50, 0);
            p[3] = new Point(60, 40);
            p[4] = new Point(100, 50);
            p[5] = new Point(60, 60);
            p[6] = new Point(50, 100);
            p[7] = new Point(40, 60);
                   */
            // triangle
            System.Drawing.Point[] t = new System.Drawing.Point[4];

            t[0] = new Point(1, 50);
            t[1] = new Point(50, 1);
            t[2] = new Point(100, 50); // triangle
            t[3] = new Point(50, 100); // diamond
            //t[4] = new Point(100, 50);

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddPolygon(t);
            System.Drawing.Region r = new System.Drawing.Region(gp);
            button1.Region = r;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkCyan;
        }
    }
}
