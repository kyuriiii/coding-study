namespace KyuriProject
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Clock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtURL = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMsg1 = new System.Windows.Forms.TextBox();
            this.txtMsg2 = new System.Windows.Forms.TextBox();
            this.txtMsg3 = new System.Windows.Forms.TextBox();
            this.txtMsg4 = new System.Windows.Forms.TextBox();
            this.txtMsg5 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtMsg6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("한컴 바겐세일 B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.label1.Size = new System.Drawing.Size(535, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "자가 진단";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Image = global::KyuriProject.Properties.Resources.health_back;
            this.button1.Location = new System.Drawing.Point(451, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clock
            // 
            this.Clock.AutoSize = true;
            this.Clock.Font = new System.Drawing.Font("한컴 백제 B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Clock.Location = new System.Drawing.Point(240, 650);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(275, 32);
            this.Clock.TabIndex = 11;
            this.Clock.Text = "2019-02-07 03:24:03";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtURL
            // 
            this.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtURL.ForeColor = System.Drawing.Color.White;
            this.txtURL.Location = new System.Drawing.Point(15, 61);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(100, 14);
            this.txtURL.TabIndex = 12;
            this.txtURL.Text = "192.168.0.103:3000";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 21);
            this.textBox1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 45);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMsg1
            // 
            this.txtMsg1.Font = new System.Drawing.Font("한컴 바겐세일 B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMsg1.Location = new System.Drawing.Point(154, 324);
            this.txtMsg1.Name = "txtMsg1";
            this.txtMsg1.Size = new System.Drawing.Size(231, 28);
            this.txtMsg1.TabIndex = 15;
            // 
            // txtMsg2
            // 
            this.txtMsg2.Font = new System.Drawing.Font("한컴 바겐세일 B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMsg2.Location = new System.Drawing.Point(154, 367);
            this.txtMsg2.Name = "txtMsg2";
            this.txtMsg2.Size = new System.Drawing.Size(231, 28);
            this.txtMsg2.TabIndex = 16;
            // 
            // txtMsg3
            // 
            this.txtMsg3.Font = new System.Drawing.Font("한컴 바겐세일 B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMsg3.Location = new System.Drawing.Point(154, 410);
            this.txtMsg3.Name = "txtMsg3";
            this.txtMsg3.Size = new System.Drawing.Size(231, 28);
            this.txtMsg3.TabIndex = 17;
            // 
            // txtMsg4
            // 
            this.txtMsg4.Font = new System.Drawing.Font("한컴 바겐세일 B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMsg4.Location = new System.Drawing.Point(154, 450);
            this.txtMsg4.Name = "txtMsg4";
            this.txtMsg4.Size = new System.Drawing.Size(231, 28);
            this.txtMsg4.TabIndex = 18;
            // 
            // txtMsg5
            // 
            this.txtMsg5.Font = new System.Drawing.Font("한컴 바겐세일 B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMsg5.Location = new System.Drawing.Point(154, 496);
            this.txtMsg5.Name = "txtMsg5";
            this.txtMsg5.Size = new System.Drawing.Size(231, 28);
            this.txtMsg5.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(423, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 162);
            this.button3.TabIndex = 20;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtMsg6
            // 
            this.txtMsg6.Font = new System.Drawing.Font("한컴 바겐세일 B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMsg6.Location = new System.Drawing.Point(154, 540);
            this.txtMsg6.Name = "txtMsg6";
            this.txtMsg6.Size = new System.Drawing.Size(231, 28);
            this.txtMsg6.TabIndex = 21;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(559, 701);
            this.Controls.Add(this.txtMsg6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtMsg5);
            this.Controls.Add(this.txtMsg4);
            this.Controls.Add(this.txtMsg3);
            this.Controls.Add(this.txtMsg2);
            this.Controls.Add(this.txtMsg1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Clock);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtURL);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtMsg1;
        private System.Windows.Forms.TextBox txtMsg2;
        private System.Windows.Forms.TextBox txtMsg3;
        private System.Windows.Forms.TextBox txtMsg4;
        private System.Windows.Forms.TextBox txtMsg5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtMsg6;
    }
}