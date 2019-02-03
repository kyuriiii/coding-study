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

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.Manual;
        }

        
    }
}
