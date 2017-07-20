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
        public GamesForm()
        {
            InitializeComponent();
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
            tabControlMain.SelectTab(1);
            if (gamesListBox.SelectedItem == "Classic fantasy")
            {
                ClassicFantasy.GUI fantasyGUI = new ClassicFantasy.GUI();
                tabPageCharacter.Controls.Add(fantasyGUI);
            }
            else if (gamesListBox.SelectedItem == "Fallout")
            {
                //some Fallout stuff
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            tabControlMain.TabPages.Add(tabPageSession);
            tabControlMain.SelectTab(1);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectTab(0);
            RemoveNextTabs();
        }

        private void buttonLaunchSession_Click(object sender, EventArgs e)
        {
            tabControlMain.TabPages.Add(tabPageCharacter);
            tabControlMain.SelectTab(2);
            if (gamesListBox.SelectedItem == "Classic fantasy")
            {
                ClassicFantasy.GUI fantasyGUI = new ClassicFantasy.GUI();
                tabPageCharacter.Controls.Add(fantasyGUI);
            }
            else if (gamesListBox.SelectedItem == "Fallout")
            {
                //some Fallout stuff
            }
        }

        private void trackBarStrength_Scroll(object sender, EventArgs e)
        {

        }
    }
}