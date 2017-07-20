using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URPG_Client
{
    [Serializable]
    static class SessionData
    {
        private const int STATS_POINTS_DEFAULT = 20;
        private const int QUALITIES_MAX_DEFAULT = 2;

        public static int i_statsPoints;
        public static int i_qualitiesPoints;
        public static int i_minPlayers;
        public static int i_maxPlayers;
        public static string s_name;
        public static string s_gameType;

        public static void Init()
        {
            i_statsPoints = STATS_POINTS_DEFAULT;
            i_qualitiesPoints = QUALITIES_MAX_DEFAULT;
            s_name = "MySession";
            i_minPlayers = 1;
            i_maxPlayers = 4;
            s_gameType = "ClassicFantasy";
        }
    }
}
