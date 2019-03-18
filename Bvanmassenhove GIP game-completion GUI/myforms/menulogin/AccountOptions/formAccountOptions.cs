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
    public partial class formAccountOptions : Form
    {
        public formAccountOptions()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            formDelete formDelete = new formDelete();

            Hide();
            formDelete.ShowDialog();
            Show();
        }

        private void btnChangeUsername_Click(object sender, EventArgs e)
        {
            formChangeName formChangeName = new formChangeName();

            Hide();
            formChangeName.ShowDialog();
            Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            formChangePassword formChangePassword = new formChangePassword();

            Hide();
            formChangePassword.ShowDialog();
            Show();
        }
    }
}
