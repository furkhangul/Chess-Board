using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess_Board
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int buttonsize = 50;
            int top = 0;
            int left = 0;
            Button[,] buttons = new Button[8, 8];
            for(int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for(int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = buttonsize;
                    buttons[i, j].Height = buttonsize;
                    buttons[i, j].Top = top;
                    buttons[i, j].Left = left;
                    left = left + buttonsize;
                    this.Controls.Add(buttons[i, j]);
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.Black;

                    }
                }
                left = 0;
                top = top + buttonsize;
            }
            
        }
    }
}
