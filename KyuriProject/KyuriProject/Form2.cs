using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyuriProject
{
    public partial class Form2 : Form
    {

        public struct BackgroudManager
        {

            internal string displyState;

        }

        Form1 mainform; 
        public Form2(Form1 form)
        {
            InitializeComponent();
            mainform = form;

            this.button1.Text = "";
            this.button2.Text = "";
            this.button3.Text = "";
            this.button4.Text = "";
            this.button5.Text = "";

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.Manual;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("자가진단");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("투약설정");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("의학백과");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("병원찾기");
        }
    }
}
