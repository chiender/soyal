namespace RS232
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.baud_rate_Box = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_conn = new System.Windows.Forms.Button();
            this.txt_rs232_RX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_rs232_TX = new System.Windows.Forms.TextBox();
            this.btn_Polling = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_del_one = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Btn_string = new System.Windows.Forms.Button();
            this.btn_del_all = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_readid = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_auto = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceievd);
            // 
            // comBox
            // 
            this.comBox.FormattingEnabled = true;
            this.comBox.Location = new System.Drawing.Point(79, 34);
            this.comBox.Name = "comBox";
            this.comBox.Size = new System.Drawing.Size(121, 23);
            this.comBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Port";
            // 
            // baud_rate_Box
            // 
            this.baud_rate_Box.FormattingEnabled = true;
            this.baud_rate_Box.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.baud_rate_Box.Location = new System.Drawing.Point(320, 34);
            this.baud_rate_Box.Name = "baud_rate_Box";
            this.baud_rate_Box.Size = new System.Drawing.Size(121, 23);
            this.baud_rate_Box.TabIndex = 12;
            this.baud_rate_Box.Text = "9600";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(216, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Baud Rate";
            // 
            // btn_conn
            // 
            this.btn_conn.BackColor = System.Drawing.Color.Green;
            this.btn_conn.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_conn.Location = new System.Drawing.Point(482, 26);
            this.btn_conn.Name = "btn_conn";
            this.btn_conn.Size = new System.Drawing.Size(100, 40);
            this.btn_conn.TabIndex = 14;
            this.btn_conn.Text = "連線";
            this.btn_conn.UseVisualStyleBackColor = false;
            this.btn_conn.Click += new System.EventHandler(this.btn_conn_Click);
            // 
            // txt_rs232_RX
            // 
            this.txt_rs232_RX.Location = new System.Drawing.Point(26, 117);
            this.txt_rs232_RX.Multiline = true;
            this.txt_rs232_RX.Name = "txt_rs232_RX";
            this.txt_rs232_RX.Size = new System.Drawing.Size(592, 147);
            this.txt_rs232_RX.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(22, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "資料接收：";
            // 
            // txt_rs232_TX
            // 
            this.txt_rs232_TX.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_rs232_TX.Location = new System.Drawing.Point(26, 283);
            this.txt_rs232_TX.Name = "txt_rs232_TX";
            this.txt_rs232_TX.Size = new System.Drawing.Size(477, 29);
            this.txt_rs232_TX.TabIndex = 17;
            this.txt_rs232_TX.Text = "7E040125DB01";
            // 
            // btn_Polling
            // 
            this.btn_Polling.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Polling.Location = new System.Drawing.Point(28, 337);
            this.btn_Polling.Name = "btn_Polling";
            this.btn_Polling.Size = new System.Drawing.Size(161, 45);
            this.btn_Polling.TabIndex = 18;
            this.btn_Polling.Text = "Polling Message";
            this.btn_Polling.UseVisualStyleBackColor = true;
            this.btn_Polling.Click += new System.EventHandler(this.btn_Polling_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(423, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 25);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "0";
            // 
            // btn_del_one
            // 
            this.btn_del_one.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_del_one.Location = new System.Drawing.Point(207, 339);
            this.btn_del_one.Name = "btn_del_one";
            this.btn_del_one.Size = new System.Drawing.Size(195, 43);
            this.btn_del_one.TabIndex = 20;
            this.btn_del_one.Text = "Delete One Message";
            this.btn_del_one.UseVisualStyleBackColor = true;
            this.btn_del_one.Click += new System.EventHandler(this.btn_del_one_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(28, 414);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(590, 45);
            this.textBox2.TabIndex = 21;
            // 
            // Btn_string
            // 
            this.Btn_string.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_string.Location = new System.Drawing.Point(518, 273);
            this.Btn_string.Name = "Btn_string";
            this.Btn_string.Size = new System.Drawing.Size(100, 40);
            this.Btn_string.TabIndex = 22;
            this.Btn_string.Text = "字串傳送";
            this.Btn_string.UseVisualStyleBackColor = true;
            this.Btn_string.Click += new System.EventHandler(this.Btn_string_Click);
            // 
            // btn_del_all
            // 
            this.btn_del_all.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_del_all.Location = new System.Drawing.Point(423, 339);
            this.btn_del_all.Name = "btn_del_all";
            this.btn_del_all.Size = new System.Drawing.Size(195, 43);
            this.btn_del_all.TabIndex = 23;
            this.btn_del_all.Text = "Delete All Message";
            this.btn_del_all.UseVisualStyleBackColor = true;
            this.btn_del_all.Click += new System.EventHandler(this.btn_del_all_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_clear.Location = new System.Drawing.Point(132, 74);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 40);
            this.btn_clear.TabIndex = 24;
            this.btn_clear.Text = "清空";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(260, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "接收資料位元組";
            // 
            // btn_readid
            // 
            this.btn_readid.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_readid.Location = new System.Drawing.Point(26, 505);
            this.btn_readid.Name = "btn_readid";
            this.btn_readid.Size = new System.Drawing.Size(100, 40);
            this.btn_readid.TabIndex = 26;
            this.btn_readid.Text = "讀取ID";
            this.btn_readid.UseVisualStyleBackColor = true;
            this.btn_readid.Click += new System.EventHandler(this.btn_readid_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox3.Location = new System.Drawing.Point(218, 479);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 29);
            this.textBox3.TabIndex = 27;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox4.Location = new System.Drawing.Point(396, 479);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 29);
            this.textBox4.TabIndex = 28;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox5.Location = new System.Drawing.Point(292, 535);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(149, 29);
            this.textBox5.TabIndex = 29;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(146, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "組碼：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(324, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "卡號：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(134, 541);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "（組碼+卡號）：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "陣列資料 35 bytes";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(634, 117);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(100, 454);
            this.listBox1.TabIndex = 34;
            // 
            // btn_auto
            // 
            this.btn_auto.BackColor = System.Drawing.SystemColors.Control;
            this.btn_auto.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_auto.Location = new System.Drawing.Point(634, 24);
            this.btn_auto.Name = "btn_auto";
            this.btn_auto.Size = new System.Drawing.Size(100, 40);
            this.btn_auto.TabIndex = 35;
            this.btn_auto.Text = "自動開始";
            this.btn_auto.UseVisualStyleBackColor = false;
            this.btn_auto.Click += new System.EventHandler(this.btn_auto_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(461, 541);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 19);
            this.label9.TabIndex = 36;
            this.label9.Text = "節點：";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox6.Location = new System.Drawing.Point(533, 531);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(60, 29);
            this.textBox6.TabIndex = 37;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(753, 117);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(100, 454);
            this.listBox2.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(646, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 19);
            this.label10.TabIndex = 39;
            this.label10.Text = "節點1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(771, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 19);
            this.label11.TabIndex = 40;
            this.label11.Text = "節點2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 591);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_auto);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btn_readid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_del_all);
            this.Controls.Add(this.Btn_string);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_del_one);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Polling);
            this.Controls.Add(this.txt_rs232_TX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_rs232_RX);
            this.Controls.Add(this.btn_conn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.baud_rate_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SOYAL門禁系統";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox baud_rate_Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_conn;
        private System.Windows.Forms.TextBox txt_rs232_RX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_rs232_TX;
        private System.Windows.Forms.Button btn_Polling;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_del_one;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Btn_string;
        private System.Windows.Forms.Button btn_del_all;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_readid;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_auto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

