using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Quobject.SocketIoClientDotNet.Client;

using System.Collections;


namespace KyuriProject

{
    public delegate void UpdateTextBoxMethod(string text);
    public struct BackgroudManager
    {
        internal string displyState;
    }

    public partial class Form1 : Form
    {
        BackgroudManager backgroundmanage;
        Form2 healthForm;
        Form3 settingForm;
        //Kyuri myform;

        public Socket sock = null;

        public Form1()
        {
            this.BackgroundImage = RotateImage(Properties.Resources.P01_00);
            backgroundmanage.displyState = "P01";
            /*this.BackgroundImageLayout = ImageLayout.Stretch;*/


            InitializeComponent();

            this.button1.Text = "";
            this.button2.Text = "";
            this.button3.Text = "";
            this.button4.Text = "";

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


            healthForm = new Form2(this); //form2 준비
            settingForm = new Form3(this);
            // myform = new Kyuri();//사용금지
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

            //myform.ShowDialog();//사용금지
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

        private void button6_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            healthForm.ShowDialog();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("즐길거리");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("긴급연락");
        }
        private void button10_Click(object sender, EventArgs e)
        {
            settingForm.ShowDialog();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            socketIoManager();
        }

        public void socketIoManager()
        {
            string url = "http://" + txtURL.Text;
            sock = IO.Socket(url);

            UpdateStatus("Connecting...");
            sock.On(Socket.EVENT_CONNECT, () =>
            {
                Console.WriteLine("connected");
                UpdateStatus("connected");
            });

            sock.On(Socket.EVENT_CONNECT_ERROR, () =>
            {
                UpdateStatus("not connection");
            });

            sock.On(Socket.EVENT_DISCONNECT, () =>
            {
                UpdateStatus("disconnection");
            }
            );

            sock.On("sensor_01", (data) =>
            {
                var temperature = new { temperature = "", humidity = "" };
                var tempValue = JsonConvert.DeserializeAnonymousType((string)data, temperature);
                UpdateSensor((string)tempValue.temperature + ", " + (string)tempValue.humidity);
            });
        }

        private void UpdateStatus(string text)
        {
            if (this.textBox1.InvokeRequired)
            {
                UpdateTextBoxMethod del = new UpdateTextBoxMethod(UpdateStatus);
                this.Invoke(del, new object[] { text });
            }
            else
            {
                this.textBox1.Text = text;
            }
        }

        private void UpdateSensor(string text)
        {
            if (this.textBox2.InvokeRequired)
            {
                UpdateTextBoxMethod del = new UpdateTextBoxMethod(UpdateStatus);
                this.Invoke(del, new object[] { text });
            }
            else
            {
                this.textBox2.Text = text;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sock.Disconnect();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sock.Emit("test", "send-test'" + txtMsg.Text);
        }

        
    }


}
