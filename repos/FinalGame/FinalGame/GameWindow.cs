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
            show_player_hp.Text = player_hp.ToString();
            show_player_points.Text = player_action_points.ToString();
            show_player_mana.Text = player_mana.ToString();
            show_enemy_hp.Text = enemy_hp.ToString();
            show_enemy_actpoints.Text = enemy_action_points.ToString();
            show_enemy_mana.Text = enemy_mana.ToString();
        }
        void thinking_points_show()//красивая загрузочка
        {
            event_box.Text = (".");
            //Thread.Sleep(1000); - ВОТ ЗДЕСЬ ЗАДЕРЖКА
            event_box.Text = (". .");
            //Thread.Sleep(1000);- ВОТ ЗДЕСЬ ЗАДЕРЖКА
            event_box.Text = (". . .");
            //Thread.Sleep(1000);- ВОТ ЗДЕСЬ ЗАДЕРЖКА
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
        private void end_of_turn_button_Click(object sender, EventArgs e)
        {
            potato_player_image.Visible = false;
            static_player_image.Visible = true;
            headattack_player_sprite.Visible = false;
            player_action_points = 3;
            player_effect_mana_weakness = false;
            enemy_action_points = 3;
            while (enemy_action_points > 0)
            {//начало хода врага
                thinking_points_show();
                if (enemy_mana >= 6)
                {//использование атаки строгое замечание
                    enemy_mana -= 6;
                    damage_for_player = player_damage_modifier + 4;
                    player_hp -= damage_for_player;
                    --enemy_action_points;
                    player_effect_mana_weakness = true;
                    event_box.Text = ("Враг использует строгое замечание:\r\nЕросер: \"Ты выглядишь неряшливо\";" +
                        "\r\nМана Эросера теперь равна " + enemy_mana+
                        "Вы оскарблены до глубины души\r\nОчки здоровья -4 и вы получаете мана-слабость");
                    //Thread.Sleep(5000);- ВОТ ЗДЕСЬ ЗАДЕРЖКА
                    standart_attack_show();
                }
                else if (enemy_mana >= 5 && player_mana > 0)
                {//враг использует ластик
                    --enemy_action_points;
                    enemy_mana -= 5;
                    player_mana = 0;
                    event_box.Text = ("Враг кидает в вас ластик\r\nВаша мана обнулилась(какаким образом это работает?)");
                    //Thread.Sleep(5000);- ВОТ ЗДЕСЬ ЗАДЕРЖКА
                    standart_attack_show();
                }
                else
                {//враг получает ману
                    Random rnd = new Random();
                    int temp_mana = rnd.Next(1, 4);
                    enemy_mana += temp_mana;
                    --enemy_action_points;
                    event_box.Text = ("Враг впитывает ману из воздуха\nМана Эросера теперь равна " + enemy_mana);
                    //Thread.Sleep(5000);- ВОТ ЗДЕСЬ ЗАДЕРЖКА
                    standart_attack_show();
                }
            }
            player_damage_modifier = 0;
            enemy_damage_modifier = 0;
            standart_attack_show();
        }

        private void be_like_potato_button_Click(object sender, EventArgs e)
        {
            potato_player_image.Visible = true;
            static_player_image.Visible = false;
            headattack_player_sprite.Visible = false;
            if (player_action_points > 0)
            {
                if (player_mana >= 2)
                {
                    player_action_points -= 1;
                    player_damage_modifier = -2;
                    player_mana -= 2;
                    event_box.Text = ("Вы садитесь и закрываете глаза," + "\r\n" + "входящий урон уменьшен на 2");
                    standart_attack_show();
                }
                else
                {
                    event_box.Text = ("Для того чтобы выглядеть как картошка," + "\r\n" + "вам нужно 2 маны");
                    be_like_potato_button.Location = new Point(be_like_potato_button.Location.X + 5, be_like_potato_button.Location.Y);
                    Thread.Sleep(50);//- ВОТ ЗДЕСЬ ЗАДЕРЖКА но оно работает
                    be_like_potato_button.Location = new Point(be_like_potato_button.Location.X - 10, be_like_potato_button.Location.Y);
                    Thread.Sleep(50);//- ВОТ ЗДЕСЬ ЗАДЕРЖКА но оно работает
                    be_like_potato_button.Location = new Point(be_like_potato_button.Location.X + 5, be_like_potato_button.Location.Y);
                }
            }
            else
            {
                event_box.Text = ("Вы хотите быть как картошка," + "\r\n" + "но вам не хватает очков действия");
                be_like_potato_button.Location = new Point(be_like_potato_button.Location.X + 5, be_like_potato_button.Location.Y);
                Thread.Sleep(50);//- ВОТ ЗДЕСЬ ЗАДЕРЖКА но оно работает
                be_like_potato_button.Location = new Point(be_like_potato_button.Location.X - 10, be_like_potato_button.Location.Y);
                Thread.Sleep(50);//- ВОТ ЗДЕСЬ ЗАДЕРЖКА но оно работает
                be_like_potato_button.Location = new Point(be_like_potato_button.Location.X + 5, be_like_potato_button.Location.Y);
            }
        }

        private void watch_on_enemy_button_Click(object sender, EventArgs e)
        {
            event_box.Text = ("Эросер - сбежавший астик неизвестного художника" +
                        "\r\nСпособность:\"Строгое замечание\" наносит 4 урона, эффект мана-слабости" +
                        "\r\nСпособность: \"Бросок ластика\" - обнуление маны врага");
        }

        private void head_attack_button_Click(object sender, EventArgs e)
        {
            potato_player_image.Visible = false;
            static_player_image.Visible = false;
            headattack_player_sprite.Visible = true;
            if (player_action_points > 0){
                    if (player_mana > 0){//достаточно ли к игрока маны
                        --player_action_points;
                        damage_for_enemy = enemy_damage_modifier + player_mana;
                        enemy_hp -= damage_for_enemy;
                        if (player_damage_modifier!=0) {
                            event_box.Text = ("Вы изо всех сил бьете врага,\r\nне очень умно, но эффективно,\r\n" +
                            "здоровье врага -" + player_mana + ",\r\nваша мана ушла на атаку");
                        }
                        else {
                            player_hp -= 1;
                            event_box.Text = ("Вы изо всех сил бьете врага,\r\nне очень умно, но эффективно(отдача 1 урона),\r\n" +
                            "здоровье врага -" + player_mana + ",\r\nваша мана ушла на атаку");
                        }
                        player_mana = 0;
                        standart_attack_show();
                    }
                    else{
                        event_box.Text = ("Вы решаете не бить врага," + "\r\n" + "поскольку у вас нет маны");
                        head_attack_button.Location = new Point(head_attack_button.Location.X + 5, head_attack_button.Location.Y);
                        Thread.Sleep(50);//- ВОТ ЗДЕСЬ ЗАДЕРЖКА но оно работает
                    head_attack_button.Location = new Point(head_attack_button.Location.X - 10, head_attack_button.Location.Y);
                        Thread.Sleep(50);//- ВОТ ЗДЕСЬ ЗАДЕРЖКА но оно работает
                    head_attack_button.Location = new Point(head_attack_button.Location.X + 5, head_attack_button.Location.Y);
                    }
            }
            else{
                event_box.Text = ("Собираясь ударить головой врага,"+ "\r\n" + "вы замечаете что вам не хватает очков действия");
                head_attack_button.Location = new Point(head_attack_button.Location.X + 5, head_attack_button.Location.Y);
                Thread.Sleep(50);//- ВОТ ЗДЕСЬ ЗАДЕРЖКА но оно работает
                head_attack_button.Location = new Point(head_attack_button.Location.X - 10, head_attack_button.Location.Y);
                Thread.Sleep(50);//- ВОТ ЗДЕСЬ ЗАДЕРЖКА но оно работает
                head_attack_button.Location = new Point(head_attack_button.Location.X + 5, head_attack_button.Location.Y);
            }
        }
        private void act_Click(object sender, EventArgs e)
        {
            back_button.Visible = true;
            mana_button.Visible = true;
            watch_on_enemy_button.Visible = true;
            head_attack_button.Visible = false;
            be_like_potato_button.Visible = false;
            mockery_button.Visible = false;
        }

        private void mockery_button_Click(object sender, EventArgs e)
        {
            if (player_action_points > 0){
                if (player_mana >= 3){
                    damage_for_enemy = 1 + enemy_damage_modifier;
                    enemy_hp -= damage_for_enemy;
                    enemy_damage_modifier = 2;
                    player_mana -= 3;
                    --player_action_points;
                    event_box.Text = ("Вы насмехаетесь над тем как враг выглядит,\r\nкажется он негодует." +
                        "\r\nЗдоровье врага -"+damage_for_enemy);
                    standart_attack_show();
                }
                else
                {
                    event_box.Text = ("вы тщетно пытаетесь насмеятся над врагом, поскольку вам не хватает маны");
                    mockery_button.Location = new Point(mockery_button.Location.X + 5, mockery_button.Location.Y);
                    Thread.Sleep(50);//- ВОТ ЗДЕСЬ ЗАДЕРЖКА но оно работает
                    mockery_button.Location = new Point(mockery_button.Location.X - 10, mockery_button.Location.Y);
                    Thread.Sleep(50);//- ВОТ ЗДЕСЬ ЗАДЕРЖКА но оно работает
                    mockery_button.Location = new Point(mockery_button.Location.X + 5, mockery_button.Location.Y);
                }
            }
            else
            {
                event_box.Text = ("Отсутствие очков действий,\r\n(надеюсь только их...)\r\nмешает вам насмехнуться над врагом");
                mockery_button.Location = new Point(mockery_button.Location.X + 5, mockery_button.Location.Y);
                Thread.Sleep(50);//- ВОТ ЗДЕСЬ ЗАДЕРЖКА но оно работает
                mockery_button.Location = new Point(mockery_button.Location.X - 10, mockery_button.Location.Y);
                Thread.Sleep(50);//- ВОТ ЗДЕСЬ ЗАДЕРЖКА но оно работает
                mockery_button.Location = new Point(mockery_button.Location.X + 5, mockery_button.Location.Y);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            back_button.Visible = true;
            head_attack_button.Visible = true;
            be_like_potato_button.Visible = true;
            mockery_button.Visible = true;
            mana_button.Visible = false;
            watch_on_enemy_button.Visible = false;
        }

        private void back_buttom_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            static_player_image.Visible = true;
            back_button.Visible = false;
            head_attack_button.Visible = false;
            be_like_potato_button.Visible = false;
            mockery_button.Visible = false;
            mana_button.Visible = false;
            watch_on_enemy_button.Visible = false;
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
                event_box.Text = ("Вам не доложили очков действий");
                mana_button.Location= new Point(mana_button.Location.X +5, mana_button.Location.Y);
                Thread.Sleep(50);//- ВОТ ЗДЕСЬ ЗАДЕРЖКА но оно работает
                mana_button.Location = new Point(mana_button.Location.X -10, mana_button.Location.Y);
                Thread.Sleep(50);//- ВОТ ЗДЕСЬ ЗАДЕРЖКА но оно работает
                mana_button.Location = new Point(mana_button.Location.X +5, mana_button.Location.Y);
            }
        }
    }
}
