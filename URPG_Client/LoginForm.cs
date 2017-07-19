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
    public partial class LoginForm : Form
    {
        private CharacterForm m_parentForm;

        public LoginForm(CharacterForm parentForm)
        {
            m_parentForm = parentForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (m_parentForm.Connect(textBoxServerIP.Text, textBoxLogin.Text, textBoxPassword.Text))
            {
                MessageBox.Show("Connected!");
                Close();
            }
            else
            {
                MessageBox.Show("Connection failed!");
            }
        }
    }
}
