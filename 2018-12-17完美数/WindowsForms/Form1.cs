using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output = "";
            int i, j, s;
            for(i=1; i<=10000; i++)
            {
                s = 0;
                for (j = 1; j < i; j++)
                    if (i % j == 0) s = s + j;
                if (i == s) output = output + " " + i;

            }
            label1.Text = output;
        }
    }
}
