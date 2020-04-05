using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalGame
{

    public partial class Menu : Form
    {
        bool cheat_mode=false;
        public Menu(bool cheats)
        {
            InitializeComponent();
            cheat_mode = cheats;
            if (cheats)
            {
                start_game_button.ForeColor = Color.FromArgb(255, 255, 255, 0);
                settings_button.ForeColor = Color.FromArgb(255, 255, 255, 0);
                exit_button.ForeColor = Color.FromArgb(255, 255, 255, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameWindow f = new GameWindow(cheat_mode);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings f = new Settings();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
