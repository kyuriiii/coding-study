using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Quobject.SocketIoClientDotNet.Client;

namespace KyuriProject
{
   
    public partial class Form4 : Form
    {
       

        public Socket sock = null;

        public delegate void UpdateTextBoxMethod(string text);
        public struct BackgroudManager
        {
            //internal string displyState;
        }

        Form2 mainform;
        public Form4(Form2 form)
        {
            InitializeComponent();
            mainform = form;

            this.button1.Text = "";
            this.button2.Text = "연결하기";
            this.button3.Text = "전송";

            this.Text = string.Empty; // No caption
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
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
                //UpdateSensor((string)tempValue.temperature + ", " + (string)tempValue.humidity);
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

        private void button3_Click(object sender, EventArgs e)
        {
            /* sock.Emit("test", "이름 :" + txtMsg1);
             sock.Emit("test", "나이 :" + txtMsg2);
             sock.Emit("test", "성별 :" + txtMsg3);
             sock.Emit("test", "증상 :" + txtMsg4);
             sock.Emit("test", "예상병명 :" + txtMsg5);
             sock.Emit("test", "과거병력 :" + txtMsg6);

             sock.Emit("test", "'{ a: '" + txtMsg1, "'b: '" + txtMsg2, "'c: '" + txtMsg3, "'d: '" + txtMsg4, "'e: '" + txtMsg5, "'f: '" + txtMsg6 + "}");
                 //"test", "이름 : " + txtMsg1.Text, "나이 : " + txtMsg2.Text, "성별 : " + txtMsg3.Text, "증상 : " + txtMsg4.Text, "예상병명 : " + txtMsg5.Text, "과거병력 : " + txtMsg6.Text);
                 //"test", "이름 : " + txtMsg1.Text + " 나이 : " + txtMsg2.Text + " 성별 : " + txtMsg3.Text + " 증상 : " + txtMsg4.Text + " 예상병명 : " + txtMsg5.Text + " 과거병력 : " + txtMsg6.Text);
                 //{ "이름 : " + txtMsg1.Text, "나이 : " + txtMsg2.Text, "성별 : " + txtMsg3.Text, "증상 : " + txtMsg4.Text, "예상병명 : " + txtMsg5.Text, "과거병력 : " + txtMsg6.Text});*/

            string name = txtMsg1.Text;
            string age = txtMsg2.Text;

            var json = new JObject();
            json.Add("a", name);
            json.Add("b", age);

            sock.Emit("test", json);


       }
    }
}
