namespace Password_Manager
{
    partial class passwords_form
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddPassword = new System.Windows.Forms.Button();
            this.listViewPasswords = new System.Windows.Forms.ListView();
            this.textBoxSearchPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAmountPass = new System.Windows.Forms.Label();
            this.buttonPassImport = new System.Windows.Forms.Button();
            this.buttonPassExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(453, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Додавання нового паролю";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxLogin.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxLogin.Location = new System.Drawing.Point(722, 252);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(224, 30);
            this.textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPassword.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxPassword.Location = new System.Drawing.Point(722, 301);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(224, 30);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBoxUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxUrl.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxUrl.Location = new System.Drawing.Point(722, 351);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(224, 30);
            this.textBoxUrl.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(387, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введіть ваш логін/пошту";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(456, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введіть ваш пароль";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(468, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введіть URL сайту";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonAddPassword
            // 
            this.buttonAddPassword.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonAddPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddPassword.Font = new System.Drawing.Font("Courier New", 12F);
            this.buttonAddPassword.Location = new System.Drawing.Point(576, 433);
            this.buttonAddPassword.Name = "buttonAddPassword";
            this.buttonAddPassword.Size = new System.Drawing.Size(224, 56);
            this.buttonAddPassword.TabIndex = 8;
            this.buttonAddPassword.Text = "Додати";
            this.buttonAddPassword.UseVisualStyleBackColor = false;
            this.buttonAddPassword.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewPasswords
            // 
            this.listViewPasswords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.listViewPasswords.Font = new System.Drawing.Font("Courier New", 11F);
            this.listViewPasswords.ForeColor = System.Drawing.Color.Transparent;
            this.listViewPasswords.HideSelection = false;
            listViewItem1.UseItemStyleForSubItems = false;
            this.listViewPasswords.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewPasswords.Location = new System.Drawing.Point(12, 72);
            this.listViewPasswords.Name = "listViewPasswords";
            this.listViewPasswords.Size = new System.Drawing.Size(262, 569);
            this.listViewPasswords.TabIndex = 9;
            this.listViewPasswords.UseCompatibleStateImageBehavior = false;
            this.listViewPasswords.View = System.Windows.Forms.View.List;
            this.listViewPasswords.ItemActivate += new System.EventHandler(this.listViewPasswords_ItemActivate);
            // 
            // textBoxSearchPassword
            // 
            this.textBoxSearchPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBoxSearchPassword.Font = new System.Drawing.Font("Courier New", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxSearchPassword.Location = new System.Drawing.Point(37, 34);
            this.textBoxSearchPassword.Name = "textBoxSearchPassword";
            this.textBoxSearchPassword.Size = new System.Drawing.Size(214, 32);
            this.textBoxSearchPassword.TabIndex = 10;
            this.textBoxSearchPassword.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(59, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Пошук";
            // 
            // labelAmountPass
            // 
            this.labelAmountPass.AutoSize = true;
            this.labelAmountPass.ForeColor = System.Drawing.Color.Transparent;
            this.labelAmountPass.Location = new System.Drawing.Point(34, 612);
            this.labelAmountPass.Name = "labelAmountPass";
            this.labelAmountPass.Size = new System.Drawing.Size(0, 16);
            this.labelAmountPass.TabIndex = 24;
            // 
            // buttonPassImport
            // 
            this.buttonPassImport.BackColor = System.Drawing.Color.Gray;
            this.buttonPassImport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPassImport.Font = new System.Drawing.Font("Courier New", 10F);
            this.buttonPassImport.Location = new System.Drawing.Point(762, 600);
            this.buttonPassImport.Name = "buttonPassImport";
            this.buttonPassImport.Size = new System.Drawing.Size(151, 40);
            this.buttonPassImport.TabIndex = 25;
            this.buttonPassImport.Text = "Імпорт";
            this.buttonPassImport.UseVisualStyleBackColor = false;
            this.buttonPassImport.Click += new System.EventHandler(this.buttonPassImport_Click);
            // 
            // buttonPassExport
            // 
            this.buttonPassExport.BackColor = System.Drawing.Color.Gray;
            this.buttonPassExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPassExport.Font = new System.Drawing.Font("Courier New", 10F);
            this.buttonPassExport.Location = new System.Drawing.Point(919, 600);
            this.buttonPassExport.Name = "buttonPassExport";
            this.buttonPassExport.Size = new System.Drawing.Size(151, 40);
            this.buttonPassExport.TabIndex = 26;
            this.buttonPassExport.Text = "Експорт";
            this.buttonPassExport.UseVisualStyleBackColor = false;
            this.buttonPassExport.Click += new System.EventHandler(this.buttonPassExport_Click);
            // 
            // passwords_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.buttonPassExport);
            this.Controls.Add(this.buttonPassImport);
            this.Controls.Add(this.labelAmountPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSearchPassword);
            this.Controls.Add(this.listViewPasswords);
            this.Controls.Add(this.buttonAddPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label1);
            this.Name = "passwords_form";
            this.Text = "passwords_form";
            this.Load += new System.EventHandler(this.passwords_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddPassword;
        private System.Windows.Forms.ListView listViewPasswords;
        private System.Windows.Forms.TextBox textBoxSearchPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAmountPass;
        private System.Windows.Forms.Button buttonPassImport;
        private System.Windows.Forms.Button buttonPassExport;
    }
}