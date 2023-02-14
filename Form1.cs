using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingBall
{
    public partial class Form1 : Form
    {
       
        private int ballWidth = 100;
        private int ballHeight = 100;
        private int ballPosX = 0;
        private int ballPosY = 0;

        private int ballWidth1 = 200;
        private int ballHeight1 = 200;
        private int ballPosX1 = 0;
        private int ballPosY1 = 0;

        private int moveStepX = 4;
        private int moveStepY = 4;
        private int moveStepX1 = 1;
        private int moveStepY1= 1;

        public Form1()
        {
            InitializeComponent();

            this.SetStyle(
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint,
                true
                );

            this.UpdateStyles();
        }

        private void PaintCircle(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = 
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;


          
            e.Graphics.FillEllipse(Brushes.Blue,
                ballPosX, ballPosY,
                ballWidth, ballHeight);

            e.Graphics.DrawEllipse(Pens.Black,
                ballPosX1, ballPosY1,
                ballWidth1, ballHeight1);
            e.Graphics.FillEllipse(Brushes.Red,
              ballPosX1, ballPosY1,
              ballWidth1, ballHeight1);

            e.Graphics.DrawEllipse(Pens.Black,
                ballPosX, ballPosY,
                ballWidth, ballHeight);
        }

        private void MoveBall(object sender, EventArgs e)
        {
            
            ballPosX += moveStepX;
            ballPosX1 += moveStepX1;
            if (
                ballPosX < 0  ||
                ballPosX + ballWidth > this.ClientSize.Width
               )
              



            {
                moveStepX = -moveStepX;
            }

            ballPosY += moveStepY;
            if (
                ballPosY < 0 ||
                ballPosY + ballHeight > this.ClientSize.Height
                )
            {
                moveStepY = -moveStepY;
            }

           
            this.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
