using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FinalGame
{
    public partial class GameWindow : Form
    {
        int enemy_action_points = 3, enemy_mana = 0, enemy_hp = 15, damage_for_enemy = 0;//параметры врага
        int enemy_damage_modifier = 0;//переменная модификатора урона на враге, используется при пробитии брони
        int player_action_points = 3, player_hp = 15, player_mana = 0, damage_for_player = 0;//параметры игрока
        int player_damage_modifier = 0;//переменная модификатора урона на пресонаже, используется при пробитии брони
        bool player_effect_mana_weakness = false;//эффект мана-слабости на игроке
        void standart_attack_show()
        {
            show_enemy_hp.Text = enemy_hp.ToString();
            show_player_hp.Text = player_hp.ToString();
            show_player_points.Text = player_action_points.ToString();
            show_player_mana.Text = player_mana.ToString();
        }
        public GameWindow()
        {
            InitializeComponent();
            show_player_hp.Text = player_hp.ToString();
            show_player_points.Text = player_action_points.ToString();
            show_player_mana.Text = player_mana.ToString();
            show_enemy_hp.Text = enemy_hp.ToString();
            show_enemy_actpoints.Text = enemy_action_points.ToString();
            show_enemy_mana.Text = enemy_mana.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void end_of_turn_button_Click(object sender, EventArgs e)
        {
            potato_player_image.Visible = false;
            static_player_image.Visible = true;
            headattack_player_sprite.Visible = false;
            player_action_points = 3;
        }

        private void be_like_potato_botton_Click(object sender, EventArgs e)
        {
            potato_player_image.Visible = true;
            static_player_image.Visible = false;
            headattack_player_sprite.Visible = false;
        }

        private void head_attack_botton_Click(object sender, EventArgs e)
        {
            potato_player_image.Visible = false;
            static_player_image.Visible = false;
            headattack_player_sprite.Visible = true;
            if (player_action_points > 0){
                    if (player_mana > 0){//достаточно ли к игрока маны
                        --player_action_points;
                        enemy_hp = enemy_hp - enemy_damage_modifier - player_mana;
                        event_box.Text = ("Вы изо всех сил бьете врага,\r\nне очень умно, но эффективно(отдача 1 урона),\r\n" + 
                        "здоровье врага -"+player_mana+",\r\nваша мана ушла на атаку");
                        player_mana = 0;
                        player_hp -= 1 + player_damage_modifier;
                        standart_attack_show();
                    }
                    else{
                    event_box.Text = ("Вы решаете не бить врага," + "\r\n" + "поскольку у вас нет маны");
                    }
            }
            else{
                event_box.Text = ("Собираясь ударить головой врага,"+ "\r\n" + "вы замечаете что вам не хватает очков действия");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void headattack_player_sprite_Click(object sender, EventArgs e)
        {

        }

        private void potato_player_image_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void act_Click(object sender, EventArgs e)
        {
            back_buttom.Visible = true;
            mana_button.Visible = true;
            watch_on_enemy_button.Visible = true;
            head_attack_botton.Visible = false;
            be_like_potato_botton.Visible = false;
            mockery_bottom.Visible = false;
        }

        private void mockery_bottom_Click(object sender, EventArgs e)
        {
            if (player_action_points > 0){
                if (player_mana >= 3){
                    int temp_damage = enemy_hp - 1 - enemy_damage_modifier;
                    enemy_hp = enemy_hp - 1 - enemy_damage_modifier;
                    enemy_damage_modifier = 2;
                    player_mana -= 3;
                    --player_action_points;
                    event_box.Text = ("Вы насмехаетесь над тем как враг выглядит,\r\nкажется он негодует." +
                        "\r\nЗдоровье врага -"+temp_damage);
                    standart_attack_show();
                }
                else
                {
                    event_box.Text = ("вы тщетно пытаетесь насмеятся над врагом, поскольку вам не хватает маны");
                }
            }
            else
            {
                event_box.Text = ("Отсутствие очков действий,\r\n(надеюсь только их...)\r\nмешает вам насмехнуться над врагом");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            back_buttom.Visible = true;
            head_attack_botton.Visible = true;
            be_like_potato_botton.Visible = true;
            mockery_bottom.Visible = true;
            mana_button.Visible = false;
            watch_on_enemy_button.Visible = false;
        }

        private void back_buttom_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            static_player_image.Visible = true;
            back_buttom.Visible = false;
            head_attack_botton.Visible = false;
            be_like_potato_botton.Visible = false;
            mockery_bottom.Visible = false;
            mana_button.Visible = false;
            watch_on_enemy_button.Visible = false;
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {

        }

        private void mana_button_Click(object sender, EventArgs e)
        {
            if (player_action_points > 0)
            {
                if (player_effect_mana_weakness == false)
                {
                    Random rnd = new Random();
                    int temp_mana = rnd.Next(1, 4);
                    player_mana += temp_mana;
                    show_player_mana.Text = player_mana.ToString();
                    --player_action_points;
                    show_player_points.Text = player_action_points.ToString();
                    event_box.Text = ("Вы решаете ударить дерево для получения маны" + "\r\n" + "Игрок получает ессенции маны: " + temp_mana + "\r\n"+"Очки действия уменьшились на 1!");
                }
                else
                {
                    Random rnd = new Random();
                    int temp_mana = rnd.Next(1, 3);
                    player_mana += temp_mana;
                    show_player_mana.Text = player_mana.ToString();
                    --player_action_points;
                    show_player_points.Text = player_action_points.ToString();
                    event_box.Text = ("Вы СЛАБО бьёте дерево для получения маны" + "\r\n" + "Игрок получает ессенции маны: " + temp_mana + "\r\n" + "Очки действия уменьшились на 1!");
                }
                
            }
            else
            {
                mana_button.Location= new Point(mana_button.Location.X +5, mana_button.Location.Y);
                Thread.Sleep(50);
                mana_button.Location = new Point(mana_button.Location.X -10, mana_button.Location.Y);
                Thread.Sleep(50);
                mana_button.Location = new Point(mana_button.Location.X +5, mana_button.Location.Y);
            }
        }
    }
}
