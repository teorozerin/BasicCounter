using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCounter
{
    public partial class Counter : Form
    {
        int second = 0;
        public Counter()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            lblSecond.Text = second.ToString();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (second > 0)
            {
                btnStart.Text = "Continue";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(second > 0)
            {
                second = 0;
                lblSecond.Text =second.ToString();
                btnStart.Text = "Start";
            }
        }
    }
}
