using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LineViewerLibrary;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Line line;
        public Form1()
        {
            line=new Line(20.5, 30.0, 40.0, 10.5);
            InitializeComponent();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Black, line.P1(), line.P2());
        }
    }
}
