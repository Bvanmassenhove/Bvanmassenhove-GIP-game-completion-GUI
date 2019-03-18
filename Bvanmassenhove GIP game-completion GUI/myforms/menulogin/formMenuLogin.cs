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
    public partial class formMenuLogin : Form
    {
        public formMenuLogin()
        {
            InitializeComponent();
        }

        private void btnShowGames_Click(object sender, EventArgs e)
        {
            formShowGames showGames = new formShowGames();
            Hide();
            showGames.ShowDialog();
            Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGameOptions_Click(object sender, EventArgs e)
        {
            formGameOptions formGameOptions = new formGameOptions();

            Hide();
            formGameOptions.ShowDialog();
            Show();
        }

        private void btnAccountOptions_Click(object sender, EventArgs e)
        {
            formAccountOptions formAccountOptions= new formAccountOptions();

            Hide();
            formAccountOptions.ShowDialog();
            Show();
        }
    }
}
