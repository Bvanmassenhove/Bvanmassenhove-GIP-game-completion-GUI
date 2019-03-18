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
    public partial class formGameOptions : Form
    {
        public formGameOptions()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            formAddGame formAddGame = new formAddGame();

            Hide();
            formAddGame.ShowDialog();
            Show();
        }

        private void btnChangeGame_Click(object sender, EventArgs e)
        {
            formChangeGame formChangeGame = new formChangeGame();

            Hide();
            formChangeGame.ShowDialog();
            Show();
        }

        private void btnDeleteGame_Click(object sender, EventArgs e)
        {
            formDeleteGame formDeleteGame = new formDeleteGame();

            Hide();
            formDeleteGame.ShowDialog();
            Show();
        }
    }
}


