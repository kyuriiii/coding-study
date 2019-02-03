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
   
    public partial class Form1 : Form
    {
        

        public Form1()
        {
           
            InitializeComponent();


            this.button1.Text = "";
            this.button6.Text = "";

            this.BackColor = Color.FromArgb(255, 232, 232);
            this.Text = string.Empty; 
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            MessageBox.Show("화면이 종료됩니다.");
            Application.Exit();
        }


    }
}
