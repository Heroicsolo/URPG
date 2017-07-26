using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace URPG_Client
{
    public partial class RandEventForPlayer : UserControl
    {
        private float eventChance = 0.5f;
        private RNGCryptoServiceProvider RNG;

        public RandEventForPlayer()
        {
            InitializeComponent();
            RNG = new RNGCryptoServiceProvider();
            byte[] rngNumber = new byte[1];
            RNG.GetBytes(rngNumber);
        }

        private void textBoxEventChanceP1_TextChanged(object sender, EventArgs e)
        {
            eventChance = Convert.ToInt32(textBoxEventChanceP1.Text) / 100.0f;
        }

        public void RefreshState()
        {
            byte[] rngNumber = new byte[1];
            RNG.GetBytes(rngNumber);
            float normalizedRandNum = rngNumber[0] / 255.0f;
            labelRandEventResultP1.Text = normalizedRandNum > eventChance ? "success" : "fail";
        }
    }
}
