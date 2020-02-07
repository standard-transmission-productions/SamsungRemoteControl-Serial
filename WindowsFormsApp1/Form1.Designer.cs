namespace WindowsFormsApp1
{
    partial class Form1
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
            this.connect = new System.Windows.Forms.Button();
            this.off = new System.Windows.Forms.Button();
            this.hdmi1 = new System.Windows.Forms.Button();
            this.hdmi2 = new System.Windows.Forms.Button();
            this.hdmi3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.page2 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.page1 = new System.Windows.Forms.Panel();
            this.connectbtn = new System.Windows.Forms.Button();
            this.inputRate = new System.Windows.Forms.TextBox();
            this.baudRate = new System.Windows.Forms.Label();
            this.comPortList = new System.Windows.Forms.ComboBox();
            this.port = new System.Windows.Forms.Label();
            this.page2.SuspendLayout();
            this.page1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(39, 93);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(92, 71);
            this.connect.TabIndex = 0;
            this.connect.Text = "On";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // off
            // 
            this.off.Location = new System.Drawing.Point(156, 93);
            this.off.Name = "off";
            this.off.Size = new System.Drawing.Size(87, 71);
            this.off.TabIndex = 1;
            this.off.Text = "Off";
            this.off.UseVisualStyleBackColor = true;
            this.off.Click += new System.EventHandler(this.off_Click);
            // 
            // hdmi1
            // 
            this.hdmi1.Location = new System.Drawing.Point(39, 206);
            this.hdmi1.Name = "hdmi1";
            this.hdmi1.Size = new System.Drawing.Size(92, 38);
            this.hdmi1.TabIndex = 2;
            this.hdmi1.Text = "HDMI1";
            this.hdmi1.UseVisualStyleBackColor = true;
            this.hdmi1.Click += new System.EventHandler(this.hdmi1_Click);
            // 
            // hdmi2
            // 
            this.hdmi2.Location = new System.Drawing.Point(156, 206);
            this.hdmi2.Name = "hdmi2";
            this.hdmi2.Size = new System.Drawing.Size(92, 38);
            this.hdmi2.TabIndex = 3;
            this.hdmi2.Text = "HDMI2";
            this.hdmi2.UseVisualStyleBackColor = true;
            this.hdmi2.Click += new System.EventHandler(this.hdmi2_Click);
            // 
            // hdmi3
            // 
            this.hdmi3.Location = new System.Drawing.Point(270, 206);
            this.hdmi3.Name = "hdmi3";
            this.hdmi3.Size = new System.Drawing.Size(92, 38);
            this.hdmi3.TabIndex = 4;
            this.hdmi3.Text = "HDMI3";
            this.hdmi3.UseVisualStyleBackColor = true;
            this.hdmi3.Click += new System.EventHandler(this.hdmi3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // page2
            // 
            this.page2.Controls.Add(this.back);
            this.page2.Controls.Add(this.off);
            this.page2.Controls.Add(this.label1);
            this.page2.Controls.Add(this.connect);
            this.page2.Controls.Add(this.textBox1);
            this.page2.Controls.Add(this.hdmi1);
            this.page2.Controls.Add(this.hdmi3);
            this.page2.Controls.Add(this.hdmi2);
            this.page2.Location = new System.Drawing.Point(119, 66);
            this.page2.Name = "page2";
            this.page2.Size = new System.Drawing.Size(589, 329);
            this.page2.TabIndex = 7;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(39, 284);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 31);
            this.back.TabIndex = 7;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // page1
            // 
            this.page1.Controls.Add(this.connectbtn);
            this.page1.Controls.Add(this.inputRate);
            this.page1.Controls.Add(this.baudRate);
            this.page1.Controls.Add(this.comPortList);
            this.page1.Controls.Add(this.port);
            this.page1.Location = new System.Drawing.Point(119, 66);
            this.page1.Name = "page1";
            this.page1.Size = new System.Drawing.Size(586, 329);
            this.page1.TabIndex = 8;
            // 
            // connectbtn
            // 
            this.connectbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectbtn.Location = new System.Drawing.Point(90, 213);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(112, 39);
            this.connectbtn.TabIndex = 4;
            this.connectbtn.Text = "Connect";
            this.connectbtn.UseVisualStyleBackColor = true;
            this.connectbtn.Click += new System.EventHandler(this.connectbtn_Click);
            // 
            // inputRate
            // 
            this.inputRate.Location = new System.Drawing.Point(217, 144);
            this.inputRate.Name = "inputRate";
            this.inputRate.Size = new System.Drawing.Size(100, 22);
            this.inputRate.TabIndex = 3;
            // 
            // baudRate
            // 
            this.baudRate.AutoSize = true;
            this.baudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudRate.Location = new System.Drawing.Point(86, 144);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(93, 20);
            this.baudRate.TabIndex = 2;
            this.baudRate.Text = "BaudRate: ";
            // 
            // comPortList
            // 
            this.comPortList.FormattingEnabled = true;
            this.comPortList.Location = new System.Drawing.Point(217, 83);
            this.comPortList.Name = "comPortList";
            this.comPortList.Size = new System.Drawing.Size(121, 24);
            this.comPortList.TabIndex = 1;
            // 
            // port
            // 
            this.port.AutoSize = true;
            this.port.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port.Location = new System.Drawing.Point(86, 83);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(45, 20);
            this.port.TabIndex = 0;
            this.port.Text = "Port:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.page1);
            this.Controls.Add(this.page2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.page2.ResumeLayout(false);
            this.page2.PerformLayout();
            this.page1.ResumeLayout(false);
            this.page1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button off;
        private System.Windows.Forms.Button hdmi1;
        private System.Windows.Forms.Button hdmi2;
        private System.Windows.Forms.Button hdmi3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel page2;
        private System.Windows.Forms.Panel page1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label baudRate;
        private System.Windows.Forms.ComboBox comPortList;
        private System.Windows.Forms.Label port;
        private System.Windows.Forms.TextBox inputRate;
        private System.Windows.Forms.Button connectbtn;
    }
}

