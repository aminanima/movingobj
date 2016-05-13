using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movingobj
{
    public partial class Form1 : Form
    {
        Graphics g;
        SolidBrush brush;
        float x = 60;
        float y = 60;
        float w = 60;
        float h = 50;
        float dx = 10;


        public Form1()
        {
            InitializeComponent();
            brush = new SolidBrush(Color.LightPink);
            Timer t = new Timer();
            t.Tick += new EventHandler(Move);
            t.Start();
        }

        private new void Move(object sender, EventArgs e)
        {
            if ((x + w) > 285)
            {
                dx = -10;
                brush = new SolidBrush(Color.LightSkyBlue);

            }
            if (x < 20)
            {
                dx = 10;
                brush = new SolidBrush(Color.Gray);
            }
            x += dx;
            Refresh();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawRectangle(new Pen(Color.BlueViolet), 10, 10, 300, 300);
            //g.FillRectangle(brush, x, y, w+20, h+10);
            // g.FillEllipse(new SolidBrush(Color.RosyBrown), x, y +h, w - 35, h - 15);
            //g.FillEllipse(new SolidBrush(Color.RosyBrown), x+(w-5), y + h, w - 35, h - 15);
            //g.FillRectangle(new SolidBrush(Color.White), x + 5, y + 5, w-30, h-15);
            //g.FillRectangle(new SolidBrush(Color.White), x +40, y + 5, w-30, h - 15);
            g.FillEllipse(brush, x, y, w + 20, h + 10);

        }

       
    }
}
