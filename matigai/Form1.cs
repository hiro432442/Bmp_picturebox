using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matigai
{
    public partial class Form1 : Form
    {
        string correctText = "萩";
        string mistakeText = "荻";
        double nowTime;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            if(((Button)sender).Text == correctText){
                timer1.Stop();
            }
            else
            {
                nowTime = nowTime + 10;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textHunt.Text = correctText;
            Random rnd = new System.Random();
            int randomResult = rnd.Next(25);

            for(int i = 0; i < splitContainer1.Panel2.Controls.Count; i++)
            {
                splitContainer1.Panel2.Controls[i].Text = mistakeText;
            }
            splitContainer1.Panel2.Controls[randomResult].Text = correctText;

            nowTime = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nowTime = nowTime + 0.02;
            textBox1.Text = nowTime.ToString("0.00");

        }
    }
}
