namespace Password_Manager
{
    partial class edit_password
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
            this.buttonDeletePass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPasswordEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUrlEdit = new System.Windows.Forms.TextBox();
            this.textBoxPasswordEdit = new System.Windows.Forms.TextBox();
            this.textBoxLoginEdit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonDeletePass
            // 
            this.buttonDeletePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDeletePass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeletePass.Font = new System.Drawing.Font("Courier New", 12F);
            this.buttonDeletePass.Location = new System.Drawing.Point(577, 425);
            this.buttonDeletePass.Name = "buttonDeletePass";
            this.buttonDeletePass.Size = new System.Drawing.Size(224, 56);
            this.buttonDeletePass.TabIndex = 50;
            this.buttonDeletePass.Text = "Видалити";
            this.buttonDeletePass.UseVisualStyleBackColor = false;
            this.buttonDeletePass.Click += new System.EventHandler(this.buttonDeletePass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(367, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 37);
            this.label1.TabIndex = 38;
            this.label1.Text = "Редагування паролю";
            // 
            // buttonPasswordEdit
            // 
            this.buttonPasswordEdit.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonPasswordEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPasswordEdit.Font = new System.Drawing.Font("Courier New", 12F);
            this.buttonPasswordEdit.Location = new System.Drawing.Point(329, 425);
            this.buttonPasswordEdit.Name = "buttonPasswordEdit";
            this.buttonPasswordEdit.Size = new System.Drawing.Size(224, 56);
            this.buttonPasswordEdit.TabIndex = 57;
            this.buttonPasswordEdit.Text = "Редагувати";
            this.buttonPasswordEdit.UseVisualStyleBackColor = false;
            this.buttonPasswordEdit.Click += new System.EventHandler(this.buttonPasswordEdit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(323, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 22);
            this.label4.TabIndex = 56;
            this.label4.Text = "Введіть URL сайту";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(311, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 22);
            this.label3.TabIndex = 55;
            this.label3.Text = "Введіть ваш пароль";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(242, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 22);
            this.label2.TabIndex = 54;
            this.label2.Text = "Введіть ваш логін/пошту";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxUrlEdit
            // 
            this.textBoxUrlEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBoxUrlEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxUrlEdit.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxUrlEdit.Location = new System.Drawing.Point(577, 331);
            this.textBoxUrlEdit.Name = "textBoxUrlEdit";
            this.textBoxUrlEdit.Size = new System.Drawing.Size(224, 30);
            this.textBoxUrlEdit.TabIndex = 53;
            // 
            // textBoxPasswordEdit
            // 
            this.textBoxPasswordEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBoxPasswordEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPasswordEdit.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxPasswordEdit.Location = new System.Drawing.Point(577, 281);
            this.textBoxPasswordEdit.Name = "textBoxPasswordEdit";
            this.textBoxPasswordEdit.Size = new System.Drawing.Size(224, 30);
            this.textBoxPasswordEdit.TabIndex = 52;
            this.textBoxPasswordEdit.UseSystemPasswordChar = true;
            // 
            // textBoxLoginEdit
            // 
            this.textBoxLoginEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBoxLoginEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxLoginEdit.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxLoginEdit.Location = new System.Drawing.Point(577, 232);
            this.textBoxLoginEdit.Name = "textBoxLoginEdit";
            this.textBoxLoginEdit.Size = new System.Drawing.Size(224, 30);
            this.textBoxLoginEdit.TabIndex = 51;
            // 
            // edit_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.buttonPasswordEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUrlEdit);
            this.Controls.Add(this.textBoxPasswordEdit);
            this.Controls.Add(this.textBoxLoginEdit);
            this.Controls.Add(this.buttonDeletePass);
            this.Controls.Add(this.label1);
            this.Name = "edit_password";
            this.Text = "edit_password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeletePass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPasswordEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUrlEdit;
        private System.Windows.Forms.TextBox textBoxPasswordEdit;
        private System.Windows.Forms.TextBox textBoxLoginEdit;
    }
}