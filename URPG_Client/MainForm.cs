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

        private const int STATS_POINTS = 20;

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
            m_pData = new PlayerData();
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

        private bool IsPrimaryStatsFilled()
        {
            return trackBarStrength.Value + trackBarAgility.Value + trackBarIntelligence.Value + trackBarStamina.Value >= STATS_POINTS;
        }

        private void trackBarStrength_Scroll(object sender, EventArgs e)
        {
            if (IsPrimaryStatsFilled())
                trackBarStrength.Value = STATS_POINTS - (trackBarAgility.Value + trackBarIntelligence.Value + trackBarStamina.Value);
            m_pData.GetStats().m_strength = (uint)trackBarStrength.Value;
            labelStr.Text = trackBarStrength.Value.ToString();
        }

        private void trackBarAgility_Scroll(object sender, EventArgs e)
        {
            if (IsPrimaryStatsFilled())
                trackBarAgility.Value = STATS_POINTS - (trackBarStrength.Value + trackBarIntelligence.Value + trackBarStamina.Value);
            m_pData.GetStats().m_agility = (uint)trackBarAgility.Value;
            labelAgi.Text = trackBarAgility.Value.ToString();
        }

        private void trackBarIntelligence_Scroll(object sender, EventArgs e)
        {
            if (IsPrimaryStatsFilled())
                trackBarIntelligence.Value = STATS_POINTS - (trackBarAgility.Value + trackBarStrength.Value + trackBarStamina.Value);
            m_pData.GetStats().m_intelligence = (uint)trackBarIntelligence.Value;
            labelInt.Text = trackBarIntelligence.Value.ToString();
        }

        private void trackBarStamina_Scroll(object sender, EventArgs e)
        {
            if (IsPrimaryStatsFilled())
                trackBarStamina.Value = STATS_POINTS - (trackBarAgility.Value + trackBarIntelligence.Value + trackBarStrength.Value);
            m_pData.GetStats().m_stamina = (uint)trackBarStamina.Value;
            labelSta.Text = trackBarStamina.Value.ToString();
        }
    }
}
