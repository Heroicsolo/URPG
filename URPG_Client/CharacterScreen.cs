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
    public partial class CharacterScreen : Form
    {
        private IPAddress ipAddr;
        private Socket sender;

        private const int STATS_POINTS = 20;
        private const int QUALITIES_MAX = 2;

        private int m_checkedQualities = 0;

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

        public CharacterScreen()
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
            RefreshCharacterInfo();
        }

        private void trackBarAgility_Scroll(object sender, EventArgs e)
        {
            if (IsPrimaryStatsFilled())
                trackBarAgility.Value = STATS_POINTS - (trackBarStrength.Value + trackBarIntelligence.Value + trackBarStamina.Value);
            m_pData.GetStats().m_agility = (uint)trackBarAgility.Value;
            labelAgi.Text = trackBarAgility.Value.ToString();
            RefreshCharacterInfo();
        }

        private void trackBarIntelligence_Scroll(object sender, EventArgs e)
        {
            if (IsPrimaryStatsFilled())
                trackBarIntelligence.Value = STATS_POINTS - (trackBarAgility.Value + trackBarStrength.Value + trackBarStamina.Value);
            m_pData.GetStats().m_intelligence = (uint)trackBarIntelligence.Value;
            labelInt.Text = trackBarIntelligence.Value.ToString();
            RefreshCharacterInfo();
        }

        private void trackBarStamina_Scroll(object sender, EventArgs e)
        {
            if (IsPrimaryStatsFilled())
                trackBarStamina.Value = STATS_POINTS - (trackBarAgility.Value + trackBarIntelligence.Value + trackBarStrength.Value);
            m_pData.GetStats().m_stamina = (uint)trackBarStamina.Value;
            labelSta.Text = trackBarStamina.Value.ToString();
            RefreshCharacterInfo();
        }

        private void RefreshCharacterInfo()
        {
            m_pData.CalculateStats();
            labelInfo.Text = "HP: " +
                m_pData.GetStats().m_HP_max + "\nMP: " +
                m_pData.GetStats().m_MP_max +
                "\nEP: " + m_pData.GetStats().m_EP_max +
                "\nDODGE: " + (100 * m_pData.GetStats().m_dodgeChance) +
                "%\nARMOR: " + (100 * m_pData.GetStats().m_armor) + "%";
        }

        private void CheckCheckboxes()
        {
            if (m_checkedQualities >= QUALITIES_MAX)
            {
                checkBoxCrit.Enabled = checkBoxCrit.Checked;
                checkBoxRegen.Enabled = checkBoxRegen.Checked;
                checkBoxArcane.Enabled = checkBoxArcane.Checked;
                checkBoxDodginess.Enabled = checkBoxDodginess.Checked;
                checkBoxAmbidextry.Enabled = checkBoxAmbidextry.Checked;
                checkBoxWeaponMaster.Enabled = checkBoxWeaponMaster.Checked;
                checkBoxPoisonResist.Enabled = checkBoxPoisonResist.Checked;
            }
            else
            {
                checkBoxCrit.Enabled = true;
                checkBoxRegen.Enabled = true;
                checkBoxArcane.Enabled = true;
                checkBoxDodginess.Enabled = true;
                checkBoxAmbidextry.Enabled = true;
                checkBoxWeaponMaster.Enabled = true;
                checkBoxPoisonResist.Enabled = true;
            }
            RefreshCharacterInfo();
        }

        private void checkBoxPoisonResist_CheckedChanged(object sender, EventArgs e)
        {
            if (m_checkedQualities < QUALITIES_MAX && checkBoxPoisonResist.Checked)
            {
                m_pData.GetStats().m_poisonResist = true;
                m_checkedQualities++;
            }
            else if (!checkBoxPoisonResist.Checked)
            {
                m_pData.GetStats().m_poisonResist = false;
                m_checkedQualities--;
            }
            CheckCheckboxes();
        }

        private void checkBoxAmbidextry_CheckedChanged(object sender, EventArgs e)
        {
            if (m_checkedQualities < QUALITIES_MAX && checkBoxAmbidextry.Checked)
            {
                m_pData.GetStats().m_ambidextry = true;
                m_checkedQualities++;
            }
            else if (!checkBoxAmbidextry.Checked)
            {
                m_pData.GetStats().m_ambidextry = false;
                m_checkedQualities--;
            }
            CheckCheckboxes();
        }

        private void checkBoxCrit_CheckedChanged(object sender, EventArgs e)
        {
            if (m_checkedQualities < QUALITIES_MAX && checkBoxCrit.Checked)
            {
                m_pData.GetStats().m_criticalStrikes = true;
                m_checkedQualities++;
            }
            else if (!checkBoxCrit.Checked)
            {
                m_pData.GetStats().m_criticalStrikes = false;
                m_checkedQualities--;
            }
            CheckCheckboxes();
        }

        private void checkBoxRegen_CheckedChanged(object sender, EventArgs e)
        {
            if (m_checkedQualities < QUALITIES_MAX && checkBoxRegen.Checked)
            {
                m_pData.GetStats().m_regen = true;
                m_checkedQualities++;
            }
            else if (!checkBoxRegen.Checked)
            {
                m_pData.GetStats().m_regen = false;
                m_checkedQualities--;
            }
            CheckCheckboxes();
        }

        private void checkBoxArcane_CheckedChanged(object sender, EventArgs e)
        {
            if (m_checkedQualities < QUALITIES_MAX && checkBoxArcane.Checked)
            {
                m_pData.GetStats().m_arcaneIntelligence = true;
                m_checkedQualities++;
            }
            else if (!checkBoxArcane.Checked)
            {
                m_pData.GetStats().m_arcaneIntelligence = false;
                m_checkedQualities--;
            }
            CheckCheckboxes();
        }

        private void checkBoxDodginess_CheckedChanged(object sender, EventArgs e)
        {
            if (m_checkedQualities < QUALITIES_MAX && checkBoxDodginess.Checked)
            {
                m_pData.GetStats().m_dodginess = true;
                m_checkedQualities++;
            }
            else if (!checkBoxDodginess.Checked)
            {
                m_pData.GetStats().m_dodginess = false;
                m_checkedQualities--;
            }
            CheckCheckboxes();
        }

        private void checkBoxWeaponMaster_CheckedChanged(object sender, EventArgs e)
        {
            if (m_checkedQualities < QUALITIES_MAX && checkBoxWeaponMaster.Checked)
            {
                m_pData.GetStats().m_weaponMaster = true;
                m_checkedQualities++;
            }
            else if (!checkBoxWeaponMaster.Checked)
            {
                m_pData.GetStats().m_weaponMaster = false;
                m_checkedQualities--;
            }
            CheckCheckboxes();
        }
    }
}
