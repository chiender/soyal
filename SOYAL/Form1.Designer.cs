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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.baud_rate_Box = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_conn = new System.Windows.Forms.Button();
            this.btn_auto = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_712deln2 = new System.Windows.Forms.Button();
            this.btn_712readn2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btn_712del = new System.Windows.Forms.Button();
            this.btn_712read = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_readid = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_del_all = new System.Windows.Forms.Button();
            this.Btn_string = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_del_one = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Polling = new System.Windows.Forms.Button();
            this.txt_rs232_TX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_rs232_RX = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbox_fm = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_rfid = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_company = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_delallPDB = new System.Windows.Forms.Button();
            this.btn_showAllDB = new System.Windows.Forms.Button();
            this.btn_searchDB = new System.Windows.Forms.Button();
            this.btn_delDB = new System.Windows.Forms.Button();
            this.btn_addDB = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceievd);
            // 
            // comBox
            // 
            this.comBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comBox.FormattingEnabled = true;
            this.comBox.Location = new System.Drawing.Point(83, 21);
            this.comBox.Name = "comBox";
            this.comBox.Size = new System.Drawing.Size(121, 28);
            this.comBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "連接埠";
            // 
            // baud_rate_Box
            // 
            this.baud_rate_Box.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.baud_rate_Box.FormattingEnabled = true;
            this.baud_rate_Box.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.baud_rate_Box.Location = new System.Drawing.Point(272, 22);
            this.baud_rate_Box.Name = "baud_rate_Box";
            this.baud_rate_Box.Size = new System.Drawing.Size(121, 28);
            this.baud_rate_Box.TabIndex = 12;
            this.baud_rate_Box.Text = "9600";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(217, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "鮑率";
            // 
            // btn_conn
            // 
            this.btn_conn.BackColor = System.Drawing.Color.Green;
            this.btn_conn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_conn.Location = new System.Drawing.Point(408, 15);
            this.btn_conn.Name = "btn_conn";
            this.btn_conn.Size = new System.Drawing.Size(100, 40);
            this.btn_conn.TabIndex = 14;
            this.btn_conn.Text = "1.連線";
            this.btn_conn.UseVisualStyleBackColor = false;
            this.btn_conn.Click += new System.EventHandler(this.btn_conn_Click);
            // 
            // btn_auto
            // 
            this.btn_auto.BackColor = System.Drawing.SystemColors.Control;
            this.btn_auto.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_auto.Location = new System.Drawing.Point(819, 17);
            this.btn_auto.Name = "btn_auto";
            this.btn_auto.Size = new System.Drawing.Size(100, 40);
            this.btn_auto.TabIndex = 35;
            this.btn_auto.Text = "727自動";
            this.btn_auto.UseVisualStyleBackColor = false;
            this.btn_auto.Click += new System.EventHandler(this.btn_auto_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(514, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 39);
            this.button1.TabIndex = 46;
            this.button1.Text = "2.讀取門禁";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1030, 622);
            this.tabControl1.TabIndex = 47;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_712deln2);
            this.tabPage1.Controls.Add(this.btn_712readn2);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.listBox3);
            this.tabPage1.Controls.Add(this.btn_712del);
            this.tabPage1.Controls.Add(this.btn_712read);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.listBox2);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.btn_readid);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btn_clear);
            this.tabPage1.Controls.Add(this.btn_del_all);
            this.tabPage1.Controls.Add(this.Btn_string);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.btn_del_one);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.btn_Polling);
            this.tabPage1.Controls.Add(this.txt_rs232_TX);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_rs232_RX);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1022, 593);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "測試";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_712deln2
            // 
            this.btn_712deln2.Location = new System.Drawing.Point(349, 343);
            this.btn_712deln2.Name = "btn_712deln2";
            this.btn_712deln2.Size = new System.Drawing.Size(94, 39);
            this.btn_712deln2.TabIndex = 79;
            this.btn_712deln2.Text = "712刪除-n2";
            this.btn_712deln2.UseVisualStyleBackColor = true;
            this.btn_712deln2.Click += new System.EventHandler(this.btn_712deln2_Click_1);
            // 
            // btn_712readn2
            // 
            this.btn_712readn2.Location = new System.Drawing.Point(146, 343);
            this.btn_712readn2.Name = "btn_712readn2";
            this.btn_712readn2.Size = new System.Drawing.Size(97, 39);
            this.btn_712readn2.TabIndex = 78;
            this.btn_712readn2.Text = "712讀取-n2";
            this.btn_712readn2.UseVisualStyleBackColor = true;
            this.btn_712readn2.Click += new System.EventHandler(this.btn_712readn2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(902, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 19);
            this.label12.TabIndex = 77;
            this.label12.Text = "節點3/出";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(887, 61);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(100, 514);
            this.listBox3.TabIndex = 76;
            // 
            // btn_712del
            // 
            this.btn_712del.Location = new System.Drawing.Point(249, 343);
            this.btn_712del.Name = "btn_712del";
            this.btn_712del.Size = new System.Drawing.Size(94, 39);
            this.btn_712del.TabIndex = 75;
            this.btn_712del.Text = "712刪除-n3";
            this.btn_712del.UseVisualStyleBackColor = true;
            this.btn_712del.Click += new System.EventHandler(this.btn_712del_Click);
            // 
            // btn_712read
            // 
            this.btn_712read.Location = new System.Drawing.Point(43, 343);
            this.btn_712read.Name = "btn_712read";
            this.btn_712read.Size = new System.Drawing.Size(97, 39);
            this.btn_712read.TabIndex = 74;
            this.btn_712read.Text = "712讀取-n3";
            this.btn_712read.UseVisualStyleBackColor = true;
            this.btn_712read.Click += new System.EventHandler(this.btn_712read_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(785, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 19);
            this.label11.TabIndex = 73;
            this.label11.Text = "節點2/進";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(660, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 19);
            this.label10.TabIndex = 72;
            this.label10.Text = "節點1";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(767, 61);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(100, 514);
            this.listBox2.TabIndex = 71;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox6.Location = new System.Drawing.Point(547, 539);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(60, 29);
            this.textBox6.TabIndex = 70;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(475, 549);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 19);
            this.label9.TabIndex = 69;
            this.label9.Text = "節點：";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(648, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(100, 514);
            this.listBox1.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 15);
            this.label8.TabIndex = 67;
            this.label8.Text = "陣列資料 35 bytes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(148, 549);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 19);
            this.label7.TabIndex = 66;
            this.label7.Text = "（組碼+卡號）：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(338, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 65;
            this.label6.Text = "卡號：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(160, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 64;
            this.label4.Text = "組碼：";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox5.Location = new System.Drawing.Point(306, 543);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(149, 29);
            this.textBox5.TabIndex = 63;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox4.Location = new System.Drawing.Point(410, 487);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 29);
            this.textBox4.TabIndex = 62;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox3.Location = new System.Drawing.Point(232, 487);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 29);
            this.textBox3.TabIndex = 61;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_readid
            // 
            this.btn_readid.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_readid.Location = new System.Drawing.Point(40, 513);
            this.btn_readid.Name = "btn_readid";
            this.btn_readid.Size = new System.Drawing.Size(100, 40);
            this.btn_readid.TabIndex = 60;
            this.btn_readid.Text = "讀取ID";
            this.btn_readid.UseVisualStyleBackColor = true;
            this.btn_readid.Click += new System.EventHandler(this.btn_readid_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(274, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 59;
            this.label3.Text = "接收資料位元組";
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_clear.Location = new System.Drawing.Point(146, 18);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 40);
            this.btn_clear.TabIndex = 58;
            this.btn_clear.Text = "清空";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click_1);
            // 
            // btn_del_all
            // 
            this.btn_del_all.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_del_all.Location = new System.Drawing.Point(437, 283);
            this.btn_del_all.Name = "btn_del_all";
            this.btn_del_all.Size = new System.Drawing.Size(195, 43);
            this.btn_del_all.TabIndex = 57;
            this.btn_del_all.Text = "Delete All Message";
            this.btn_del_all.UseVisualStyleBackColor = true;
            this.btn_del_all.Click += new System.EventHandler(this.btn_del_all_Click);
            // 
            // Btn_string
            // 
            this.Btn_string.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_string.Location = new System.Drawing.Point(532, 217);
            this.Btn_string.Name = "Btn_string";
            this.Btn_string.Size = new System.Drawing.Size(100, 40);
            this.Btn_string.TabIndex = 56;
            this.Btn_string.Text = "字串傳送";
            this.Btn_string.UseVisualStyleBackColor = true;
            this.Btn_string.Click += new System.EventHandler(this.Btn_string_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(42, 422);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(590, 45);
            this.textBox2.TabIndex = 55;
            // 
            // btn_del_one
            // 
            this.btn_del_one.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_del_one.Location = new System.Drawing.Point(221, 283);
            this.btn_del_one.Name = "btn_del_one";
            this.btn_del_one.Size = new System.Drawing.Size(195, 43);
            this.btn_del_one.TabIndex = 54;
            this.btn_del_one.Text = "727Delete";
            this.btn_del_one.UseVisualStyleBackColor = true;
            this.btn_del_one.Click += new System.EventHandler(this.btn_del_one_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(437, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 25);
            this.textBox1.TabIndex = 53;
            this.textBox1.Text = "0";
            // 
            // btn_Polling
            // 
            this.btn_Polling.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Polling.Location = new System.Drawing.Point(42, 281);
            this.btn_Polling.Name = "btn_Polling";
            this.btn_Polling.Size = new System.Drawing.Size(161, 45);
            this.btn_Polling.TabIndex = 52;
            this.btn_Polling.Text = "727Polling";
            this.btn_Polling.UseVisualStyleBackColor = true;
            this.btn_Polling.Click += new System.EventHandler(this.btn_Polling_Click);
            // 
            // txt_rs232_TX
            // 
            this.txt_rs232_TX.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_rs232_TX.Location = new System.Drawing.Point(40, 227);
            this.txt_rs232_TX.Name = "txt_rs232_TX";
            this.txt_rs232_TX.Size = new System.Drawing.Size(477, 29);
            this.txt_rs232_TX.TabIndex = 51;
            this.txt_rs232_TX.Text = "7E040125DB01";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(36, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 50;
            this.label2.Text = "資料接收：";
            // 
            // txt_rs232_RX
            // 
            this.txt_rs232_RX.Location = new System.Drawing.Point(40, 61);
            this.txt_rs232_RX.Multiline = true;
            this.txt_rs232_RX.Name = "txt_rs232_RX";
            this.txt_rs232_RX.Size = new System.Drawing.Size(592, 147);
            this.txt_rs232_RX.TabIndex = 49;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1022, 593);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "主頁面";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(31, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(967, 104);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "命令區塊";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(326, 31);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 54);
            this.button6.TabIndex = 92;
            this.button6.Text = "輸出TXT";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(808, 63);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(70, 24);
            this.radioButton4.TabIndex = 91;
            this.radioButton4.Text = "異常";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(896, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(50, 24);
            this.radioButton3.TabIndex = 90;
            this.radioButton3.Text = "出";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(896, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 24);
            this.radioButton2.TabIndex = 89;
            this.radioButton2.Text = "進";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(579, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker1.TabIndex = 88;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(808, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 24);
            this.radioButton1.TabIndex = 87;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "進出";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(449, 31);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 54);
            this.button5.TabIndex = 86;
            this.button5.Text = "查詢";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 56);
            this.button3.TabIndex = 84;
            this.button3.Text = "顯示今日記錄";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(173, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 54);
            this.button4.TabIndex = 85;
            this.button4.Text = "刪除全部記錄";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(31, 137);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(967, 431);
            this.dataGridView2.TabIndex = 83;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1022, 593);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "人事設定";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(979, 264);
            this.dataGridView1.TabIndex = 26;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_id);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.cbox_fm);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txt_rfid);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.txt_company);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.txt_number);
            this.groupBox4.Controls.Add(this.txt_phone);
            this.groupBox4.Controls.Add(this.txt_tel);
            this.groupBox4.Controls.Add(this.txt_name);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(26, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(974, 144);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "輸入區塊";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(152, 86);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(148, 31);
            this.txt_id.TabIndex = 52;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(37, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 20);
            this.label14.TabIndex = 51;
            this.label14.Text = "身份證字號";
            // 
            // cbox_fm
            // 
            this.cbox_fm.FormattingEnabled = true;
            this.cbox_fm.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbox_fm.Location = new System.Drawing.Point(819, 35);
            this.cbox_fm.Name = "cbox_fm";
            this.cbox_fm.Size = new System.Drawing.Size(77, 28);
            this.cbox_fm.TabIndex = 50;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(755, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 20);
            this.label13.TabIndex = 49;
            this.label13.Text = "性別";
            // 
            // txt_rfid
            // 
            this.txt_rfid.Location = new System.Drawing.Point(356, 34);
            this.txt_rfid.Name = "txt_rfid";
            this.txt_rfid.Size = new System.Drawing.Size(152, 31);
            this.txt_rfid.TabIndex = 48;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(254, 38);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 20);
            this.label19.TabIndex = 47;
            this.label19.Text = "RFID卡號";
            // 
            // txt_company
            // 
            this.txt_company.Location = new System.Drawing.Point(782, 83);
            this.txt_company.Name = "txt_company";
            this.txt_company.Size = new System.Drawing.Size(175, 31);
            this.txt_company.TabIndex = 46;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label20.Location = new System.Drawing.Point(687, 86);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 20);
            this.label20.TabIndex = 22;
            this.label20.Text = "所屬公司";
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(132, 35);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(94, 31);
            this.txt_number.TabIndex = 19;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(555, 83);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(127, 31);
            this.txt_phone.TabIndex = 9;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(376, 83);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(103, 31);
            this.txt_tel.TabIndex = 8;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(602, 35);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(139, 31);
            this.txt_name.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(500, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "手機";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(321, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "電話";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("新細明體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(545, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 20);
            this.label17.TabIndex = 2;
            this.label17.Text = "姓名";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(37, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 20);
            this.label18.TabIndex = 1;
            this.label18.Text = "員工編號";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_delallPDB);
            this.groupBox3.Controls.Add(this.btn_showAllDB);
            this.groupBox3.Controls.Add(this.btn_searchDB);
            this.groupBox3.Controls.Add(this.btn_delDB);
            this.groupBox3.Controls.Add(this.btn_addDB);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(26, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(974, 106);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "命令區塊";
            // 
            // btn_delallPDB
            // 
            this.btn_delallPDB.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_delallPDB.ForeColor = System.Drawing.Color.Red;
            this.btn_delallPDB.Location = new System.Drawing.Point(582, 30);
            this.btn_delallPDB.Name = "btn_delallPDB";
            this.btn_delallPDB.Size = new System.Drawing.Size(189, 57);
            this.btn_delallPDB.TabIndex = 23;
            this.btn_delallPDB.Text = "刪除所有人事資料";
            this.btn_delallPDB.UseVisualStyleBackColor = true;
            this.btn_delallPDB.Click += new System.EventHandler(this.btn_delallPDB_Click);
            // 
            // btn_showAllDB
            // 
            this.btn_showAllDB.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_showAllDB.Location = new System.Drawing.Point(279, 30);
            this.btn_showAllDB.Name = "btn_showAllDB";
            this.btn_showAllDB.Size = new System.Drawing.Size(142, 58);
            this.btn_showAllDB.TabIndex = 21;
            this.btn_showAllDB.Text = "顯示全部資料";
            this.btn_showAllDB.UseVisualStyleBackColor = true;
            this.btn_showAllDB.Click += new System.EventHandler(this.btn_showAllDB_Click);
            // 
            // btn_searchDB
            // 
            this.btn_searchDB.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_searchDB.ForeColor = System.Drawing.Color.Blue;
            this.btn_searchDB.Location = new System.Drawing.Point(171, 30);
            this.btn_searchDB.Name = "btn_searchDB";
            this.btn_searchDB.Size = new System.Drawing.Size(102, 58);
            this.btn_searchDB.TabIndex = 20;
            this.btn_searchDB.Text = "姓名查詢";
            this.btn_searchDB.UseVisualStyleBackColor = true;
            this.btn_searchDB.Click += new System.EventHandler(this.btn_searchDB_Click);
            // 
            // btn_delDB
            // 
            this.btn_delDB.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_delDB.ForeColor = System.Drawing.Color.Red;
            this.btn_delDB.Location = new System.Drawing.Point(427, 30);
            this.btn_delDB.Name = "btn_delDB";
            this.btn_delDB.Size = new System.Drawing.Size(149, 57);
            this.btn_delDB.TabIndex = 14;
            this.btn_delDB.Text = "RFID單一刪除";
            this.btn_delDB.UseVisualStyleBackColor = true;
            this.btn_delDB.Click += new System.EventHandler(this.btn_delDB_Click);
            // 
            // btn_addDB
            // 
            this.btn_addDB.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_addDB.Location = new System.Drawing.Point(27, 29);
            this.btn_addDB.Name = "btn_addDB";
            this.btn_addDB.Size = new System.Drawing.Size(138, 58);
            this.btn_addDB.TabIndex = 12;
            this.btn_addDB.Text = "新增員工資料";
            this.btn_addDB.UseVisualStyleBackColor = true;
            this.btn_addDB.Click += new System.EventHandler(this.btn_addDB_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(925, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 40);
            this.button2.TabIndex = 48;
            this.button2.Text = "資料庫測試";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox7.Location = new System.Drawing.Point(665, 20);
            this.textBox7.Name = "textBox7";
            this.textBox7.PasswordChar = '*';
            this.textBox7.Size = new System.Drawing.Size(100, 31);
            this.textBox7.TabIndex = 49;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button7.Location = new System.Drawing.Point(780, 17);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 38);
            this.button7.TabIndex = 50;
            this.button7.Text = "解鎖";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 671);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_auto);
            this.Controls.Add(this.btn_conn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.baud_rate_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "鉅鑫門禁系統 ver 1.0 2018/03";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btn_auto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_712deln2;
        private System.Windows.Forms.Button btn_712readn2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btn_712del;
        private System.Windows.Forms.Button btn_712read;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_readid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_del_all;
        private System.Windows.Forms.Button Btn_string;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_del_one;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Polling;
        private System.Windows.Forms.TextBox txt_rs232_TX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_rs232_RX;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_delallPDB;
        private System.Windows.Forms.Button btn_showAllDB;
        private System.Windows.Forms.Button btn_searchDB;
        private System.Windows.Forms.Button btn_delDB;
        private System.Windows.Forms.Button btn_addDB;
        private System.Windows.Forms.TextBox txt_company;
        private System.Windows.Forms.TextBox txt_rfid;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbox_fm;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        //private SOYAL.DBMSDataSet dBMSDataSet;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button7;
        //private SOYAL.DBMSDataSetTableAdapters.PersonTableAdapter personTableAdapter;
    }
}

