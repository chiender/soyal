using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Data.OleDb;
using System.IO;


namespace RS232
{
    public partial class Form1 : Form
    {
        public int i,j=0,node_nu=1, bytes_count=0; //i:迴圈用,j:接收資料陣列用,node_nu:節點旗標,bytes_count:位元計數用
        public byte[] Rx_data=new byte[35]; //rs232接收,預設陣列
        public int inout_in;
        public int inout_out;
        public string rfid_err;
        OleDbConnection conn;  
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'dBMSDataSet.Person' 資料表。您可以視需要進行移動或移除。
            //this.personTableAdapter.Fill(this.dBMSDataSet.Person);
            System.IO.Ports.SerialPort sport = new System.IO.Ports.SerialPort();//宣告連接埠
            foreach (string com in System.IO.Ports.SerialPort.GetPortNames())//取得所有可用的連接埠
            {
                comBox.Items.Add(com);
            }
            btn_clear.Enabled = false;
            btn_del_all.Enabled = false;
            btn_Polling.Enabled = false;
            btn_readid.Enabled = false;
            Btn_string.Enabled = false;
            btn_del_one.Enabled = false;
            btn_auto.Enabled = false;


            button4.Enabled = false;
            btn_delDB.Enabled = false;
            btn_delallPDB.Enabled = false;
            btn_auto.Visible = false;
            button2.Visible = false;
            button1.Enabled = false;
            tabControl1.TabPages.Remove(tabPage1);
            


            //string dbpath = "DBMS.mdb";    //宣告資料庫所在的路徑變數
            string Source;                 //宣告連線的字串
            //Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DBMS.mdb";

            //OleDbConnection conn;          //宣告連線的物件
            conn = new OleDbConnection(Source);   //連線
            conn.Open();          //開啟資料庫
            MessageBox.Show("成功連結到資料庫", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //conn.Close();         //關閉資料庫
            
        }

        private void RS232Data(object s, EventArgs e)   //rs232接收資料
        {

            int Rx_count = serialPort1.BytesToRead; //接收多少資料位元組
            byte[] RxBuff = new byte[Rx_count];
            
            serialPort1.Read(RxBuff, 0, Rx_count);  //讀取資料

            //txt_rs232_RX.Text = txt_rs232_RX.Text + ByteArrayToHexString(RxBuff)+"\n";   //顯示資料
            
            //將片段接收的資料,存入預設的陣列Rx_data 
            for (i = bytes_count ; i < (Rx_count+bytes_count) ; i++) {
                 if (j != Rx_count)
                 {
                     Rx_data[i] = RxBuff[j];
                 }
                 j++;

             }
             j = 0;

             bytes_count=Rx_count +bytes_count ;    //計算資料接收位元組

             textBox1.Text = bytes_count.ToString();
             if (bytes_count == 31)     //判斷回傳長度是否為31 bytes,有讀到tag為31 bytes
             {
                 textBox2.Text = "";
                 textBox2.Text = textBox2.Text + ByteArrayToHexString(Rx_data);
                 textBox3.Text = (Rx_data[19] * 256 + Rx_data[20]).ToString().PadLeft(5, '0'); //組碼
                 textBox4.Text = (Rx_data[23] * 256 + Rx_data[24]).ToString().PadLeft(5,'0'); //卡號
                 textBox5.Text = textBox3.Text + textBox4.Text;  //組碼+卡號
                 textBox6.Text = Rx_data[12].ToString();    //節點編號
                 
                 if(Rx_data[0]==126 && Rx_data[1]==29){ //判斷關鍵值是否符合
                     if (Rx_data[12] == 1)
                     {
                         listBox1.Items.Add(textBox5.Text); //新增Tag-ID 至node1 DB or 新增至資料庫
                     }
                     if (Rx_data[12] == 2) //進
                     {
                         string inout = "進";
                         
                         //listBox2.Items.Add(textBox5.Text); //新增Tag-ID 至node2 DB or 新增至資料庫
                         //btn_712deln2.PerformClick(); //712
                         
                         btn_712deln2_Click (sender, e);//變新增一函數

                         delay(1);
                         string SelectCmd = "INSERT INTO arrivals(日期,時間,出入,員工編號,RFID,姓名,性別,身份證字號,電話,手機,公司) select '" + DateTime.Now.ToShortDateString()
                             + "','" + DateTime.Now.ToLongTimeString().ToString() + "','" + inout + "',員工編號,RFID,姓名,性別,身份證字號,電話,手機,公司 FROM Person WHERE RFID='" + textBox5.Text.Trim() + "'";
                         OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
                         Cmd.ExecuteNonQuery();
                         button3.PerformClick();
                         
                     }
                     if (Rx_data[12] == 3) //出
                     {
                         string inout = "出";
                         //listBox3.Items.Add(textBox5.Text); //新增Tag-ID 至node3 DB or 新增至資料庫
                         //btn_712del.PerformClick();
                         btn_712del_Click (sender, e);
                         delay(1);
                         
                         string SelectCmd = "INSERT INTO arrivals(日期,時間,出入,員工編號,RFID,姓名,性別,身份證字號,電話,手機,公司) select '" + DateTime.Now.ToShortDateString()
                             + "','" + DateTime.Now.ToLongTimeString().ToString() + "','" + inout + "',員工編號,RFID,姓名,性別,身份證字號,電話,手機,公司 FROM Person WHERE RFID='" + textBox5.Text.Trim() + "'";
                         
                         OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
                         Cmd.ExecuteNonQuery();
                         button3.PerformClick();
                     }

                 }
                    



                 Array.Clear(Rx_data, 0, 34);   //清空預設陣列
                 btn_del_one.PerformClick();    //刪除RFID一筆記錄
             }
             else if (bytes_count == 12) //判斷回傳長度是否為12 bytes,沒有讀到tag為12 byte
             {

                 if (Rx_data[0] == 126 && Rx_data[1] == 10) //判斷關鍵值是否符合
                 {
                     //更改node_nu,可交互詢問node 1 及 node 2
                     if (Rx_data[4] == 1) { 

                         node_nu = 2;
                     }
                     if (Rx_data[4] == 2) {
                         node_nu = 1;
                     }
                 }               
             }

        }

