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
    public partial class Settings : Form
    {
        bool cheat_mode = false;
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show_text.Text = ("Видимо есть\n\r \n\rРежим читов включен!!!");
            show_text.ForeColor= Color.FromArgb(255, 255, 255, 0);
            backtomenu_button.ForeColor = Color.FromArgb(255, 255, 255, 0);
            cheat_mode = true;
        }

        private void backtomenu_button_Click(object sender, EventArgs e)
        {
            Menu f = new Menu(cheat_mode);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
