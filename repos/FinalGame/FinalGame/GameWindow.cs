using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FinalGame
{
    public partial class GameWindow : Form
    {
        bool cheat_mode = false;
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
        int end_of_battle(int player_hp, int enemy_hp)
        {
            if (player_hp <= 0)
            {
                MessageBox.Show("Вы проиграли\r\nСпасибо за тестирование","Конец демоверсии");
                return 1;
            }
            if (enemy_hp <= 0)
            {
                MessageBox.Show("Вы победили\r\nСпасибо за тестирование", "Конец демоверсии");
                return 2;
            }
                return 0;
        }
        async void thinking_points_show()//красивая загрузочка
        {
            await Task.Delay(600);
            event_box.Text = (".");
            await Task.Delay(600);
            event_box.Text = (". .");
            await Task.Delay(600);
            event_box.Text = (". . .");
            await Task.Delay(600);
        }
        async void enemy_mana_animation()
        {
            enemy_static_image.Visible = false;
            enemy_mana1_image.Visible = true;
            await Task.Delay(500);
            enemy_mana1_image.Visible = false;
            enemy_mana2_image.Visible = true;
            await Task.Delay(500);
            enemy_static_image.Visible = true;
            enemy_mana2_image.Visible = false;
        }
        async void player_mana_animation()
        {
            head_attack_player_image.Visible = false;
            static_player_image.Visible = false;
            mockery_player_image.Visible = false;
            potato_player_image.Visible = false;
            mana_player_image.Visible = true;
            await Task.Delay(500);
            mana_player_image.Visible = false;
            static_player_image.Visible = true;
        }
        public GameWindow(bool cheats)
        {
            InitializeComponent();
            potato_player_image.BackColor = Color.FromArgb(0,0,0,0);
            static_player_image.BackColor = Color.FromArgb(0, 0, 0, 0);
            head_attack_player_image.BackColor = Color.FromArgb(0, 0, 0, 0);
            mockery_player_image.BackColor = Color.FromArgb(0, 0, 0, 0);
            enemy_static_image.BackColor = Color.FromArgb(0, 0, 0, 0);
            enemy_mana1_image.BackColor = Color.FromArgb(0, 0, 0, 0);
            enemy_mana2_image.BackColor = Color.FromArgb(0, 0, 0, 0);
            mana_player_image.BackColor = Color.FromArgb(0, 0, 0, 0);
            //^у картинок убирается фон
            standart_attack_show();//отображаются параметры
            cheat_mode = cheats;
            if (cheat_mode == true)//проверка режима читов
            {
                cheat_plus_player_hp.Visible = true;
                cheat_minus_player_hp.Visible = true;
                cheat_plus_mana.Visible = true;
                cheat_minus_mana.Visible = true;
                cheat_plus_actpoints.Visible = true;
                cheat_minus_actpoints.Visible = true;
            }
        }
        async private void end_of_turn_button_Click(object sender, EventArgs e)
        {
            thinking_points_show();
            end_of_turn_button.Enabled = false;
            be_like_potato_button.Enabled = false;
            attack_button.Enabled = false;
            head_attack_button.Enabled = false;
            mockery_button.Enabled = false;
            back_button.Enabled = false;
            act_button.Enabled = false;
            mana_button.Enabled = false;
            inventory_button.Enabled = false;
            watch_on_enemy_button.Enabled = false;
            //^отключает все кнопки
            potato_player_image.Visible = false;
            static_player_image.Visible = true;
            head_attack_player_image.Visible = false;
            player_action_points = 3;
            player_effect_mana_weakness = false;
            enemy_action_points = 3;
            while (enemy_action_points > 0)
            {//начало хода врага
                await Task.Delay(3000);
                if (end_of_battle(player_hp,enemy_hp)!=0)
                {
                    this.Close();
                }
                if (enemy_mana >= 6)
                {//использование атаки строгое замечание
                    enemy_mana -= 6;
                    damage_for_player = player_damage_modifier + 4;
                    player_hp -= damage_for_player;
                    --enemy_action_points;
                    player_effect_mana_weakness = true;
                    event_box.Text = ("Враг использует строгое замечание:\r\nЕросер: \"Ты выглядишь неряшливо\";" +
                        "\r\nМана Эросера теперь равна " + enemy_mana+
                        "\r\nВы оскарблены до глубины души\r\nОчки здоровья -4 и вы получаете мана-слабость");
                    standart_attack_show();
                }
                else if (enemy_mana >= 5 && player_mana > 0)
                {//враг использует ластик
                    --enemy_action_points;
                    enemy_mana -= 5;
                    player_mana = 0;
                    event_box.Text = ("Враг кидает в вас ластик\r\nВаша мана обнулилась(какаким образом это работает?)");
                    standart_attack_show();
                }
                else
                {//враг получает ману
                    Random rnd = new Random();
                    int temp_mana = rnd.Next(1, 4);
                    enemy_mana += temp_mana;
                    --enemy_action_points;
                    event_box.Text = ("Враг впитывает ману из воздуха\r\nМана Эросера теперь равна " + enemy_mana);
                    enemy_mana_animation();
                    standart_attack_show();
                }
            }
            end_of_turn_button.Enabled = true;
            be_like_potato_button.Enabled = true;
            attack_button.Enabled = true;
            head_attack_button.Enabled = true;
            mockery_button.Enabled = true;
            back_button.Enabled = true;
            act_button.Enabled = true;
            mana_button.Enabled = true;
            inventory_button.Enabled = true;
            watch_on_enemy_button.Enabled = true;
            //^включает кнопки обратно
            player_damage_modifier = 0;
            enemy_damage_modifier = 0;
            standart_attack_show();
        }

        private void be_like_potato_button_Click(object sender, EventArgs e)
        {
            if (player_action_points > 0)
            {
                if (player_mana >= 2)
                {
                    player_action_points -= 1;
                    player_damage_modifier = -2;
                    player_mana -= 2;
                    event_box.Text = ("Вы садитесь и закрываете глаза," + "\r\n" + "входящий урон уменьшен на 2");
                    potato_player_image.Visible = true;
                    static_player_image.Visible = false;
                    head_attack_player_image.Visible = false;
                    mockery_player_image.Visible = false;
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
            if (end_of_battle(player_hp, enemy_hp) != 0)
            {
                this.Close();
            }
        }

        private void watch_on_enemy_button_Click(object sender, EventArgs e)
        {
            event_box.Text = ("Эросер - сбежавший ластик неизвестного художника" +
                        "\r\nСпособность:\"Строгое замечание\" наносит 4 урона, эффект мана-слабости" +
                        "\r\nСпособность: \"Бросок ластика\" - обнуление маны врага");
        }
        private void cheat_plus_player_hp_Click(object sender, EventArgs e)
        {
            ++player_hp;
            standart_attack_show();
        }

        private void cheat_minus_player_hp_Click(object sender, EventArgs e)
        {
            --player_hp;
            standart_attack_show();
        }

        private void cheat_plus_mana_Click(object sender, EventArgs e)
        {
            ++player_mana;
            standart_attack_show();
        }

        private void cheat_minus_mana_Click(object sender, EventArgs e)
        {
            --player_mana;
            standart_attack_show();
        }

        private void cheat_plus_actpoints_Click(object sender, EventArgs e)
        {
            ++player_action_points;
            standart_attack_show();
        }

        private void cheat_minus_actpoints_Click(object sender, EventArgs e)
        {
            --player_action_points;
            standart_attack_show();
        }

        private void inventory_button_Click(object sender, EventArgs e)
        {
            event_box.Text = ("Тут хоть шаром покати...");
            back_button.Visible=false;
            mana_button.Visible = false;
            watch_on_enemy_button.Visible = false;
            be_like_potato_button.Visible = false;
            head_attack_button.Visible = false;
            mockery_button.Visible = false;
        }
        private void head_attack_button_Click(object sender, EventArgs e)
        {
            if (player_action_points > 0){
                    if (player_mana > 0){//достаточно ли к игрока маны
                        --player_action_points;
                        damage_for_enemy = enemy_damage_modifier + player_mana;
                        enemy_hp -= damage_for_enemy;
                        if (player_damage_modifier<0) {
                             potato_player_image.Visible = false;
                             static_player_image.Visible = false;
                             head_attack_player_image.Visible = true;
                             mockery_player_image.Visible = false;
                        event_box.Text = ("Вы изо всех сил бьете врага,\r\nне очень умно(без отдачи), но эффективно,\r\n" +
                            "здоровье врага -" + player_mana + ",\r\nваша мана ушла на атаку");
                        }
                        else {
                            potato_player_image.Visible = false;
                            static_player_image.Visible = false;
                            head_attack_player_image.Visible = true;
                            mockery_player_image.Visible = false;
                            player_hp -= 1;
                            event_box.Text = ("Вы изо всех сил бьете врага,\r\nне очень умно(отдача 1 урона), но эффективно,\r\n" +
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
            if (end_of_battle(player_hp, enemy_hp) != 0)
            {
                this.Close();
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
            potato_player_image.Visible = false;
            mockery_player_image.Visible = false;
            head_attack_player_image.Visible = false;
            static_player_image.Visible = true;
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
                    potato_player_image.Visible = false;
                    mockery_player_image.Visible = true;
                    head_attack_player_image.Visible = false;
                    static_player_image.Visible = false;
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
            if (end_of_battle(player_hp, enemy_hp) != 0)
            {
                this.Close();
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
            potato_player_image.Visible = false;
            mockery_player_image.Visible = false;
            head_attack_player_image.Visible = false;
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
                    player_mana_animation();
                    event_box.Text = ("Вы решаете ударить сталогмит для получения маны" + "\r\n" + "Игрок получает ессенции маны: " + temp_mana + "\r\n"+"Очки действия уменьшились на 1!");
                }
                else
                {
                    Random rnd = new Random();
                    int temp_mana = rnd.Next(1, 3);
                    player_mana += temp_mana;
                    show_player_mana.Text = player_mana.ToString();
                    --player_action_points;
                    show_player_points.Text = player_action_points.ToString();
                    player_mana_animation();
                    event_box.Text = ("Вы СЛАБО бьёте сталогмит для получения маны" + "\r\n" + "Игрок получает ессенции маны: " + temp_mana + "\r\n" + "Очки действия уменьшились на 1!");
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
