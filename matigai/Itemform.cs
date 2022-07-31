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
    public partial class Itemform : Form
    {
        private string sendData = "";
        public Itemform()
        {
            InitializeComponent();
        }

        

        public string SendData
        {
            set
            {
                sendData = value;
                label1.Text = sendData;
            }
            get
            {
                return sendData;
            }
        }

        public object TextBox2 { get; internal set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm = (Form2)this.Owner;
            if (fm != null)
            {
                fm.ReceiveData = "Duck";
            }
        }
    }

}
