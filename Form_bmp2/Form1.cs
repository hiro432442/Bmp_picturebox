using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Form_bmp2
{
    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //画像のみ表示
                //openFileDialog1.Filter = "画像ファイル|*.bmp;*.jpg;*.png;*.gif";
                //ファイル選択ダイアログボックス表示
                var ret = openFileDialog1.ShowDialog();
                
                if (ret == DialogResult.OK)
                {
                    //bitmap読み込み＞メモリ解放含む
                    using(var bmp = new Bitmap(openFileDialog1.FileName))
                        
                    //コントロールのグラフィッククラス作成＞メモリ解放含む
                    using (var grh = pictureBox2.CreateGraphics())
                    {
                        //bitmap情報表示
                        label1.Text = "X:" + bmp.Width + "Y:" + bmp.Height + " / " + bmp.PixelFormat;
                        //bitmap表示
                        //grh.DrawImage(bmp, 0, 0, pictureBox2.Width, pictureBox2.Height);
                        pictureBox2.ImageLocation = openFileDialog1.FileName;
                    }

                }
            }
            catch (Exception er)
            {

                Console.WriteLine(er.Message.ToString());
            }
            finally
            {

            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox2.Width = 100;
            pictureBox2.Height = 150;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Maximum = 1000;
            label2.Text = trackBar1.Value.ToString();
            pictureBox2.Width = trackBar1.Value;
            pictureBox2.Height = trackBar1.Value;
        }
    }
}

