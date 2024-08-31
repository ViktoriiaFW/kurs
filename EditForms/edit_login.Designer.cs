namespace Password_Manager.EditForms
{
    partial class edit_login
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
            this.buttonLoginEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUrlEdit = new System.Windows.Forms.TextBox();
            this.textBoxLoginEdit = new System.Windows.Forms.TextBox();
            this.buttonDeleteLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLoginEdit
            // 
            this.buttonLoginEdit.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonLoginEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLoginEdit.Font = new System.Drawing.Font("Courier New", 12F);
            this.buttonLoginEdit.Location = new System.Drawing.Point(317, 431);
            this.buttonLoginEdit.Name = "buttonLoginEdit";
            this.buttonLoginEdit.Size = new System.Drawing.Size(224, 56);
            this.buttonLoginEdit.TabIndex = 66;
            this.buttonLoginEdit.Text = "Редагувати";
            this.buttonLoginEdit.UseVisualStyleBackColor = false;
            this.buttonLoginEdit.Click += new System.EventHandler(this.buttonLoginEdit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(311, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 22);
            this.label4.TabIndex = 65;
            this.label4.Text = "Введіть URL сайту";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(311, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 22);
            this.label2.TabIndex = 63;
            this.label2.Text = "Введіть ваш логін";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxUrlEdit
            // 
            this.textBoxUrlEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBoxUrlEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxUrlEdit.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxUrlEdit.Location = new System.Drawing.Point(565, 318);
            this.textBoxUrlEdit.Name = "textBoxUrlEdit";
            this.textBoxUrlEdit.Size = new System.Drawing.Size(224, 30);
            this.textBoxUrlEdit.TabIndex = 62;
            // 
            // textBoxLoginEdit
            // 
            this.textBoxLoginEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBoxLoginEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxLoginEdit.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxLoginEdit.Location = new System.Drawing.Point(565, 264);
            this.textBoxLoginEdit.Name = "textBoxLoginEdit";
            this.textBoxLoginEdit.Size = new System.Drawing.Size(224, 30);
            this.textBoxLoginEdit.TabIndex = 60;
            // 
            // buttonDeleteLogin
            // 
            this.buttonDeleteLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDeleteLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteLogin.Font = new System.Drawing.Font("Courier New", 12F);
            this.buttonDeleteLogin.Location = new System.Drawing.Point(565, 431);
            this.buttonDeleteLogin.Name = "buttonDeleteLogin";
            this.buttonDeleteLogin.Size = new System.Drawing.Size(224, 56);
            this.buttonDeleteLogin.TabIndex = 59;
            this.buttonDeleteLogin.Text = "Видалити";
            this.buttonDeleteLogin.UseVisualStyleBackColor = false;
            this.buttonDeleteLogin.Click += new System.EventHandler(this.buttonDeleteLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(360, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 37);
            this.label1.TabIndex = 58;
            this.label1.Text = "Редагування логіну";
            // 
            // edit_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.buttonLoginEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUrlEdit);
            this.Controls.Add(this.textBoxLoginEdit);
            this.Controls.Add(this.buttonDeleteLogin);
            this.Controls.Add(this.label1);
            this.Name = "edit_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "edit_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoginEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUrlEdit;
        private System.Windows.Forms.TextBox textBoxLoginEdit;
        private System.Windows.Forms.Button buttonDeleteLogin;
        private System.Windows.Forms.Label label1;
    }
}