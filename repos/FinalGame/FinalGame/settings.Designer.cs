namespace FinalGame
{
    partial class Settings
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
            this.show_text = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backtomenu_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // show_text
            // 
            this.show_text.AutoSize = true;
            this.show_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show_text.ForeColor = System.Drawing.Color.White;
            this.show_text.Location = new System.Drawing.Point(184, 85);
            this.show_text.Name = "show_text";
            this.show_text.Size = new System.Drawing.Size(399, 25);
            this.show_text.TabIndex = 0;
            this.show_text.Text = "ЗДЕСЬ НЕТ НИКАКИХ НАСТРОЕК?";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(603, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 180);
            this.button1.TabIndex = 1;
            this.button1.Text = "CHEATS!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backtomenu_button
            // 
            this.backtomenu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backtomenu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backtomenu_button.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.backtomenu_button.Location = new System.Drawing.Point(275, 370);
            this.backtomenu_button.Name = "backtomenu_button";
            this.backtomenu_button.Size = new System.Drawing.Size(215, 42);
            this.backtomenu_button.TabIndex = 3;
            this.backtomenu_button.Text = "Назад";
            this.backtomenu_button.UseVisualStyleBackColor = true;
            this.backtomenu_button.Click += new System.EventHandler(this.backtomenu_button_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backtomenu_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.show_text);
            this.Name = "Settings";
            this.Text = "settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label show_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button backtomenu_button;
    }
}