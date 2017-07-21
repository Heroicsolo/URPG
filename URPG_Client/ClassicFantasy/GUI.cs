using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URPG_Client.ClassicFantasy
{
    public partial class GUI : UserControl
    {
        private int m_checkedQualities = 0;
        private ClassicFantasy.Mechanics.PlayerStats p_stats;
        private GamesForm p_parent;
        private bool m_initialized = false;
        private bool m_addedToParent = false;

        public GUI(GamesForm parent)
        {
            p_parent = parent;
            InitializeComponent();
            ClassicFantasy.Mechanics.PlayerData.Init();
            p_stats = ClassicFantasy.Mechanics.PlayerData.GetStats();
            m_initialized = true;
        }

        public bool IsInitialized()
        {
            return m_initialized;
        }

        public void TryAddToParent(Control parent)
        {
            if (!m_addedToParent)
            {
                parent.Controls.Add(this);
                m_addedToParent = true;
            }
        }

        public void LockUI(bool b_lock)
        {
            trackBarAgility.Enabled = !b_lock;
            trackBarIntelligence.Enabled = !b_lock;
            trackBarStamina.Enabled = !b_lock;
            trackBarStrength.Enabled = !b_lock;
            checkBoxAmbidextry.Enabled = !b_lock;
            checkBoxArcane.Enabled = !b_lock;
            checkBoxCrit.Enabled = !b_lock;
            checkBoxDodginess.Enabled = !b_lock;
            checkBoxPoisonResist.Enabled = !b_lock;
            checkBoxRegen.Enabled = !b_lock;
            checkBoxWeaponMaster.Enabled = !b_lock;
        }

        private bool IsPrimaryStatsFilled()
        {
            return trackBarStrength.Value + trackBarAgility.Value + trackBarIntelligence.Value + trackBarStamina.Value >= SessionData.i_statsPoints;
        }

        public void trackBarStrength_Scroll(object sender, EventArgs e)
        {
            if (IsPrimaryStatsFilled())
                trackBarStrength.Value = SessionData.i_statsPoints - (trackBarAgility.Value + trackBarIntelligence.Value + trackBarStamina.Value);
            p_stats.m_strength = (uint)trackBarStrength.Value;
            labelStr.Text = trackBarStrength.Value.ToString();
            RefreshCharacterInfo();
        }

        private void trackBarAgility_Scroll(object sender, EventArgs e)
        {
            if (IsPrimaryStatsFilled())
                trackBarAgility.Value = SessionData.i_statsPoints - (trackBarStrength.Value + trackBarIntelligence.Value + trackBarStamina.Value);
            p_stats.m_agility = (uint)trackBarAgility.Value;
            labelAgi.Text = trackBarAgility.Value.ToString();
            RefreshCharacterInfo();
        }

        private void trackBarIntelligence_Scroll(object sender, EventArgs e)
        {
            if (IsPrimaryStatsFilled())
                trackBarIntelligence.Value = SessionData.i_statsPoints - (trackBarAgility.Value + trackBarStrength.Value + trackBarStamina.Value);
            p_stats.m_intelligence = (uint)trackBarIntelligence.Value;
            labelInt.Text = trackBarIntelligence.Value.ToString();
            RefreshCharacterInfo();
        }

        private void trackBarStamina_Scroll(object sender, EventArgs e)
        {
            if (IsPrimaryStatsFilled())
                trackBarStamina.Value = SessionData.i_statsPoints - (trackBarAgility.Value + trackBarIntelligence.Value + trackBarStrength.Value);
            p_stats.m_stamina = (uint)trackBarStamina.Value;
            labelSta.Text = trackBarStamina.Value.ToString();
            RefreshCharacterInfo();
        }

        private void RefreshCharacterInfo()
        {
            ClassicFantasy.Mechanics.PlayerData.CalculateStats();
            labelInfo.Text = "HP: " +
                p_stats.m_HP_max + "\nMP: " +
                p_stats.m_MP_max +
                "\nEP: " + p_stats.m_EP_max +
                "\nDODGE: " + (100 * p_stats.m_dodgeChance) +
                "%\nARMOR: " + (100 * p_stats.m_armor) + "%";

            if (m_checkedQualities + trackBarStamina.Value + trackBarAgility.Value + trackBarIntelligence.Value + trackBarStrength.Value >= SessionData.i_statsPoints + SessionData.i_qualitiesPoints)
            {
                p_parent.buttonPlay.Enabled = true;
            }
            else
            {
                p_parent.buttonPlay.Enabled = false;
            }
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
                p_stats.m_poisonResist = true;
                m_checkedQualities++;
            }
            else if (!checkBoxPoisonResist.Checked)
            {
                p_stats.m_poisonResist = false;
                m_checkedQualities--;
            }
            CheckCheckboxes();
        }

        private void checkBoxAmbidextry_CheckedChanged(object sender, EventArgs e)
        {
            if (m_checkedQualities < SessionData.i_qualitiesPoints && checkBoxAmbidextry.Checked)
            {
                p_stats.m_ambidextry = true;
                m_checkedQualities++;
            }
            else if (!checkBoxAmbidextry.Checked)
            {
                p_stats.m_ambidextry = false;
                m_checkedQualities--;
            }
            CheckCheckboxes();
        }

        private void checkBoxCrit_CheckedChanged(object sender, EventArgs e)
        {
            if (m_checkedQualities < SessionData.i_qualitiesPoints && checkBoxCrit.Checked)
            {
                p_stats.m_criticalStrikes = true;
                m_checkedQualities++;
            }
            else if (!checkBoxCrit.Checked)
            {
                p_stats.m_criticalStrikes = false;
                m_checkedQualities--;
            }
            CheckCheckboxes();
        }

        private void checkBoxRegen_CheckedChanged(object sender, EventArgs e)
        {
            if (m_checkedQualities < SessionData.i_qualitiesPoints && checkBoxRegen.Checked)
            {
                p_stats.m_regen = true;
                m_checkedQualities++;
            }
            else if (!checkBoxRegen.Checked)
            {
                p_stats.m_regen = false;
                m_checkedQualities--;
            }
            CheckCheckboxes();
        }

        private void checkBoxArcane_CheckedChanged(object sender, EventArgs e)
        {
            if (m_checkedQualities < SessionData.i_qualitiesPoints && checkBoxArcane.Checked)
            {
                p_stats.m_arcaneIntelligence = true;
                m_checkedQualities++;
            }
            else if (!checkBoxArcane.Checked)
            {
                p_stats.m_arcaneIntelligence = false;
                m_checkedQualities--;
            }
            CheckCheckboxes();
        }

        private void checkBoxDodginess_CheckedChanged(object sender, EventArgs e)
        {
            if (m_checkedQualities < SessionData.i_qualitiesPoints && checkBoxDodginess.Checked)
            {
                p_stats.m_dodginess = true;
                m_checkedQualities++;
            }
            else if (!checkBoxDodginess.Checked)
            {
                p_stats.m_dodginess = false;
                m_checkedQualities--;
            }
            CheckCheckboxes();
        }

        private void checkBoxWeaponMaster_CheckedChanged(object sender, EventArgs e)
        {
            if (m_checkedQualities < SessionData.i_qualitiesPoints && checkBoxWeaponMaster.Checked)
            {
                p_stats.m_weaponMaster = true;
                m_checkedQualities++;
            }
            else if (!checkBoxWeaponMaster.Checked)
            {
                p_stats.m_weaponMaster = false;
                m_checkedQualities--;
            }
            CheckCheckboxes();
        }
    }
}
