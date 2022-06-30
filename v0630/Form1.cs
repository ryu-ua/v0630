using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0630
{
    public partial class Form1 : Form
    {
        int vx = rand.Next(-10,11);
        int vy = rand.Next(-10,11);

        int sx = rand.Next(-10, 11);
        int sy = rand.Next(-10, 11);

        int cx = rand.Next(-10, 11);
        int cy = rand.Next(-10, 11);
        //静的＝最初に決めておく　<>　動的＝実行時に変更可能
        static Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            label1.Left = rand.Next(ClientSize.Width-label1.Width);
            label1.Top = rand.Next(ClientSize.Height-label1.Height);

            label3.Left = rand.Next(ClientSize.Width - label3.Width);
            label3.Top = rand.Next(ClientSize.Height - label3.Height);

            label4.Left = rand.Next(ClientSize.Width - label4.Width);
            label4.Top = rand.Next(ClientSize.Height - label4.Height);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point spos = MousePosition;
            Point fpos = PointToClient(spos);
            label2.Left = fpos.X - label2.Width / 2;
            label2.Top = fpos.Y - label2.Height / 2;


            label1.Left += vx;
            label1.Top += vy;
          

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx) * 110 / 100;
            }

            if (label1.Top < 0)
            {
                vy = Math.Abs(vy) * 110 / 100;
            }


            if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx) * 110 / 100;
            }

            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy) * 110 / 100;
            }
            
            if ((fpos.X >= label1.Left)
           && (fpos.X < label1.Right)
           && (fpos.Y >= label1.Top)
           && (fpos.Y < label1.Bottom))
            {
                timer1.Enabled = false;
            }
            
            label3.Left += sx;
            label3.Top += sy;
            if (label3.Left < 0)
            {
                sx = Math.Abs(sx) * 110 / 100;
            }

            if (label3.Top < 0)
            {
                sy = Math.Abs(sy) * 110 / 100;
            }


            if (label3.Right > ClientSize.Width)
            {
                sx = -Math.Abs(sx) * 110 / 100;
            }

            if (label3.Bottom > ClientSize.Height)
            {
                sy = -Math.Abs(sy) * 110 / 100;
            }

            if ((fpos.X >= label3.Left)
           && (fpos.X < label3.Right)
           && (fpos.Y >= label3.Top)
           && (fpos.Y < label3.Bottom))
            {
                timer1.Enabled = false;
            }


            label4.Left += cx;
            label4.Top += cy;
            if (label4.Left < 0)
            {
                cx = Math.Abs(cx) * 110 / 100;
            }

            if (label4.Top < 0)
            {
                cy = Math.Abs(cy) * 110 / 100;
            }


            if (label4.Right > ClientSize.Width)
            {
                cx = -Math.Abs(cx) * 110 / 100;
            }

            if (label4.Bottom > ClientSize.Height)
            {
                cy = -Math.Abs(cy) * 110 / 100;
            }

            if ((fpos.X >= label4.Left)
             && (fpos.X < label4.Right)
             && (fpos.Y >= label4.Top)
             && (fpos.Y < label4.Bottom))
            {
                timer1.Enabled = false;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}
