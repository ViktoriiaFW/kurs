namespace Password_Manager
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.El_button = new System.Windows.Forms.Button();
            this.password_button = new System.Windows.Forms.Button();
            this.cards_button = new System.Windows.Forms.Button();
            this.logins_button = new System.Windows.Forms.Button();
            this.notes_button = new System.Windows.Forms.Button();
            this.buttonGeneration = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Location = new System.Drawing.Point(183, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 660);
            this.panel1.TabIndex = 0;
            // 
            // El_button
            // 
            this.El_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.El_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.El_button.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.El_button.ForeColor = System.Drawing.Color.Transparent;
            this.El_button.Location = new System.Drawing.Point(2, 2);
            this.El_button.Name = "El_button";
            this.El_button.Size = new System.Drawing.Size(180, 60);
            this.El_button.TabIndex = 1;
            this.El_button.Text = "Усі елементи";
            this.El_button.UseVisualStyleBackColor = false;
            this.El_button.Click += new System.EventHandler(this.el_button_Click);
            // 
            // password_button
            // 
            this.password_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.password_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.password_button.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_button.ForeColor = System.Drawing.Color.Transparent;
            this.password_button.Location = new System.Drawing.Point(2, 68);
            this.password_button.Name = "password_button";
            this.password_button.Size = new System.Drawing.Size(180, 60);
            this.password_button.TabIndex = 2;
            this.password_button.Text = "Паролі";
            this.password_button.UseVisualStyleBackColor = false;
            this.password_button.Click += new System.EventHandler(this.password_button_Click);
            // 
            // cards_button
            // 
            this.cards_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cards_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cards_button.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cards_button.ForeColor = System.Drawing.Color.Transparent;
            this.cards_button.Location = new System.Drawing.Point(2, 134);
            this.cards_button.Name = "cards_button";
            this.cards_button.Size = new System.Drawing.Size(180, 60);
            this.cards_button.TabIndex = 2;
            this.cards_button.Text = "Картки";
            this.cards_button.UseVisualStyleBackColor = false;
            this.cards_button.Click += new System.EventHandler(this.cards_button_Click);
            // 
            // logins_button
            // 
            this.logins_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.logins_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logins_button.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logins_button.ForeColor = System.Drawing.Color.Transparent;
            this.logins_button.Location = new System.Drawing.Point(2, 200);
            this.logins_button.Name = "logins_button";
            this.logins_button.Size = new System.Drawing.Size(180, 60);
            this.logins_button.TabIndex = 2;
            this.logins_button.Text = "Логіни";
            this.logins_button.UseVisualStyleBackColor = false;
            this.logins_button.Click += new System.EventHandler(this.logins_button_Click);
            // 
            // notes_button
            // 
            this.notes_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.notes_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notes_button.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notes_button.ForeColor = System.Drawing.Color.Transparent;
            this.notes_button.Location = new System.Drawing.Point(2, 266);
            this.notes_button.Name = "notes_button";
            this.notes_button.Size = new System.Drawing.Size(180, 60);
            this.notes_button.TabIndex = 2;
            this.notes_button.Text = "Нотатки";
            this.notes_button.UseVisualStyleBackColor = false;
            this.notes_button.Click += new System.EventHandler(this.notes_button_Click);
            // 
            // buttonGeneration
            // 
            this.buttonGeneration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.buttonGeneration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGeneration.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGeneration.ForeColor = System.Drawing.Color.Transparent;
            this.buttonGeneration.Location = new System.Drawing.Point(2, 332);
            this.buttonGeneration.Name = "buttonGeneration";
            this.buttonGeneration.Size = new System.Drawing.Size(180, 60);
            this.buttonGeneration.TabIndex = 3;
            this.buttonGeneration.Text = "Генерація";
            this.buttonGeneration.UseVisualStyleBackColor = false;
            this.buttonGeneration.Click += new System.EventHandler(this.buttonGeneration_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Palatino Linotype", 8F);
            this.buttonExit.ForeColor = System.Drawing.Color.Transparent;
            this.buttonExit.Location = new System.Drawing.Point(2, 603);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(180, 38);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Вийти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonGeneration);
            this.Controls.Add(this.notes_button);
            this.Controls.Add(this.logins_button);
            this.Controls.Add(this.cards_button);
            this.Controls.Add(this.password_button);
            this.Controls.Add(this.El_button);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер Паролів";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button El_button;
        private System.Windows.Forms.Button password_button;
        private System.Windows.Forms.Button cards_button;
        private System.Windows.Forms.Button logins_button;
        private System.Windows.Forms.Button notes_button;
        private System.Windows.Forms.Button buttonGeneration;
        private System.Windows.Forms.Button buttonExit;
    }
}

