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
    public partial class CharacterForm : Form
    {
        private int m_checkedQualities = 0;

        public CharacterForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool IsPrimaryStatsFilled()
        {
            return trackBarStrength.Value + trackBarAgility.Value + trackBarIntelligence.Value + trackBarStamina.Value >= SessionData.i_statsPoints;
        }

        private void trackBarStrength_Scroll(object sender, EventArgs e)
        {
            if (IsPrimaryStatsFilled())
                trackBarStrength.Value = SessionData.i_statsPoints - (trackBarAgility.Value + trackBarIntelligence.Value + trackBarStamina.Value);
            NetworkUtils.GetCharacterStats().m_strength = (uint)trackBarStrength.Value;
            labelStr.Text = trackBarStrength.Value.ToString();
            RefreshCharacterInfo();
        }

        private void trackBarAgility_Scroll(object sender, EventArgs e)
        {
            if (IsPrimaryStatsFilled())
                trackBarAgility.Value = SessionData.i_statsPoints - (trackBarStrength.Value + trackBarIntelligence.Value + trackBarStamina.Value);
            NetworkUtils.GetCharacterStats().m_agility = (uint)trackBarAgility.Value;
            labelAgi.Text = trackBarAgility.Value.ToString();
            RefreshCharacterInfo();
        }

        private void trackBarIntelligence_Scroll(object sender, EventArgs e)
        {
            if (IsPrimaryStatsFilled())
                trackBarIntelligence.Value = SessionData.i_statsPoints - (trackBarAgility.Value + trackBarStrength.Value + trackBarStamina.Value);
            NetworkUtils.GetCharacterStats().m_intelligence = (uint)trackBarIntelligence.Value;
            labelInt.Text = trackBarIntelligence.Value.ToString();
            RefreshCharacterInfo();
        }

        private void trackBarStamina_Scroll(object sender, EventArgs e)
        {
            if (IsPrimaryStatsFilled())
                trackBarStamina.Value = SessionData.i_statsPoints - (trackBarAgility.Value + trackBarIntelligence.Value + trackBarStrength.Value);
            NetworkUtils.GetCharacterStats().m_stamina = (uint)trackBarStamina.Value;
            labelSta.Text = trackBarStamina.Value.ToString();
            RefreshCharacterInfo();
        }

        private void RefreshCharacterInfo()
        {
            PlayerStats pStats = NetworkUtils.GetCharacterStats();

            NetworkUtils.m_pData.CalculateStats();
            labelInfo.Text = "HP: " +
                pStats.m_HP_max + "\nMP: " +
                pStats.m_MP_max +
                "\nEP: " + pStats.m_EP_max +
                "\nDODGE: " + (100 * pStats.m_dodgeChance) +
                "%\nARMOR: " + (100 * pStats.m_armor) + "%";
        }

        private void CheckCheckboxes()
        {
            if (m_checkedQualities >= SessionData.i_qualitiesPoints)
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
            if (m_checkedQualities < SessionData.i_qualitiesPoints && checkBoxPoisonResist.Checked)
            {
                NetworkUtils.GetCharacterStats().m_poisonResist = true;
                m_checkedQualities++;
            }
            else if (!checkBoxPoisonResist.Checked)
            {
                NetworkUtils.GetCharacterStats().m_poisonResist = false;
                m_checkedQualities--;
            }
            CheckCheckboxes();
        }

        private void checkBoxAmbidextry_CheckedChanged(object sender, EventArgs e)
        {
            if (m_checkedQualities < SessionData.i_qualitiesPoints && checkBoxAmbidextry.Checked)
            {
                NetworkUtils.GetCharacterStats().m_ambidextry = true;
                m_checkedQualities++;
            }
            else if (!checkBoxAmbidextry.Checked)
            {
                NetworkUtils.GetCharacterStats().m_ambidextry = false;
                m_checkedQualities--;
            }
            CheckCheckboxes();
        }

        private void checkBoxCrit_CheckedChanged(object sender, EventArgs e)
        {
            if (m_checkedQualities < SessionData.i_qualitiesPoints && checkBoxCrit.Checked)
            {
                NetworkUtils.GetCharacterStats().m_criticalStrikes = true;
                m_checkedQualities++;
            }
            else if (!checkBoxCrit.Checked)
            {
                NetworkUtils.GetCharacterStats().m_criticalStrikes = false;
                m_checkedQualities--;
            }
            CheckCheckboxes();
        }

        private void checkBoxRegen_CheckedChanged(object sender, EventArgs e)
        {
            if (m_checkedQualities < SessionData.i_qualitiesPoints && checkBoxRegen.Checked)
            {
                NetworkUtils.GetCharacterStats().m_regen = true;
                m_checkedQualities++;
            }
            else if (!checkBoxRegen.Checked)
            {
                NetworkUtils.GetCharacterStats().m_regen = false;
                m_checkedQualities--;
            }
            CheckCheckboxes();
        }

        private void checkBoxArcane_CheckedChanged(object sender, EventArgs e)
        {
            if (m_checkedQualities < SessionData.i_qualitiesPoints && checkBoxArcane.Checked)
            {
                NetworkUtils.GetCharacterStats().m_arcaneIntelligence = true;
                m_checkedQualities++;
            }
            else if (!checkBoxArcane.Checked)
            {
                NetworkUtils.GetCharacterStats().m_arcaneIntelligence = false;
                m_checkedQualities--;
            }
            CheckCheckboxes();
        }

        private void checkBoxDodginess_CheckedChanged(object sender, EventArgs e)
        {
            if (m_checkedQualities < SessionData.i_qualitiesPoints && checkBoxDodginess.Checked)
            {
                NetworkUtils.GetCharacterStats().m_dodginess = true;
                m_checkedQualities++;
            }
            else if (!checkBoxDodginess.Checked)
            {
                NetworkUtils.GetCharacterStats().m_dodginess = false;
                m_checkedQualities--;
            }
            CheckCheckboxes();
        }

        private void checkBoxWeaponMaster_CheckedChanged(object sender, EventArgs e)
        {
            if (m_checkedQualities < SessionData.i_qualitiesPoints && checkBoxWeaponMaster.Checked)
            {
                NetworkUtils.GetCharacterStats().m_weaponMaster = true;
                m_checkedQualities++;
            }
            else if (!checkBoxWeaponMaster.Checked)
            {
                NetworkUtils.GetCharacterStats().m_weaponMaster = false;
                m_checkedQualities--;
            }
            CheckCheckboxes();
        }
    }
}
