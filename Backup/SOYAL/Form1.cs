using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;



namespace RS232
{
    public partial class Form1 : Form
    {
        public int i,j=0,node_nu=1, bytes_count=0; //i:迴圈用,j:接收資料陣列用,node_nu:節點旗標,bytes_count:位元計數用
        public byte[] Rx_data=new byte[35]; //rs232接收,預設陣列
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
                 textBox3.Text = (Rx_data[19] * 256 + Rx_data[20]).ToString(); //組碼
                 textBox4.Text = (Rx_data[23] * 256 + Rx_data[24]).ToString(); //卡號
                 textBox5.Text = textBox3.Text + textBox4.Text;  //組碼+卡號
                 textBox6.Text = Rx_data[12].ToString();    //節點編號
                 
                 if(Rx_data[0]==126 && Rx_data[1]==29){ //判斷關鍵值是否符合
                     if (Rx_data[12] == 1)
                     {
                         listBox1.Items.Add(textBox5.Text); //新增Tag-ID 至node1 DB or 新增至資料庫
                     }
                     if (Rx_data[12] == 2)
                     {
                         listBox2.Items.Add(textBox5.Text); //新增Tag-ID 至node2 DB or 新增至資料庫
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
        }

        
        private void btn_conn_Click(object sender, EventArgs e) //連線
        {


            if ( serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = comBox.Text;
                    serialPort1.BaudRate = Convert.ToUInt16(baud_rate_Box.Text);
                    serialPort1.Open();
                    btn_conn.Text = "中斷";
                    btn_conn.BackColor =Color.Red;
                    btn_clear.Enabled = true;
                    btn_del_all.Enabled = true;
                    btn_Polling.Enabled = true;
                    btn_readid.Enabled = true;
                    Btn_string.Enabled = true;
                    btn_del_one.Enabled = true ;
                    btn_auto.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if (serialPort1.IsOpen==true)
            {
                try
                {
                    serialPort1.Close();
                    btn_conn.Text = "連線";
                    btn_conn.BackColor = Color.Green;
                    btn_clear.Enabled = false ;
                    btn_del_all.Enabled = false;
                    btn_Polling.Enabled = false;
                    btn_readid.Enabled = false;
                    Btn_string.Enabled = false;
                    btn_del_one.Enabled = false;
                    btn_auto.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }



        private void Btn_string_Click(object sender, EventArgs e)   //傳送字串
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

        private void btn_clear_Click(object sender, EventArgs e) //清除接收區資料
        {
            txt_rs232_RX.Text = "";
            textBox1.Text = "0";
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



    }
}
