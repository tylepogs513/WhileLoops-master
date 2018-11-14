﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WhileLoops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void starButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);
            
            //initialize
            int counter = 1;
            int starSize = 20;
            int x = 50;
            int y = 20;

            //get input
            int numStars = Convert.ToInt16(starInput.Text);

            formGraphics.Clear(Color.Black);

            //test
            while (counter <= numStars)
            {
                //act
                formGraphics.FillEllipse(drawBrush, starSize * counter, x, y, starSize);

                //change
                counter++; // counter = counter + 1;
            }
        }

        private void moveButton_Click(object sender, EventArgs e)
        {          
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);

            //initialize
            int starSize = 10;
            int x = 0;
            int y = 0;
            
            //test
            while (y < this.Height - starSize && x < this.Width - starSize)	
            {
                //act
                formGraphics.Clear(Color.Black);
                formGraphics.FillRectangle(drawBrush, x, y, starSize, starSize);
                Thread.Sleep(5);
                
                //change
                y = y+2;
                x = x+2;
            }
        }

        private void growButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);

            //initialize
            int pixelGrow = 1;
            int x = 50;
            int y = 150;
            int starSize = 20;
                	    
            //test
            while (pixelGrow < 50)	
            {
                //act
                formGraphics.Clear(Color.Black);
                formGraphics.FillRectangle(drawBrush, x - pixelGrow/2, y - pixelGrow/2, starSize + pixelGrow, starSize + pixelGrow);
            
                Thread.Sleep(5);

                //change
                pixelGrow++;	
            }
        }

        private void fadeButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);

            //initialize
            int r = 255;
            int g = 0;
            int b = 0;
            int x = 50;
            int y = 150;
            int starSize = 50;

            //test
            while (b < 256)
            {
                //act
                drawBrush.Color = Color.FromArgb(r , g , b);

                formGraphics.Clear(Color.Black);
                formGraphics.FillRectangle(drawBrush, x, y, starSize, starSize);

                Thread.Sleep(10);

                //change
                b = b+5;
                r = r-5;
            }
        }
    }
}
