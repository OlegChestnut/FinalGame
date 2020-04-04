namespace FinalGame
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.start_game_button = new System.Windows.Forms.Button();
            this.settings_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.menu_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.menu_image)).BeginInit();
            this.SuspendLayout();
            // 
            // start_game_button
            // 
            this.start_game_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_game_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_game_button.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.start_game_button.Location = new System.Drawing.Point(573, 179);
            this.start_game_button.Name = "start_game_button";
            this.start_game_button.Size = new System.Drawing.Size(215, 42);
            this.start_game_button.TabIndex = 0;
            this.start_game_button.Text = "Играть";
            this.start_game_button.UseVisualStyleBackColor = true;
            this.start_game_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // settings_button
            // 
            this.settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settings_button.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.settings_button.Location = new System.Drawing.Point(573, 255);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(215, 42);
            this.settings_button.TabIndex = 1;
            this.settings_button.Text = "Настройки";
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // exit_button
            // 
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_button.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.exit_button.Location = new System.Drawing.Point(573, 333);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(215, 42);
            this.exit_button.TabIndex = 2;
            this.exit_button.Text = "Выход";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // menu_image
            // 
            this.menu_image.Image = ((System.Drawing.Image)(resources.GetObject("menu_image.Image")));
            this.menu_image.Location = new System.Drawing.Point(12, -106);
            this.menu_image.Name = "menu_image";
            this.menu_image.Size = new System.Drawing.Size(512, 512);
            this.menu_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menu_image.TabIndex = 3;
            this.menu_image.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu_image);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.start_game_button);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menu_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_game_button;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.PictureBox menu_image;
    }
}