        private void btn_712deln2_Click(object sender, EventArgs e)
        {
            try
            {
                //變新增一函數,對應以上
                //throw new NotImplementedException();
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();
                bytes_count = 0;
                j = 0;

                byte[] TxBuff = new byte[6] { 126, 4, 2, 55, 202, 3 }; // 刪除 指令碼,節點3
                serialPort1.Write(TxBuff, 0, 6);
            }
            catch (Exception ex)
            {

            }
            
        }

        //bytes to Hex,無特別數值轉換時,可省略以下
        private string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
            return sb.ToString().ToUpper();
        }
        // Hex to bytes,無特別數值轉換時,可省略以下
        private byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }


        private void serialPort1_DataReceievd(object sender, SerialDataReceivedEventArgs e)//RS232接收料資觸發
        {
            this.Invoke(new EventHandler(RS232Data));
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("bye bye");
            serialPort1.Close();
            conn.Close();         //關閉資料庫
        }

        
        private void btn_conn_Click(object sender, EventArgs e) //連線
        {

            if (comBox.Text == "")
            {
                MessageBox.Show("請選擇連接埠", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (serialPort1.IsOpen == false)
                {
                    try
                    {
                        serialPort1.PortName = comBox.Text;
                        serialPort1.BaudRate = Convert.ToUInt16(baud_rate_Box.Text);
                        serialPort1.Open();
                        btn_conn.Text = "1.中斷";
                        btn_conn.BackColor = Color.Red;
                        btn_clear.Enabled = true;
                        btn_del_all.Enabled = true;
                        btn_Polling.Enabled = true;
                        btn_readid.Enabled = true;
                        Btn_string.Enabled = true;
                        btn_del_one.Enabled = true;
                        btn_auto.Enabled = true;
                        button1.Enabled = true;
                        //button1.PerformClick(); //712自動
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else if (serialPort1.IsOpen == true)
                {
                    try
                    {
                        serialPort1.Close();
                        btn_conn.Text = "1.連線";
                        btn_conn.BackColor = Color.Green;
                        btn_clear.Enabled = false;
                        btn_del_all.Enabled = false;
                        btn_Polling.Enabled = false;
                        btn_readid.Enabled = false;
                        Btn_string.Enabled = false;
                        btn_del_one.Enabled = false;
                        btn_auto.Enabled = false;
                        button1.Enabled = false;
                        //button1.PerformClick(); //712自動
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            
            
        }



        private void Btn_string_Click_1(object sender, EventArgs e)   //傳送字串
        {
            serialPort1.DiscardInBuffer();
            serialPort1.DiscardOutBuffer();
            bytes_count = 0;
            j = 0;
            byte[] data = HexStringToByteArray(txt_rs232_TX.Text);
            serialPort1.Write(data, 0, data.Length);

        }

        private void btn_Polling_Click(object sender, EventArgs e) //詢問RFID polling message
        {
            serialPort1.DiscardInBuffer();
            serialPort1.DiscardOutBuffer();
            bytes_count = 0;
            j = 0;
            if (node_nu == 1) //詢問node 1
            {
                byte[] TxBuff = new byte[6] { 126, 4, 1, 37, 219, 1 }; // Polling 指令碼,節點1
                serialPort1.Write(TxBuff, 0, 6);

            }
            if (node_nu == 2) //詢問node 2
            {
                byte[] TxBuff2 = new byte[6] { 126, 4, 2, 37, 216, 255 }; // Polling 指令碼,節點2
                serialPort1.Write(TxBuff2, 0, 6);
            }
        }

        private void btn_del_one_Click(object sender, EventArgs e) //刪除RFID一筆記錄
        {
            serialPort1.DiscardInBuffer();
            serialPort1.DiscardOutBuffer();
            bytes_count = 0;
            j = 0;
            if (node_nu == 1)
            {
                byte[] TxBuff = new byte[9] { 126, 7, 1, 55, 68, 69, 76, 132, 145 };//指令碼,節點1
                serialPort1.Write(TxBuff, 0, 9);
                
            }
            if (node_nu == 2)
            {
                byte[] TxBuff2 = new byte[6] { 126, 4, 2, 55, 202, 3 };//指令碼,節點2
                serialPort1.Write(TxBuff2, 0, 6);
            }
        }

        private void btn_del_all_Click(object sender, EventArgs e) //刪除RFID全部記錄
        {
            serialPort1.DiscardInBuffer();
            serialPort1.DiscardOutBuffer();
            bytes_count = 0;
            j = 0;
            byte[] TxBuff = new byte[12] { 126, 10, 1, 45, 68, 69, 76, 65, 76, 76, 223, 187 };//指令碼,節點1
            serialPort1.Write(TxBuff, 0, 12);
        }

        private void btn_clear_Click_1(object sender, EventArgs e) //清除接收區資料
        {
            txt_rs232_RX.Text = "";
            textBox1.Text = "0";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void btn_readid_Click(object sender, EventArgs e) //讀取,組碼,卡號,節點
        {
            textBox2.Text = "";
            textBox2.Text = textBox2.Text + ByteArrayToHexString(Rx_data);
            textBox3.Text = (Rx_data[19] * 256 + Rx_data[20]).ToString();
            textBox4.Text = (Rx_data[23] * 256 + Rx_data[24]).ToString();
            textBox5.Text = textBox3.Text + textBox4.Text;
            textBox6.Text = Rx_data[12].ToString();
            if (bytes_count==31){
                listBox1.Items.Add(textBox5.Text);
            }
            Array.Clear(Rx_data, 0, 34);
        }

        private void btn_auto_Click(object sender, EventArgs e)  //自動化
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
                btn_auto.Text = "自動停止";
                btn_auto.BackColor = Color.Red;

            }
            else {

                timer1.Enabled = false;
                btn_auto.Text = "自動開始";
                btn_auto.BackColor = Color.Transparent;

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btn_Polling.PerformClick ();
        }

        private void btn_712read_Click(object sender, EventArgs e)
        {
            //712D讀取第3節點
            serialPort1.DiscardInBuffer();
            serialPort1.DiscardOutBuffer();
            bytes_count = 0;
            j = 0;
            //7E040325D901 :03為讀取第3的節點 / 126, 4, 3, 37, 217, 1
            byte[] TxBuff = new byte[6] { 126, 4, 3, 37, 217, 1 }; // Polling 指令碼,節點3

            //7E040125D901 :01為讀取第1的節點 / 126, 4, 3, 37, 217, 1
            //byte[] TxBuff = new byte[6] { 126, 4, 1, 37, 219, 1 }; // Polling 指令碼,節點1


            serialPort1.Write(TxBuff, 0, 6);

            //if (node_nu == 1) //詢問node 1
            //{
            //    byte[] TxBuff = new byte[6] { 126, 4, 3, 37, 217, 1 }; // Polling 指令碼,節點3
            //    serialPort1.Write(TxBuff, 0, 6);

            //}
            //if (node_nu == 2) //詢問node 2
            //{
            //    byte[] TxBuff2 = new byte[6] { 126, 4, 2, 37, 216, 255 }; // Polling 指令碼,節點2
            //    serialPort1.Write(TxBuff2, 0, 6);
            //}
        }

        private void btn_712del_Click(object sender, EventArgs e)
        {
            //7E040337CB05 :03為刪除第3的節點 / 126, 4, 3, 55, 203, 5
            serialPort1.DiscardInBuffer();
            serialPort1.DiscardOutBuffer();
            bytes_count = 0;
            j = 0;

            byte[] TxBuff = new byte[6] { 126, 4, 3, 55, 203, 5 }; // 刪除 指令碼,節點3
            serialPort1.Write(TxBuff, 0, 6);
        }



        private void delay(int seconds)
        {
            if (seconds < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(seconds);
            while (DateTime.Now < _desired)
            {
                Thread.Sleep(1);
                System.Windows.Forms.Application.DoEvents();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //btn_712read.PerformClick();
            btn_712read_Click(sender, e);
            delay(2);
            //btn_712readn2.PerformClick();
            btn_712readn2_Click(sender, e);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (timer2.Enabled == false)
                {
                    timer2.Enabled = true;
                    button1.Text = "2.停止讀取";
                    button1.BackColor = Color.Red;

                }
                else
                {
                    timer2.Enabled = false;
                    button1.Text = "2.讀取門禁";
                    button1.BackColor = Color.Transparent;
                }

            }
            catch (Exception ex)
            {

            }
            
        }

        private void btn_712readn2_Click(object sender, EventArgs e)
        {
            ////712D讀取第2節點
            //serialPort1.DiscardInBuffer();
            serialPort1.DiscardOutBuffer();
            bytes_count = 0;
            j = 0;
            //7E040325D901 :03為讀取第3的節點 / 126, 4, 3, 37, 217, 1
            //byte[] TxBuff = new byte[6] { 126, 4, 3, 37, 217, 1 }; // Polling 指令碼,節點3

            //7E040125D901 :01為讀取第1的節點 / 126, 4, 3, 37, 217, 1
            //byte[] TxBuff = new byte[6] { 126, 4, 1, 37, 219, 1 }; // Polling 指令碼,節點1

            //7E040225D8FF :02為讀取第2的節點 / 126, 4, 3, 37, 217, 1
            byte[] TxBuff = new byte[6] { 126, 4, 2, 37, 216, 255 }; // Polling 指令碼,節點1

            serialPort1.Write(TxBuff, 0, 6);
        }

        private void btn_712deln2_Click_1(object sender, EventArgs e)
        {
            //7E040237CA03  :02為刪除第2的節點 / 126, 4, 3, 55, 203, 5
            serialPort1.DiscardInBuffer();
            serialPort1.DiscardOutBuffer();
            bytes_count = 0;
            j = 0;

            byte[] TxBuff = new byte[6] { 126, 4, 2, 55, 202, 3 }; // 刪除 指令碼,節點2
            serialPort1.Write(TxBuff, 0, 6);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string dbpath = "DBMS.mdb";    //宣告資料庫所在的路徑變數
            string Source;                 //宣告連線的字串
            //Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DBMS.mdb";
            //Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DBMS.mdb";
            
            //OleDbConnection conn;          //宣告連線的物件
            conn = new OleDbConnection(Source);   //連線
            conn.Open();          //開啟資料庫
            MessageBox.Show("成功連結到Access資料庫");
            //conn.Close();         //關閉資料庫
        }

        private void btn_showAllDB_Click(object sender, EventArgs e)
        {
            string SelectCmd = "select * from Person order by 員工編號 ASC";
            //OleDbCommand cmd = new OleDbCommand(SelectCmd, conn);
            //cmd.ExecuteReader();

            //宣告物件
            OleDbDataAdapter DtApter;
            DataSet DtSet;
            DtApter = new OleDbDataAdapter(SelectCmd, conn);
            DtSet = new DataSet();
            //讀取資料表
            DtApter.Fill(DtSet, "Person");
            dataGridView1.DataSource = DtSet.Tables["Person"];
        }



        private void btn_delallPDB_Click(object sender, EventArgs e)
        {
            string SelectCmd = "DELETE * FROM Person ";
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            Cmd.ExecuteNonQuery();
            btn_showAllDB.PerformClick();
            MessageBox.Show("已刪除所有人事資料庫", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_addDB_Click(object sender, EventArgs e)
        {

            if (txt_rfid.Text == "" || txt_name.Text == "")
            {
                MessageBox.Show("請輸入參數", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string SelectCmd = "INSERT INTO Person(員工編號,RFID,姓名,性別,身份證字號,電話,手機,公司) VALUES('"
                                + txt_number.Text.Trim() + "','" + txt_rfid.Text.Trim() + "','" +
                                txt_name.Text.Trim() + "','" + cbox_fm.Text.Trim() + "','" +
                                txt_id.Text.Trim() + "','" + txt_tel.Text.Trim() + "','" +
                                txt_phone.Text.Trim() + "','" + txt_company.Text.Trim() + "')";
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            Cmd.ExecuteNonQuery();
            btn_showAllDB.PerformClick();
            txt_number.Text = "";
            txt_rfid.Text = "";
            txt_name.Text = "";
            txt_id.Text = "";
            txt_tel.Text = "";
            txt_phone.Text = "";
            //txt_company.Text = "";

            MessageBox.Show("成功新增", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btn_searchDB_Click(object sender, EventArgs e)
        {
            string SelectCmd = "select * FROM Person WHERE 姓名='"
                                                        + txt_name.Text.Trim() + "'";
            //宣告物件
            OleDbDataAdapter DtApter;
            DataSet DtSet;
            DtApter = new OleDbDataAdapter(SelectCmd, conn);
            DtSet = new DataSet();
            //讀取資料表
            DtApter.Fill(DtSet, "Person");
            dataGridView1.DataSource = DtSet.Tables["Person"];
            txt_name.Text = "";
        }

        private void btn_delDB_Click(object sender, EventArgs e)
        {
            string SelectCmd = "DELETE * FROM Person WHERE RFID='"
                                                        + txt_rfid.Text.Trim() + "'";
            //OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);

            //Cmd.ExecuteNonQuery();
            //btn_show_admin.PerformClick();
            //txt_name_admin.Text = "";
            //宣告物件
            OleDbDataAdapter DtApter;
            DataSet DtSet;
            DtApter = new OleDbDataAdapter(SelectCmd, conn);
            DtSet = new DataSet();
            //讀取資料表
            DtApter.Fill(DtSet, "Person");
            dataGridView1.DataSource = DtSet.Tables["Person"];
            txt_rfid.Text = "";
            MessageBox.Show("已刪除資料", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string SelectCmd = "select * from arrivals order by 員工編號 ASC";
            //OleDbCommand cmd = new OleDbCommand(SelectCmd, conn);
            //cmd.ExecuteReader();

            //宣告物件
            OleDbDataAdapter DtApter;
            DataSet DtSet;
            DtApter = new OleDbDataAdapter(SelectCmd, conn);
            DtSet = new DataSet();
            //讀取資料表
            DtApter.Fill(DtSet, "arrivals");
            dataGridView2.DataSource = DtSet.Tables["arrivals"];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string SelectCmd = "DELETE * FROM arrivals ";
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            Cmd.ExecuteNonQuery();
            button3.PerformClick();
            MessageBox.Show("已刪除所有人事資料庫", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //顯示今日刷卡人員
            string SelectCmd = "select * from arrivals where 日期 ='" + DateTime.Now.ToShortDateString() + "' order by 時間 desc";
            //OleDbCommand cmd = new OleDbCommand(SelectCmd, conn);
            //cmd.ExecuteReader();

            //宣告物件
            OleDbDataAdapter DtApter;
            DataSet DtSet;
            DtApter = new OleDbDataAdapter(SelectCmd, conn);
            DtSet = new DataSet();
            //讀取資料表
            DtApter.Fill(DtSet, "arrivals");
            dataGridView2.DataSource = DtSet.Tables["arrivals"];
        }









        public object sender { get; set; }

        private void button5_Click(object sender, EventArgs e)//查詢
        {
            if (radioButton1.Checked.ToString() == "True")//進出
            {
                //顯示今日刷卡人員
                string SelectCmd = "select * from arrivals where 日期 ='" + dateTimePicker1.Value.ToShortDateString() + "' order by 時間 desc";
                //OleDbCommand cmd = new OleDbCommand(SelectCmd, conn);
                //cmd.ExecuteReader();
                //宣告物件
                OleDbDataAdapter DtApter;
                DataSet DtSet;
                DtApter = new OleDbDataAdapter(SelectCmd, conn);
                DtSet = new DataSet();
                //讀取資料表
                DtApter.Fill(DtSet, "arrivals");
                dataGridView2.DataSource = DtSet.Tables["arrivals"];
                MessageBox.Show("共 " + DtSet.Tables["arrivals"].Rows.Count.ToString() + " 筆", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (radioButton2.Checked.ToString() == "True")//進
            {
                //顯示今日刷卡人員
                string SelectCmd = "select * from arrivals where 日期 ='" + dateTimePicker1.Value.ToShortDateString() + "' and 出入 = '進' order by 時間 desc";
                //OleDbCommand cmd = new OleDbCommand(SelectCmd, conn);
                //cmd.ExecuteReader();
                //宣告物件
                OleDbDataAdapter DtApter;
                DataSet DtSet;
                DtApter = new OleDbDataAdapter(SelectCmd, conn);
                DtSet = new DataSet();
                //讀取資料表
                DtApter.Fill(DtSet, "arrivals");
                dataGridView2.DataSource = DtSet.Tables["arrivals"];
                MessageBox.Show("共 " + DtSet.Tables["arrivals"].Rows.Count.ToString() + " 筆", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (radioButton3.Checked.ToString() == "True")//出
            {
                //顯示今日刷卡人員
                string SelectCmd = "select * from arrivals where 日期 ='" + dateTimePicker1.Value.ToShortDateString() + "' and 出入 = '出' order by 時間 desc";
                //OleDbCommand cmd = new OleDbCommand(SelectCmd, conn);
                //cmd.ExecuteReader();
                //宣告物件
                OleDbDataAdapter DtApter;
                DataSet DtSet;
                DtApter = new OleDbDataAdapter(SelectCmd, conn);
                DtSet = new DataSet();
                //讀取資料表
                DtApter.Fill(DtSet, "arrivals");
                dataGridView2.DataSource = DtSet.Tables["arrivals"];
                MessageBox.Show("共 " + DtSet.Tables["arrivals"].Rows.Count.ToString() + " 筆", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (radioButton4.Checked.ToString() == "True")//異常
            {
                rfid_err = "";
                //顯示今日刷卡人員
                //string SelectCmd = "(select 日期, 姓名 from arrivals where 日期 ='" + dateTimePicker1.Value.ToShortDateString() + "' and 出入 = '出') MINUS (select 日期, 姓名 from arrivals where 日期 ='"  + dateTimePicker1.Value.ToShortDateString() + "' and 出入 = '進')";
                
                //string SelectCmd = "select * from arrivals where 日期 ='" + dateTimePicker1.Value.ToShortDateString() + "' and 出入 = '進' order by 時間 desc";
                string SelectCmd = "select RFID FROM Person";
                OleDbCommand cmd;
                OleDbCommand cmd2;
                OleDbCommand cmd3; 
                cmd = new OleDbCommand(SelectCmd, conn);
                OleDbDataReader reader;
                OleDbDataReader reader2;
                OleDbDataReader reader3;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //讀每一個RFID
                    for (i = 0; i < reader.FieldCount; i++) {

                        String SelectCmd2 = "select count(*) from arrivals where 日期 ='" + dateTimePicker1.Value.ToShortDateString() + "' and 出入 = '進' and RFID = '" + reader.GetValue(i).ToString() + "'";
                        cmd2 = new OleDbCommand(SelectCmd2, conn);
                        reader2 = cmd2.ExecuteReader();
                        String SelectCmd3 = "select count(*) from arrivals where 日期 ='" + dateTimePicker1.Value.ToShortDateString() + "' and 出入 = '出' and RFID = '" + reader.GetValue(i).ToString() + "'";
                        cmd3 = new OleDbCommand(SelectCmd3, conn);
                        reader3 = cmd3.ExecuteReader();
                        //讀取單一RFID的進出
                        while (reader2.Read())//進
                        {
                            inout_in = System.Convert.ToInt16(reader2.GetValue(0).ToString());
                            //MessageBox.Show(reader.GetValue(i).ToString()+":"+reader2.GetValue(0).ToString());
                        }
                        while (reader3.Read())//出
                        {
                            inout_out =System.Convert.ToInt16(reader3.GetValue(0).ToString());
                        }
                        if (inout_in > inout_out) //判斷異常,當進的次數大於出
                        {
                            if (rfid_err == "")
                            {
                                rfid_err = "'" + reader.GetValue(i).ToString() + "'";
                            }
                            else {
                                rfid_err = "'" + reader.GetValue(i).ToString() + "'," + rfid_err;
                            }
                            
                            //MessageBox.Show(reader.GetValue(i).ToString() + ":" + inout_in + ":" + inout_out);
                        }
                        
                    }

                }
                //MessageBox.Show(rfid_err); //show 異常的rfid
                if (rfid_err == "")
                {
                    SelectCmd = "select * from arrivals where 日期 ='" + dateTimePicker1.Value.ToShortDateString() + "' and RFID In ('0') order by RFID desc";
                }
                else
                {
                    SelectCmd = "select * from arrivals where 日期 ='" + dateTimePicker1.Value.ToShortDateString() + "' and RFID In (" + rfid_err + ") order by RFID desc";
                }
                
                //宣告物件
                OleDbDataAdapter DtApter;
                DataSet DtSet;
                DtApter = new OleDbDataAdapter(SelectCmd, conn);
                DtSet = new DataSet();
                //讀取資料表
                DtApter.Fill(DtSet, "arrivals");
                dataGridView2.DataSource = DtSet.Tables["arrivals"];
                MessageBox.Show("共 " + DtSet.Tables["arrivals"].Rows.Count.ToString() + " 筆", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //開檔
            {
                FileInfo f = new FileInfo(saveFileDialog1.FileName);
                //TextWriter sw = new StreamWriter(@"F:\Text.txt");
                StreamWriter sw = f.CreateText();
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView2.Columns.Count; j++)
                    {
                        sw.Write(dataGridView2.Rows[i].Cells[j].Value.ToString() + "\t");
                    }
                    sw.Write("\r\n");
                }
                sw.Close();
                MessageBox.Show("存檔成功", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            if (button7.Text == "解鎖")
            {
                if (textBox7.Text == "admin")
                {
                    button4.Enabled = true;
                    btn_delDB.Enabled = true;
                    btn_delallPDB.Enabled = true;
                    button7.Text = "上鎖";
                    textBox7.Text = "";
                }
                else
                {
                    textBox7.Text = "";
                    MessageBox.Show("密碼錯誤", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            //if (button7.Text == "上鎖")
            else
            {
                button4.Enabled = false;
                btn_delDB.Enabled = false;
                btn_delallPDB.Enabled = false;
                button7.Text = "解鎖";
                textBox7.Text = "";
            }
            
        }
    }
}
