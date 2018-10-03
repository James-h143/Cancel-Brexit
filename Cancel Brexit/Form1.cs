using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cancel_Brexit
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Cancel_Brexit_Click(object sender, EventArgs e)
        {
            string[] replies = new[] {"No, The People have spoken!", "No, Brexit Means Brexit!", "No, No deal is better than a bad deal!" };
            Reply.Text = replies[i];
            i++;
            if (i > 2) {
                i = 0;
            }

        }
    }
}
