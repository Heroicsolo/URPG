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
        static IPAddress ipAddr;
        static Socket sender;

        public static void Init()
        {
            //Connect(""); //here we will connect to the server
        }

        public static void GetPlayerData(byte[] data)
        {
            if (SessionData.s_gameType == "ClassicFantasy")
                ClassicFantasy.Mechanics.PlayerData.Deserialize(data);
            else if (SessionData.s_gameType == "Fallout")
                Fallout.Mechanics.PlayerData.Deserialize(data);
        }

        public static bool Connect(string address)
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

        public static void Disconnect()
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

        public static void ProcessServerResponse(byte[] response)
        {

        }

        public static void SendMessage(byte[] data)
        {
            int bytesSent = sender.Send(data);

            byte[] bytes = new byte[1024];
            int bytesRec = sender.Receive(bytes);

            ProcessServerResponse(bytes);
        }
    }
}
