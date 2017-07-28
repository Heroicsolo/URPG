using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URPG_Client
{
    public partial class GamesForm : Form
    {
        private bool m_sessionRunning = false;
        private ClassicFantasy.GUI fantasyGUI;
        private Fallout.CharacterInterface falloutGUI;
        private RandEventForPlayer[] rngControls;
        private RNGCryptoServiceProvider RNG;
        private string mCurrentCharGame;

        public GamesForm()
        {
            InitializeComponent();
            gamesListBox.SelectedIndex = 0;
            sessionsListBox.SelectedIndex = 0;
            mCurrentCharGame = (string)gamesListBox.SelectedItem;

            fantasyGUI = new ClassicFantasy.GUI(this);
            falloutGUI = new Fallout.CharacterInterface();
            NetworkUtils.Init();
            RNG = new RNGCryptoServiceProvider();
            RemoveNextTabs();
            SessionData.Init();
            rngControls = new RandEventForPlayer[SessionData.i_currentPlayers];
        }

        private void InitRandEventsTab()
        {
            rngControls = new RandEventForPlayer[SessionData.i_currentPlayers];
            for (int i = 0; i < SessionData.i_currentPlayers; i++)
            {
                rngControls[i] = new RandEventForPlayer();
                rngControls[i].SetBounds(40, 100 + i * 60, 300, 60);
            }
            tabPageRandGen.Controls.AddRange(rngControls);
        }

        private void RemoveNextTabs()
        {
            int i_currentTab = tabControlMain.SelectedIndex;
            for (int i = tabControlMain.TabPages.Count - 2; i > i_currentTab; i--)
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
            string currentCharGame = (string)gamesListBox.SelectedItem;

            if (mCurrentCharGame != currentCharGame)
            {
                tabPageCharacter.Controls.Clear();
                tabControlMain.TabPages.Remove(tabPageCharacter);
            }

            tabControlMain.TabPages.Add(tabPageCharacter);
            tabControlMain.SelectTab(tabPageCharacter);

            if (currentCharGame == "Classic fantasy")
            {
                fantasyGUI.TryAddToParent(tabPageCharacter);
            }
            else if (currentCharGame == "Fallout")
            {
                tabPageCharacter.Controls.Add(falloutGUI);
            }

            mCurrentCharGame = (string)gamesListBox.SelectedItem;
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

            if ((string)gamesListBox.SelectedItem == "Classic fantasy")
            {
                fantasyGUI.TryAddToParent(tabPageCharacter);
            }
            else if ((string)gamesListBox.SelectedItem == "Fallout")
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
            else if (e.TabPage == tabPageRandGen)
            {
                if (rngControls.Length > 0)
                    tabPageRandGen.Controls.Cast<Control>().ToList().RemoveAll(i => rngControls.Contains(i));
                InitRandEventsTab();
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

        private void buttonGenerateRNG_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SessionData.i_currentPlayers; i++)
            {
                rngControls[i].RefreshState();
                rngControls[i].Invalidate();
            }
        }


    }
}