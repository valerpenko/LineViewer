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
        private List<Line> lines;
        public Form1()
        {
            lines = new List<Line>();
            lines.Add(new Line(20.5, 30.0, 40.0, 10.5));
            InitializeComponent();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0;i<lines.Count;i++)
            e.Graphics.DrawLine(Pens.Black, lines[i].P1(), lines[i].P2());
           //foreach(Line x in lines)
            //e.Graphics.DrawLine(Pens.Black, x.P1(), x.P2());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1 - add new line
            Random rnd = new Random();
            lines.Add(new Line(rnd.NextDouble()*100.0, rnd.NextDouble() * 100.0, rnd.NextDouble() * 100.0, rnd.NextDouble() * 100.0));
            //2 - draw this line (old lines are drawn)
            this.Refresh();
        }

    }
}

