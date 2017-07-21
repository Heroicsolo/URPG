using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URPG_Client
{
    public partial class GamesForm : Form
    {
        private bool m_sessionRunning = false;
        private ClassicFantasy.GUI fantasyGUI;

        public GamesForm()
        {
            InitializeComponent();
            fantasyGUI = new ClassicFantasy.GUI(this);
            NetworkUtils.Init();

            RemoveNextTabs();
            SessionData.Init();
        }

        private void RemoveNextTabs()
        {
            int i_currentTab = tabControlMain.SelectedIndex;
            for (int i = tabControlMain.TabPages.Count - 1; i > i_currentTab; i--)
                tabControlMain.TabPages.RemoveAt(i);
        }

        private void gamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            createButton.Enabled = true;
            RemoveNextTabs();
        }

        private void sessionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //here we will write free player slots availability
            joinButton.Enabled = true;
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            tabControlMain.TabPages.Add(tabPageCharacter);
            tabControlMain.SelectTab(tabPageCharacter);
            if (gamesListBox.SelectedItem == "Classic fantasy")
            {
                fantasyGUI.TryAddToParent(tabPageCharacter);
            }
            else if (gamesListBox.SelectedItem == "Fallout")
            {
                //some Fallout stuff
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            tabControlMain.TabPages.Add(tabPageSession);
            tabControlMain.SelectTab(tabPageSession);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectTab(tabPageConnect);
            RemoveNextTabs();
        }

        private void buttonLaunchSession_Click(object sender, EventArgs e)
        {
            tabControlMain.TabPages.Add(tabPageCharacter);
            tabControlMain.SelectTab(tabPageCharacter);

            SessionData.i_minPlayers = trackBarMinPlayers.Value;
            SessionData.i_maxPlayers = trackBarMaxPlayers.Value;
            SessionData.s_name = textBoxSessionName.Text;

            if (gamesListBox.SelectedItem == "Classic fantasy")
            {
                fantasyGUI.TryAddToParent(tabPageCharacter);
            }
            else if (gamesListBox.SelectedItem == "Fallout")
            {
                //some Fallout stuff
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            tabControlMain.TabPages.Remove(tabPageConnect);
            //tabControlMain.TabPages.Remove(tabPageSession);
            //tabControlMain.TabPages.Remove(tabPageCharacter);
            tabControlMain.TabPages.Add(tabPagePlay);
            tabControlMain.SelectTab(tabPagePlay);
            m_sessionRunning = true;
        }

        private void tabControlMain_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPageSession)
            {
                textBoxSessionName.Enabled = !m_sessionRunning;
                trackBarMinPlayers.Enabled = !m_sessionRunning;
                trackBarMaxPlayers.Enabled = !m_sessionRunning;
                trackBarCharQualitiesNum.Enabled = !m_sessionRunning;
                trackBarStatsPoints.Enabled = !m_sessionRunning;
            }
            else if (e.TabPage == tabPageCharacter)
            {
                fantasyGUI.LockUI(m_sessionRunning);
                buttonPlay.Enabled = !m_sessionRunning;
            }
        }

        private void trackBarStatsPoints_Scroll(object sender, EventArgs e)
        {
            SessionData.i_statsPoints = trackBarStatsPoints.Value;
        }

        private void trackBarCharQualitiesNum_Scroll(object sender, EventArgs e)
        {
            SessionData.i_qualitiesPoints = trackBarCharQualitiesNum.Value;
        }


    }
}