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
    public partial class Form2 : Form
    {
        private string receiveData = "";
        Itemform fs;
        public Form2()
        {
            InitializeComponent();
            fs = new Itemform();
            fs.Owner = this;

        }


        public string ReceiveData
        {
            set
            {
                receiveData = value;
                label1.Text = receiveData;
            }
            get
            {
                return receiveData;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Itemform itemform = new Itemform();
            DialogResult drRet = itemform.ShowDialog();


            if (drRet == DialogResult.OK)
            {
                //money.ttestTable.AddttestTableRow(
                ///MoneyDataSet.moenyDataTable.
                //MoneyDataSet.moeny.AddDataTable1Row(
                //   itemform.TextBox2.Text
                //);
                label2.Text = "koko";
                //label1.Text = itemform.textBox2.Text;
                //label1.Text = this.textBox2.Text;
                //label1.Text = fs.textBox2.Text;
                //label1.Text = "tttt";






            }
        }
    }
}
