using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace URPG_Client
{
    struct AbilityStats
    {
        public string m_name;

        public uint m_avoidableDamage;
        public uint m_unavoidableDamage;
        public uint m_MP_burn;
        public uint m_EP_burn;

        public uint m_MP_cost;
        public uint m_EP_cost;
        public uint m_HP_cost;

        public uint m_dot_length;
        public uint m_dot_tick_damage;

        public uint m_stun_length;

        public bool m_massive;

        public uint m_reqInt;
        public uint m_reqStr;
        public uint m_reqAgi;

        public uint m_skillPointsCost;
    }

    [Serializable]
    class PlayerStats
    {
        public uint m_level;

        public uint m_strength;
        public uint m_agility;
        public uint m_intelligence;
        public uint m_stamina;

        public float m_dodgeChance;
        public float m_armor;
        public float m_damageModifier;

        public uint m_attackLeft;
        public uint m_attackRight;

        public uint m_attackCostLeft;
        public uint m_attackCostRight;

        public uint m_MP;
        public uint m_EP;
        public uint m_HP;
        public uint m_MP_max;
        public uint m_EP_max;
        public uint m_HP_max;

        public bool m_regen;
        public bool m_ambidextry;
        public bool m_poisonResist;
        public bool m_criticalStrikes;
        public bool m_arcaneIntelligence;
        public bool m_weaponMaster;
        public bool m_dodginess;

        public uint m_leftHandWeapon;
        public uint m_rightHandWeapon;

        public List<AbilityStats> m_abilities;
    }

    class PlayerData
    {
        //public void NextTurn();

        //public bool GetDamage(uint damage, bool avoidable = true);

        public PlayerData()
        {
            m_stats = new PlayerStats();
        }

        public PlayerStats GetStats()
        {
            return m_stats;
        }

        public void SetStats(PlayerStats stats)
        {
            m_stats = stats;
        }

        public void CalculateStats()
        {
            m_stats.m_HP_max = 100 + 10 * m_stats.m_stamina;
            m_stats.m_MP_max = (uint)Math.Round(10 * Math.Sqrt(m_stats.m_intelligence));
            m_stats.m_armor = (float)Math.Round(0.9f * m_stats.m_strength/20, 2);
            m_stats.m_dodgeChance = (float)Math.Round(0.15f * (m_stats.m_dodginess ? 1.2f : 1.0f) * (float)Math.Sqrt(m_stats.m_agility), 2);
            m_stats.m_EP_max = 10 + 5 * m_stats.m_stamina;
        }

        private PlayerStats m_stats;
        
    }
}
