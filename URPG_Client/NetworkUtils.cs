using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace URPG_Client
{
    static class NetworkUtils
    {
        private IPAddress ipAddr;
        private Socket sender;
        public static PlayerData m_pData;

        public static void Init()
        {
            m_pData = new PlayerData();

            //Connect(""); //here we will connect to the server
        }

        public static PlayerStats GetCharacterStats()
        {
            return m_pData.GetStats();
        }

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

        public bool Connect(string address)
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
    }
}
