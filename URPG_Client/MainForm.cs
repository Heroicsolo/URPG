using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace URPG_Client
{
    public partial class MainForm : Form
    {
        private IPAddress ipAddr;
        private Socket sender;

        private PlayerData m_pData;

        public void SendPlayerData()
        {
            IFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            formatter.Serialize(stream, m_pData.GetStats());
            SendMessage(stream.ToArray());
            stream.Close();
        }

        public void GetPlayerData(byte[] data)
        {
            IFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            m_pData.SetStats(formatter.Deserialize(stream) as PlayerStats);
            stream.Close();
        }

        public bool Connect(string address, string name, string pass)
        {
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            //ipAddr = ipHost.AddressList[0];
            ipAddr = IPAddress.Parse(address);

            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);

            sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            sender.Connect(ipEndPoint);

            byte[] msg = Encoding.UTF8.GetBytes("/connect");
            int bytesSent = sender.Send(msg);

            if (bytesSent <= 0)
              return false;

            msg = Encoding.UTF8.GetBytes("/login:" + name + ":" + pass);
            bytesSent = sender.Send(msg);

            byte[] bytes = new byte[1024];
            int bytesRec = sender.Receive(bytes);

            if (bytesRec > 0)
            {
                SendPlayerData();
            }

            return true;
        }

        public void Disconnect()
        {
            byte[] msg = Encoding.UTF8.GetBytes("/leave");
            int bytesSent = sender.Send(msg);

            byte[] bytes = new byte[1024];
            int bytesRec = sender.Receive(bytes);

            if (bytesRec > 0)
            {
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void ProcessServerResponse(byte[] response)
        {

        }

        public void SendMessage(byte[] data)
        {
            int bytesSent = sender.Send(data);

            byte[] bytes = new byte[1024];
            int bytesRec = sender.Receive(bytes);

            ProcessServerResponse(bytes);
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm(this);
            login.Show();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Disconnect();
        }
    }
}
