using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pacman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[,] harta = 
        {
        {1,1,1,1,1,1,1,1},
        {1,0,0,0,1,0,0,1},
        {1,1,1,0,1,0,0,1},
        {1,0,0,0,1,0,0,1},
        {1,1,1,0,0,0,1,1},
        {1,0,0,0,1,0,0,1},
        {1,0,0,0,1,0,0,1},
        {1,1,1,1,1,1,1,1},
        };

        int i = 1;
        int j = 1;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (harta[ j-1,i] != 1)
            {
                nava.Top -= 20;
                j--;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (harta[ j+1,i] != 1)
            {
                nava.Top += 20;
                j++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (harta[j,i-1] != 1)
            {
                nava.Left -= 20;
                i--;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (harta[j,i+1] != 1)
            {
                nava.Left += 20;
                i++;
            }
        }
    }
}
