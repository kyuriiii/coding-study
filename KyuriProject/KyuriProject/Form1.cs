using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;


namespace KyuriProject

{
    public struct BackgroudManager
    {
        internal string name;
        internal string description;
        internal string displyState;
        internal int Number;
        internal Bitmap image;
    }

    public partial class Form1 : Form
    {
        BackgroudManager backgroundmanage;

        public Form1()
        {
            this.BackgroundImage = RotateImage(Properties.Resources.P01_00);
            backgroundmanage.displyState = "P01";

            InitializeComponent();

            this.button1.Text = "";
            this.button2.Text = "";
            this.button3.Text = "";
            this.button4.Text = "";
            this.button5.Text = "";
            this.button6.Text = "";
            this.button7.Text = "";
            this.button8.Text = "";
            this.button9.Text = "";
            this.button10.Text = "";
            this.button11.Text = "";

            this.Text = string.Empty; // No caption
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }


        public Image RotateImage(Image img)
        {
            var bmp = new Bitmap(img);

            using (Graphics gfx = Graphics.FromImage(bmp))
            {

                gfx.Clear(Color.White);//이미지를 제외한 나머지 배경 색깔을 하얀색으로 지정한다.
                gfx.DrawImage(img, 0, 0);//이미지가 x좌표 0, y좌표 0 을 시작점으로 그려진다.
                //gfx.DrawImage(img, 0, 0, srcRect, units);
                //gfx.DrawImageUnscaledAndClipped(img, rect);
            }

            //bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            //bmp.RotateFlip(RotateFlipType.Rotate270FlipNone);
            return bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("메시지");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("카메라");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("갤러리");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("실내정보");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("긴급연락");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("화면이 종료됩니다.");
            Application.Exit();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("건강검진");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("즐길거리");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("None");
        }
        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("설정");
        }
        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("돌아가기");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //    if(this.BackgroundImage.ToString() == RotateImage(Properties.Resources.P01_00).GetHashCode())
            if (backgroundmanage.displyState == "P01")
            {
                this.BackgroundImage = RotateImage(Properties.Resources.P02_00); //경고창
                backgroundmanage.displyState = "P02";
            }
            else if (backgroundmanage.displyState == "P02")
            {
                this.BackgroundImage = RotateImage(Properties.Resources.P01_00); //경고창
                backgroundmanage.displyState = "P01";
            }
            //    if (this.BackgroundImage == RotateImage(Properties.Resources.P03_00))
            //        this.BackgroundImage = RotateImage(Properties.Resources.P01_00); //경고창
        }

    }
}
