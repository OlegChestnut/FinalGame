namespace FinalGame
{
    partial class GameWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.attack_button = new System.Windows.Forms.Button();
            this.mana_button = new System.Windows.Forms.Button();
            this.watch_on_enemy_button = new System.Windows.Forms.Button();
            this.player_hp_label = new System.Windows.Forms.Label();
            this.player_actpoints_label = new System.Windows.Forms.Label();
            this.player_mana_label = new System.Windows.Forms.Label();
            this.inventory_button = new System.Windows.Forms.Button();
            this.end_of_turn_button = new System.Windows.Forms.Button();
            this.show_player_hp = new System.Windows.Forms.Label();
            this.show_player_points = new System.Windows.Forms.Label();
            this.show_player_mana = new System.Windows.Forms.Label();
            this.event_box = new System.Windows.Forms.TextBox();
            this.head_attack_button = new System.Windows.Forms.Button();
            this.be_like_potato_button = new System.Windows.Forms.Button();
            this.mockery_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.act_button = new System.Windows.Forms.Button();
            this.enemy_hp_label = new System.Windows.Forms.Label();
            this.enemy_actpoints_label = new System.Windows.Forms.Label();
            this.enemy_mana_label = new System.Windows.Forms.Label();
            this.show_enemy_hp = new System.Windows.Forms.Label();
            this.show_enemy_actpoints = new System.Windows.Forms.Label();
            this.show_enemy_mana = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Player_name_label = new System.Windows.Forms.Label();
            this.enemy_name_label = new System.Windows.Forms.Label();
            this.cheat_plus_player_hp = new System.Windows.Forms.Button();
            this.cheat_minus_player_hp = new System.Windows.Forms.Button();
            this.cheat_plus_mana = new System.Windows.Forms.Button();
            this.cheat_minus_mana = new System.Windows.Forms.Button();
            this.cheat_minus_actpoints = new System.Windows.Forms.Button();
            this.cheat_plus_actpoints = new System.Windows.Forms.Button();
            this.enemy_static_image = new System.Windows.Forms.PictureBox();
            this.static_player_image = new System.Windows.Forms.PictureBox();
            this.head_attack_player_image = new System.Windows.Forms.PictureBox();
            this.potato_player_image = new System.Windows.Forms.PictureBox();
            this.mockery_player_image = new System.Windows.Forms.PictureBox();
            this.enemy_mana2_image = new System.Windows.Forms.PictureBox();
            this.enemy_mana1_image = new System.Windows.Forms.PictureBox();
            this.mana_player_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_static_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.static_player_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.head_attack_player_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potato_player_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mockery_player_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_mana2_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_mana1_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mana_player_image)).BeginInit();
            this.SuspendLayout();
            // 
            // attack_button
            // 
            this.attack_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attack_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attack_button.ForeColor = System.Drawing.Color.LightBlue;
            this.attack_button.Location = new System.Drawing.Point(29, 126);
            this.attack_button.Name = "attack_button";
            this.attack_button.Size = new System.Drawing.Size(125, 40);
            this.attack_button.TabIndex = 0;
            this.attack_button.Text = "Атака";
            this.attack_button.UseVisualStyleBackColor = true;
            this.attack_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // mana_button
            // 
            this.mana_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mana_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mana_button.ForeColor = System.Drawing.Color.LightBlue;
            this.mana_button.Location = new System.Drawing.Point(158, 218);
            this.mana_button.Name = "mana_button";
            this.mana_button.Size = new System.Drawing.Size(125, 40);
            this.mana_button.TabIndex = 1;
            this.mana_button.Text = "Получить ману";
            this.mana_button.UseVisualStyleBackColor = true;
            this.mana_button.Visible = false;
            this.mana_button.Click += new System.EventHandler(this.mana_button_Click);
            // 
            // watch_on_enemy_button
            // 
            this.watch_on_enemy_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watch_on_enemy_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.watch_on_enemy_button.ForeColor = System.Drawing.Color.LightBlue;
            this.watch_on_enemy_button.Location = new System.Drawing.Point(158, 172);
            this.watch_on_enemy_button.Name = "watch_on_enemy_button";
            this.watch_on_enemy_button.Size = new System.Drawing.Size(125, 40);
            this.watch_on_enemy_button.TabIndex = 2;
            this.watch_on_enemy_button.Text = "Взглянуть на врага";
            this.watch_on_enemy_button.UseVisualStyleBackColor = true;
            this.watch_on_enemy_button.Visible = false;
            this.watch_on_enemy_button.Click += new System.EventHandler(this.watch_on_enemy_button_Click);
            // 
            // player_hp_label
            // 
            this.player_hp_label.AutoSize = true;
            this.player_hp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player_hp_label.ForeColor = System.Drawing.Color.IndianRed;
            this.player_hp_label.Location = new System.Drawing.Point(27, 43);
            this.player_hp_label.Name = "player_hp_label";
            this.player_hp_label.Size = new System.Drawing.Size(115, 20);
            this.player_hp_label.TabIndex = 4;
            this.player_hp_label.Text = "Здоровье ♥";
            // 
            // player_actpoints_label
            // 
            this.player_actpoints_label.AutoSize = true;
            this.player_actpoints_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player_actpoints_label.ForeColor = System.Drawing.Color.Gold;
            this.player_actpoints_label.Location = new System.Drawing.Point(27, 63);
            this.player_actpoints_label.Name = "player_actpoints_label";
            this.player_actpoints_label.Size = new System.Drawing.Size(146, 20);
            this.player_actpoints_label.TabIndex = 5;
            this.player_actpoints_label.Text = "Очки действий•";
            // 
            // player_mana_label
            // 
            this.player_mana_label.AutoSize = true;
            this.player_mana_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player_mana_label.ForeColor = System.Drawing.Color.LightCyan;
            this.player_mana_label.Location = new System.Drawing.Point(27, 83);
            this.player_mana_label.Name = "player_mana_label";
            this.player_mana_label.Size = new System.Drawing.Size(53, 20);
            this.player_mana_label.TabIndex = 6;
            this.player_mana_label.Text = "Мана";
            // 
            // inventory_button
            // 
            this.inventory_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventory_button.ForeColor = System.Drawing.Color.LightBlue;
            this.inventory_button.Location = new System.Drawing.Point(29, 218);
            this.inventory_button.Name = "inventory_button";
            this.inventory_button.Size = new System.Drawing.Size(125, 40);
            this.inventory_button.TabIndex = 7;
            this.inventory_button.Text = "Инвентарь";
            this.inventory_button.UseVisualStyleBackColor = true;
            this.inventory_button.Click += new System.EventHandler(this.inventory_button_Click);
            // 
            // end_of_turn_button
            // 
            this.end_of_turn_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.end_of_turn_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.end_of_turn_button.ForeColor = System.Drawing.Color.LightBlue;
            this.end_of_turn_button.Location = new System.Drawing.Point(29, 262);
            this.end_of_turn_button.Name = "end_of_turn_button";
            this.end_of_turn_button.Size = new System.Drawing.Size(125, 40);
            this.end_of_turn_button.TabIndex = 8;
            this.end_of_turn_button.Text = "Конец хода";
            this.end_of_turn_button.UseVisualStyleBackColor = true;
            this.end_of_turn_button.Click += new System.EventHandler(this.end_of_turn_button_Click);
            // 
            // show_player_hp
            // 
            this.show_player_hp.AutoSize = true;
            this.show_player_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show_player_hp.ForeColor = System.Drawing.Color.IndianRed;
            this.show_player_hp.Location = new System.Drawing.Point(167, 43);
            this.show_player_hp.Name = "show_player_hp";
            this.show_player_hp.Size = new System.Drawing.Size(29, 20);
            this.show_player_hp.TabIndex = 11;
            this.show_player_hp.Text = "hp";
            // 
            // show_player_points
            // 
            this.show_player_points.AutoSize = true;
            this.show_player_points.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show_player_points.ForeColor = System.Drawing.Color.Gold;
            this.show_player_points.Location = new System.Drawing.Point(167, 63);
            this.show_player_points.Name = "show_player_points";
            this.show_player_points.Size = new System.Drawing.Size(58, 20);
            this.show_player_points.TabIndex = 12;
            this.show_player_points.Text = "points";
            // 
            // show_player_mana
            // 
            this.show_player_mana.AutoSize = true;
            this.show_player_mana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show_player_mana.ForeColor = System.Drawing.Color.LightCyan;
            this.show_player_mana.Location = new System.Drawing.Point(167, 83);
            this.show_player_mana.Name = "show_player_mana";
            this.show_player_mana.Size = new System.Drawing.Size(53, 20);
            this.show_player_mana.TabIndex = 13;
            this.show_player_mana.Text = "mana";
            // 
            // event_box
            // 
            this.event_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.event_box.Cursor = System.Windows.Forms.Cursors.Default;
            this.event_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.event_box.ForeColor = System.Drawing.Color.LightBlue;
            this.event_box.Location = new System.Drawing.Point(21, 317);
            this.event_box.Multiline = true;
            this.event_box.Name = "event_box";
            this.event_box.ReadOnly = true;
            this.event_box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.event_box.Size = new System.Drawing.Size(470, 121);
            this.event_box.TabIndex = 14;
            this.event_box.Text = "БОЙ НАЧАЛСЯ!";
            // 
            // head_attack_button
            // 
            this.head_attack_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.head_attack_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.head_attack_button.ForeColor = System.Drawing.Color.LightBlue;
            this.head_attack_button.Location = new System.Drawing.Point(158, 172);
            this.head_attack_button.Name = "head_attack_button";
            this.head_attack_button.Size = new System.Drawing.Size(125, 40);
            this.head_attack_button.TabIndex = 15;
            this.head_attack_button.Text = "Атака головой";
            this.head_attack_button.UseVisualStyleBackColor = true;
            this.head_attack_button.Visible = false;
            this.head_attack_button.Click += new System.EventHandler(this.head_attack_button_Click);
            // 
            // be_like_potato_button
            // 
            this.be_like_potato_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.be_like_potato_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.be_like_potato_button.ForeColor = System.Drawing.Color.LightBlue;
            this.be_like_potato_button.Location = new System.Drawing.Point(158, 218);
            this.be_like_potato_button.Name = "be_like_potato_button";
            this.be_like_potato_button.Size = new System.Drawing.Size(125, 40);
            this.be_like_potato_button.TabIndex = 16;
            this.be_like_potato_button.Text = "Прикинуться картошкой";
            this.be_like_potato_button.UseVisualStyleBackColor = true;
            this.be_like_potato_button.Visible = false;
            this.be_like_potato_button.Click += new System.EventHandler(this.be_like_potato_button_Click);
            // 
            // mockery_button
            // 
            this.mockery_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mockery_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mockery_button.ForeColor = System.Drawing.Color.LightBlue;
            this.mockery_button.Location = new System.Drawing.Point(158, 262);
            this.mockery_button.Name = "mockery_button";
            this.mockery_button.Size = new System.Drawing.Size(125, 40);
            this.mockery_button.TabIndex = 17;
            this.mockery_button.Text = "Насмешка";
            this.mockery_button.UseVisualStyleBackColor = true;
            this.mockery_button.Visible = false;
            this.mockery_button.Click += new System.EventHandler(this.mockery_button_Click);
            // 
            // back_button
            // 
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_button.ForeColor = System.Drawing.Color.LightBlue;
            this.back_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back_button.Location = new System.Drawing.Point(158, 126);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(125, 40);
            this.back_button.TabIndex = 18;
            this.back_button.Text = "<<назад";
            this.back_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Visible = false;
            this.back_button.Click += new System.EventHandler(this.back_buttom_Click);
            // 
            // act_button
            // 
            this.act_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.act_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.act_button.ForeColor = System.Drawing.Color.LightBlue;
            this.act_button.Location = new System.Drawing.Point(29, 172);
            this.act_button.Name = "act_button";
            this.act_button.Size = new System.Drawing.Size(125, 40);
            this.act_button.TabIndex = 25;
            this.act_button.Text = "Действия";
            this.act_button.UseVisualStyleBackColor = true;
            this.act_button.Click += new System.EventHandler(this.act_Click);
            // 
            // enemy_hp_label
            // 
            this.enemy_hp_label.AutoSize = true;
            this.enemy_hp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemy_hp_label.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.enemy_hp_label.Location = new System.Drawing.Point(506, 361);
            this.enemy_hp_label.Name = "enemy_hp_label";
            this.enemy_hp_label.Size = new System.Drawing.Size(115, 20);
            this.enemy_hp_label.TabIndex = 26;
            this.enemy_hp_label.Text = "Здоровье ♥";
            // 
            // enemy_actpoints_label
            // 
            this.enemy_actpoints_label.AutoSize = true;
            this.enemy_actpoints_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemy_actpoints_label.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.enemy_actpoints_label.Location = new System.Drawing.Point(506, 381);
            this.enemy_actpoints_label.Name = "enemy_actpoints_label";
            this.enemy_actpoints_label.Size = new System.Drawing.Size(146, 20);
            this.enemy_actpoints_label.TabIndex = 27;
            this.enemy_actpoints_label.Text = "Очки действий•";
            // 
            // enemy_mana_label
            // 
            this.enemy_mana_label.AutoSize = true;
            this.enemy_mana_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemy_mana_label.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.enemy_mana_label.Location = new System.Drawing.Point(506, 401);
            this.enemy_mana_label.Name = "enemy_mana_label";
            this.enemy_mana_label.Size = new System.Drawing.Size(53, 20);
            this.enemy_mana_label.TabIndex = 28;
            this.enemy_mana_label.Text = "Мана";
            // 
            // show_enemy_hp
            // 
            this.show_enemy_hp.AutoSize = true;
            this.show_enemy_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show_enemy_hp.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.show_enemy_hp.Location = new System.Drawing.Point(653, 361);
            this.show_enemy_hp.Name = "show_enemy_hp";
            this.show_enemy_hp.Size = new System.Drawing.Size(29, 20);
            this.show_enemy_hp.TabIndex = 29;
            this.show_enemy_hp.Text = "hp";
            // 
            // show_enemy_actpoints
            // 
            this.show_enemy_actpoints.AutoSize = true;
            this.show_enemy_actpoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show_enemy_actpoints.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.show_enemy_actpoints.Location = new System.Drawing.Point(653, 381);
            this.show_enemy_actpoints.Name = "show_enemy_actpoints";
            this.show_enemy_actpoints.Size = new System.Drawing.Size(58, 20);
            this.show_enemy_actpoints.TabIndex = 30;
            this.show_enemy_actpoints.Text = "points";
            // 
            // show_enemy_mana
            // 
            this.show_enemy_mana.AutoSize = true;
            this.show_enemy_mana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show_enemy_mana.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.show_enemy_mana.Location = new System.Drawing.Point(653, 401);
            this.show_enemy_mana.Name = "show_enemy_mana";
            this.show_enemy_mana.Size = new System.Drawing.Size(53, 20);
            this.show_enemy_mana.TabIndex = 31;
            this.show_enemy_mana.Text = "mana";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox4.Location = new System.Drawing.Point(497, 317);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(273, 121);
            this.textBox4.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.ForeColor = System.Drawing.Color.LightBlue;
            this.textBox3.Location = new System.Drawing.Point(21, 118);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(273, 195);
            this.textBox3.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Location = new System.Drawing.Point(21, 14);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(273, 98);
            this.textBox2.TabIndex = 22;
            // 
            // Player_name_label
            // 
            this.Player_name_label.AutoSize = true;
            this.Player_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player_name_label.ForeColor = System.Drawing.Color.White;
            this.Player_name_label.Location = new System.Drawing.Point(27, 23);
            this.Player_name_label.Name = "Player_name_label";
            this.Player_name_label.Size = new System.Drawing.Size(107, 20);
            this.Player_name_label.TabIndex = 32;
            this.Player_name_label.Text = "Player name";
            // 
            // enemy_name_label
            // 
            this.enemy_name_label.AutoSize = true;
            this.enemy_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemy_name_label.ForeColor = System.Drawing.Color.White;
            this.enemy_name_label.Location = new System.Drawing.Point(506, 328);
            this.enemy_name_label.Name = "enemy_name_label";
            this.enemy_name_label.Size = new System.Drawing.Size(82, 24);
            this.enemy_name_label.TabIndex = 33;
            this.enemy_name_label.Text = "Эрасер";
            // 
            // cheat_plus_player_hp
            // 
            this.cheat_plus_player_hp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cheat_plus_player_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cheat_plus_player_hp.ForeColor = System.Drawing.Color.Yellow;
            this.cheat_plus_player_hp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cheat_plus_player_hp.Location = new System.Drawing.Point(534, 12);
            this.cheat_plus_player_hp.Name = "cheat_plus_player_hp";
            this.cheat_plus_player_hp.Size = new System.Drawing.Size(42, 39);
            this.cheat_plus_player_hp.TabIndex = 34;
            this.cheat_plus_player_hp.Text = "+hp";
            this.cheat_plus_player_hp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cheat_plus_player_hp.UseVisualStyleBackColor = true;
            this.cheat_plus_player_hp.Visible = false;
            this.cheat_plus_player_hp.Click += new System.EventHandler(this.cheat_plus_player_hp_Click);
            // 
            // cheat_minus_player_hp
            // 
            this.cheat_minus_player_hp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cheat_minus_player_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cheat_minus_player_hp.ForeColor = System.Drawing.Color.Yellow;
            this.cheat_minus_player_hp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cheat_minus_player_hp.Location = new System.Drawing.Point(582, 12);
            this.cheat_minus_player_hp.Name = "cheat_minus_player_hp";
            this.cheat_minus_player_hp.Size = new System.Drawing.Size(42, 39);
            this.cheat_minus_player_hp.TabIndex = 35;
            this.cheat_minus_player_hp.Text = "-hp";
            this.cheat_minus_player_hp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cheat_minus_player_hp.UseVisualStyleBackColor = true;
            this.cheat_minus_player_hp.Visible = false;
            this.cheat_minus_player_hp.Click += new System.EventHandler(this.cheat_minus_player_hp_Click);
            // 
            // cheat_plus_mana
            // 
            this.cheat_plus_mana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cheat_plus_mana.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cheat_plus_mana.ForeColor = System.Drawing.Color.Yellow;
            this.cheat_plus_mana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cheat_plus_mana.Location = new System.Drawing.Point(630, 12);
            this.cheat_plus_mana.Name = "cheat_plus_mana";
            this.cheat_plus_mana.Size = new System.Drawing.Size(42, 39);
            this.cheat_plus_mana.TabIndex = 36;
            this.cheat_plus_mana.Text = "+mn";
            this.cheat_plus_mana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cheat_plus_mana.UseVisualStyleBackColor = true;
            this.cheat_plus_mana.Visible = false;
            this.cheat_plus_mana.Click += new System.EventHandler(this.cheat_plus_mana_Click);
            // 
            // cheat_minus_mana
            // 
            this.cheat_minus_mana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cheat_minus_mana.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cheat_minus_mana.ForeColor = System.Drawing.Color.Yellow;
            this.cheat_minus_mana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cheat_minus_mana.Location = new System.Drawing.Point(630, 55);
            this.cheat_minus_mana.Name = "cheat_minus_mana";
            this.cheat_minus_mana.Size = new System.Drawing.Size(42, 39);
            this.cheat_minus_mana.TabIndex = 37;
            this.cheat_minus_mana.Text = "-mn";
            this.cheat_minus_mana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cheat_minus_mana.UseVisualStyleBackColor = true;
            this.cheat_minus_mana.Visible = false;
            this.cheat_minus_mana.Click += new System.EventHandler(this.cheat_minus_mana_Click);
            // 
            // cheat_minus_actpoints
            // 
            this.cheat_minus_actpoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cheat_minus_actpoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cheat_minus_actpoints.ForeColor = System.Drawing.Color.Yellow;
            this.cheat_minus_actpoints.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cheat_minus_actpoints.Location = new System.Drawing.Point(582, 55);
            this.cheat_minus_actpoints.Name = "cheat_minus_actpoints";
            this.cheat_minus_actpoints.Size = new System.Drawing.Size(42, 39);
            this.cheat_minus_actpoints.TabIndex = 39;
            this.cheat_minus_actpoints.Text = "-ap";
            this.cheat_minus_actpoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cheat_minus_actpoints.UseVisualStyleBackColor = true;
            this.cheat_minus_actpoints.Visible = false;
            this.cheat_minus_actpoints.Click += new System.EventHandler(this.cheat_minus_actpoints_Click);
            // 
            // cheat_plus_actpoints
            // 
            this.cheat_plus_actpoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cheat_plus_actpoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cheat_plus_actpoints.ForeColor = System.Drawing.Color.Yellow;
            this.cheat_plus_actpoints.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cheat_plus_actpoints.Location = new System.Drawing.Point(534, 55);
            this.cheat_plus_actpoints.Name = "cheat_plus_actpoints";
            this.cheat_plus_actpoints.Size = new System.Drawing.Size(42, 39);
            this.cheat_plus_actpoints.TabIndex = 38;
            this.cheat_plus_actpoints.Text = "+ap";
            this.cheat_plus_actpoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cheat_plus_actpoints.UseVisualStyleBackColor = true;
            this.cheat_plus_actpoints.Visible = false;
            this.cheat_plus_actpoints.Click += new System.EventHandler(this.cheat_plus_actpoints_Click);
            // 
            // enemy_static_image
            // 
            this.enemy_static_image.BackColor = System.Drawing.Color.SlateGray;
            this.enemy_static_image.Image = global::FinalGame.Properties.Resources.sprite_enemy_eroser_statick;
            this.enemy_static_image.Location = new System.Drawing.Point(600, 126);
            this.enemy_static_image.Name = "enemy_static_image";
            this.enemy_static_image.Size = new System.Drawing.Size(170, 170);
            this.enemy_static_image.TabIndex = 9;
            this.enemy_static_image.TabStop = false;
            // 
            // static_player_image
            // 
            this.static_player_image.BackColor = System.Drawing.Color.SlateGray;
            this.static_player_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.static_player_image.Image = global::FinalGame.Properties.Resources.sprite_player_statick;
            this.static_player_image.Location = new System.Drawing.Point(321, 43);
            this.static_player_image.Name = "static_player_image";
            this.static_player_image.Size = new System.Drawing.Size(170, 182);
            this.static_player_image.TabIndex = 10;
            this.static_player_image.TabStop = false;
            // 
            // head_attack_player_image
            // 
            this.head_attack_player_image.BackColor = System.Drawing.Color.SlateGray;
            this.head_attack_player_image.Image = global::FinalGame.Properties.Resources.sprite_player_headattack;
            this.head_attack_player_image.Location = new System.Drawing.Point(321, 43);
            this.head_attack_player_image.Name = "head_attack_player_image";
            this.head_attack_player_image.Size = new System.Drawing.Size(170, 182);
            this.head_attack_player_image.TabIndex = 20;
            this.head_attack_player_image.TabStop = false;
            this.head_attack_player_image.Visible = false;
            // 
            // potato_player_image
            // 
            this.potato_player_image.BackColor = System.Drawing.Color.SlateGray;
            this.potato_player_image.Image = global::FinalGame.Properties.Resources.sprite_player_potato;
            this.potato_player_image.Location = new System.Drawing.Point(321, 43);
            this.potato_player_image.Name = "potato_player_image";
            this.potato_player_image.Size = new System.Drawing.Size(170, 182);
            this.potato_player_image.TabIndex = 19;
            this.potato_player_image.TabStop = false;
            this.potato_player_image.Visible = false;
            // 
            // mockery_player_image
            // 
            this.mockery_player_image.BackColor = System.Drawing.Color.SlateGray;
            this.mockery_player_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mockery_player_image.Image = global::FinalGame.Properties.Resources.sprite_player_mockery;
            this.mockery_player_image.Location = new System.Drawing.Point(321, 43);
            this.mockery_player_image.Name = "mockery_player_image";
            this.mockery_player_image.Size = new System.Drawing.Size(170, 182);
            this.mockery_player_image.TabIndex = 40;
            this.mockery_player_image.TabStop = false;
            // 
            // enemy_mana2_image
            // 
            this.enemy_mana2_image.BackColor = System.Drawing.Color.SlateGray;
            this.enemy_mana2_image.Image = global::FinalGame.Properties.Resources.sprite_enemy_eroser_mana2;
            this.enemy_mana2_image.Location = new System.Drawing.Point(600, 126);
            this.enemy_mana2_image.Name = "enemy_mana2_image";
            this.enemy_mana2_image.Size = new System.Drawing.Size(170, 170);
            this.enemy_mana2_image.TabIndex = 41;
            this.enemy_mana2_image.TabStop = false;
            this.enemy_mana2_image.Visible = false;
            // 
            // enemy_mana1_image
            // 
            this.enemy_mana1_image.BackColor = System.Drawing.Color.SlateGray;
            this.enemy_mana1_image.Image = global::FinalGame.Properties.Resources.sprite_enemy_eroser_mana1;
            this.enemy_mana1_image.Location = new System.Drawing.Point(600, 126);
            this.enemy_mana1_image.Name = "enemy_mana1_image";
            this.enemy_mana1_image.Size = new System.Drawing.Size(170, 170);
            this.enemy_mana1_image.TabIndex = 42;
            this.enemy_mana1_image.TabStop = false;
            this.enemy_mana1_image.Visible = false;
            // 
            // mana_player_image
            // 
            this.mana_player_image.BackColor = System.Drawing.Color.SlateGray;
            this.mana_player_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mana_player_image.Image = ((System.Drawing.Image)(resources.GetObject("mana_player_image.Image")));
            this.mana_player_image.Location = new System.Drawing.Point(321, 43);
            this.mana_player_image.Name = "mana_player_image";
            this.mana_player_image.Size = new System.Drawing.Size(170, 182);
            this.mana_player_image.TabIndex = 43;
            this.mana_player_image.TabStop = false;
            this.mana_player_image.Visible = false;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enemy_static_image);
            this.Controls.Add(this.enemy_mana1_image);
            this.Controls.Add(this.enemy_mana2_image);
            this.Controls.Add(this.cheat_minus_actpoints);
            this.Controls.Add(this.cheat_plus_actpoints);
            this.Controls.Add(this.cheat_minus_mana);
            this.Controls.Add(this.cheat_plus_mana);
            this.Controls.Add(this.cheat_minus_player_hp);
            this.Controls.Add(this.cheat_plus_player_hp);
            this.Controls.Add(this.enemy_name_label);
            this.Controls.Add(this.Player_name_label);
            this.Controls.Add(this.show_enemy_mana);
            this.Controls.Add(this.show_enemy_actpoints);
            this.Controls.Add(this.show_enemy_hp);
            this.Controls.Add(this.enemy_mana_label);
            this.Controls.Add(this.enemy_actpoints_label);
            this.Controls.Add(this.enemy_hp_label);
            this.Controls.Add(this.act_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.mockery_button);
            this.Controls.Add(this.show_player_mana);
            this.Controls.Add(this.show_player_points);
            this.Controls.Add(this.show_player_hp);
            this.Controls.Add(this.end_of_turn_button);
            this.Controls.Add(this.inventory_button);
            this.Controls.Add(this.player_mana_label);
            this.Controls.Add(this.player_actpoints_label);
            this.Controls.Add(this.player_hp_label);
            this.Controls.Add(this.attack_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.event_box);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.static_player_image);
            this.Controls.Add(this.head_attack_player_image);
            this.Controls.Add(this.potato_player_image);
            this.Controls.Add(this.be_like_potato_button);
            this.Controls.Add(this.mana_button);
            this.Controls.Add(this.head_attack_button);
            this.Controls.Add(this.watch_on_enemy_button);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.mockery_player_image);
            this.Controls.Add(this.mana_player_image);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "GameWindow";
            this.Text = "GameWindow";
            ((System.ComponentModel.ISupportInitialize)(this.enemy_static_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.static_player_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.head_attack_player_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potato_player_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mockery_player_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_mana2_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_mana1_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mana_player_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button attack_button;
        private System.Windows.Forms.Button mana_button;
        private System.Windows.Forms.Button watch_on_enemy_button;
        private System.Windows.Forms.Label player_hp_label;
        private System.Windows.Forms.Label player_actpoints_label;
        private System.Windows.Forms.Label player_mana_label;
        private System.Windows.Forms.Button inventory_button;
        private System.Windows.Forms.Button end_of_turn_button;
        private System.Windows.Forms.PictureBox enemy_static_image;
        private System.Windows.Forms.PictureBox static_player_image;
        private System.Windows.Forms.Label show_player_hp;
        private System.Windows.Forms.Label show_player_points;
        private System.Windows.Forms.Label show_player_mana;
        private System.Windows.Forms.TextBox event_box;
        private System.Windows.Forms.Button head_attack_button;
        private System.Windows.Forms.Button be_like_potato_button;
        private System.Windows.Forms.Button mockery_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.PictureBox potato_player_image;
        private System.Windows.Forms.PictureBox head_attack_player_image;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button act_button;
        private System.Windows.Forms.Label enemy_hp_label;
        private System.Windows.Forms.Label enemy_actpoints_label;
        private System.Windows.Forms.Label enemy_mana_label;
        private System.Windows.Forms.Label show_enemy_hp;
        private System.Windows.Forms.Label show_enemy_actpoints;
        private System.Windows.Forms.Label show_enemy_mana;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Player_name_label;
        private System.Windows.Forms.Label enemy_name_label;
        private System.Windows.Forms.Button cheat_plus_player_hp;
        private System.Windows.Forms.Button cheat_minus_player_hp;
        private System.Windows.Forms.Button cheat_plus_mana;
        private System.Windows.Forms.Button cheat_minus_mana;
        private System.Windows.Forms.Button cheat_minus_actpoints;
        private System.Windows.Forms.Button cheat_plus_actpoints;
        private System.Windows.Forms.PictureBox mockery_player_image;
        private System.Windows.Forms.PictureBox enemy_mana2_image;
        private System.Windows.Forms.PictureBox enemy_mana1_image;
        private System.Windows.Forms.PictureBox mana_player_image;
    }
}