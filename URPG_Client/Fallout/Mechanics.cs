using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace URPG_Client.Fallout
{
    static class Mechanics
    {
        public struct FalloutAbilityStats
        {
            public string m_name;
            public uint m_skillPointsCost;
        }

        [Serializable]
        public class PlayerStats
        {
            public uint m_strength;
            public uint m_agility;
            public uint m_intelligence;
            public uint m_stamina;

            public uint m_HP;
            public uint m_HP_max;

            public List<FalloutAbilityStats> m_abilities;
        }

        public static class PlayerData
        {
            //public void NextTurn();

            //public bool GetDamage(uint damage, bool avoidable = true);

            public static void Init()
            {
                m_stats = new PlayerStats();
            }

            public static void SetStats(PlayerStats stats)
            {
                m_stats = stats;
            }

            public static PlayerStats GetStats()
            {
                return m_stats;
            }

            public static void CalculateStats()
            {
              
            }

            public static void Deserialize(byte[] data)
            {
                IFormatter formatter = new BinaryFormatter();
                MemoryStream stream = new MemoryStream(data);
                m_stats = formatter.Deserialize(stream) as PlayerStats;
                stream.Close();
            }

            public static void Serialize()
            {
                IFormatter formatter = new BinaryFormatter();
                MemoryStream stream = new MemoryStream();
                formatter.Serialize(stream, m_stats);

                NetworkUtils.SendMessage(stream.ToArray());

                stream.Close();
            }

            static PlayerStats m_stats;
        }
    }
}
