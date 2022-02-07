using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace MQL4TradePanel
{
    public partial class Form1 : Form
    {


        //TradePanel用DPI調整係数
        static readonly float DpiScale = ((new System.Windows.Forms.Form()).CreateGraphics().DpiX) / 96;

        //高DPI対応についてはこの辺
        //https://qiita.com/mono1729/items/a93505a5cb3fe194b7dc

        //socket通信についてはこの辺
        //https://itsakura.com/csharp-socket
        //https://qiita.com/_T_E_T_R_A_/items/bdd310714fea63474a7b


        TcpListener server = null;
        IPHostEntry ipHostInfo;
        IPAddress ipAddress;
        int port = 4545;

        bool startFlg = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void getTeminal_Click(object sender, EventArgs e)
        {
            //ローカルコンピュータ上で実行されている"notepad"という名前の
            //すべてのプロセスを取得
            System.Diagnostics.Process[] ps =
                System.Diagnostics.Process.GetProcessesByName("terminal");

            //配列から1つずつ取り出す
            foreach (System.Diagnostics.Process p in ps)
            {
                //IDとメインウィンドウのキャプションを出力する
                Console.WriteLine("{0}/{1}", p.Id, p.MainWindowTitle);
                connect.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            //connect.Enabled = false;
            //disconnect.Enabled = false;
           
            startFlg = true;
        }


        private void connect_ClickAsync(object sender, EventArgs e)
        {
            ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in ipHostInfo.AddressList)
            {
                Console.WriteLine(ip.ToString());
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {

                    ipAddress = ip;
                    //break;
                }
            }
            //ipAddress = ipHostInfo.AddressList[0];
            ipAddress = IPAddress.Parse("127.0.0.1");
            Task task = Task.Run(async () => { await SocketServer(); });

            //接続が成功したら
            //disconnect.Enabled = true;
            //connect.Enabled = false;
        }
        private void disconnect_Click(object sender, EventArgs e)
        {
            startFlg = false;

            //切断したら
            // disconnect.Enabled = false;
            //connect.Enabled = true;

            //ソケットの終了
            //server.Stop();
            Console.WriteLine("サーバー側終了です");
        }

        public async Task SocketServer()
        {
            //ここからIPアドレスやポートの設定
            // 着信データ用のデータバッファー。
            byte[] bytes = new byte[1024];

            await Task.Run(() =>
            {
                try
                {

                    Regex reg = new Regex("\0");
                    if (server == null)
                    {
                        //指定IP 指定ポートでサーバを起動
                        server = new TcpListener(new IPEndPoint(ipAddress, port));
                    }
                    server.Start();
                    while (startFlg)
                    {
                        if (!startFlg)
                        {
                            server.Stop();
                            break;
                        }

                        using (TcpClient tcpClient = server.AcceptTcpClient())
                        using (Stream stream = tcpClient.GetStream())
                        {
                            int i = 0;
                            while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                            {
                                string data1 = reg.Replace(Encoding.UTF8.GetString(bytes), "");



                                // 任意の処理
                                //データの受取をReceiveで行う。
                                //int bytesRec = handler.Receive(bytes);
                                //string data1 = Encoding.UTF8.GetString(bytes, 0, bytesRec);
                                if (data1.Length > 0)
                                {
                                    Console.WriteLine("data1の数:" + data1.Length);
                                    Console.WriteLine(data1);

                                    String[] sep = { "," };
                                    String[] sba = data1.Split(sep, StringSplitOptions.RemoveEmptyEntries);

                                    if (this.InvokeRequired)
                                    {
                                        //別スレッドによるUI操作
                                        this.Invoke((MethodInvoker)(() =>
                                        {
                                            bidTbx.Text = sba[1];
                                            askTbx.Text = sba[2];
                                        }));
                                    }
                                    else
                                    {
                                        //UIスレッドからのUI操作
                                        bidTbx.Text = sba[1];
                                        askTbx.Text = sba[2];
                                    }




                                    //大文字に変更
                                    data1 = data1.ToUpper();

                                    //クライアントにSendで返す。
                                    byte[] msg = Encoding.UTF8.GetBytes(data1);
                                    stream.Write(msg, 0, msg.Length);
                                    Array.Clear(bytes, 0, bytes.Length);
                                }
                            }
                        }

                        // break;
                    }
                }
                catch (Exception ex)

                {
                    Console.WriteLine(ex.ToString());
                }

            });

        }


        public static void SocketClient(string st)
        {
            //IPアドレスやポートを設定している。
            IPHostEntry ipHostInfo1 = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress1 = ipHostInfo1.AddressList[0];

            foreach (IPAddress ip in ipHostInfo1.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    ipAddress1 = ip;
                    break;
                }
            }

            ipAddress1 = IPAddress.Parse("127.0.0.1");

            IPEndPoint remoteEP = new IPEndPoint(ipAddress1, 4545);

            //ソケットを作成
            Socket socket = new Socket(ipAddress1.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            //接続する。失敗するとエラーで落ちる。
            socket.Connect(remoteEP);

            //Sendで送信している。
            byte[] msg = Encoding.UTF8.GetBytes(st + "<EOF>");
            socket.Send(msg);

            //Receiveで受信している。
            byte[] bytes = new byte[1024];
            int bytesRec = socket.Receive(bytes);
            string data1 = Encoding.UTF8.GetString(bytes, 0, bytesRec);
            Console.WriteLine(data1);

            //ソケットを終了している。
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }

        private void buyBtn1_Click(object sender, EventArgs e)
        {

            SocketClient("buy,141.25,,,OK");
        }

        private void sellBtn1_Click(object sender, EventArgs e)
        {

            SocketClient("sell,141.25,,,OK");
        }

        delegate void UpDateRateDelegate();

        void UpDateRate(String st)
        {
            if (InvokeRequired)
            {
                // 別スレッドから呼び出された場合
                //Invoke(new UpDateRateDelegate(UpDateRate));
                return;
            }
            askTbx.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
