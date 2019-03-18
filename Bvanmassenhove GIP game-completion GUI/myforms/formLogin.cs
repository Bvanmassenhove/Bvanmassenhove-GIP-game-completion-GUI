using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bvanmassenhove_GIP_game_completion_GUI
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            formMenuLogin formMenuLogin= new formMenuLogin();

            //login controleren voor het inloggen

            Hide();
            formMenuLogin.ShowDialog();
            Show();
        }
    }
}
