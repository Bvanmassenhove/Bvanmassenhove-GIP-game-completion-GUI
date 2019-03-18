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
    public partial class Startform : Form
    {
        public Startform()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            formLogin formLogin = new formLogin();

            Hide();
            formLogin.ShowDialog();
            Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            formNewAccount formNewAccount= new formNewAccount();

            Hide();
            formNewAccount.ShowDialog();
            Show();
        }
    }
}
