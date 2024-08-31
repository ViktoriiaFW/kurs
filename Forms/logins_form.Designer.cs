namespace Password_Manager
{
    partial class logins_form
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSearchLogin = new System.Windows.Forms.TextBox();
            this.listViewLogins = new System.Windows.Forms.ListView();
            this.buttonAddLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAmountLogins = new System.Windows.Forms.Label();
            this.buttonLoginExport = new System.Windows.Forms.Button();
            this.buttonLoginImport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(59, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Пошук";
            // 
            // textBoxSearchLogin
            // 
            this.textBoxSearchLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBoxSearchLogin.Font = new System.Drawing.Font("Courier New", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxSearchLogin.Location = new System.Drawing.Point(37, 34);
            this.textBoxSearchLogin.Name = "textBoxSearchLogin";
            this.textBoxSearchLogin.Size = new System.Drawing.Size(214, 32);
            this.textBoxSearchLogin.TabIndex = 21;
            this.textBoxSearchLogin.TextChanged += new System.EventHandler(this.textBoxSearchLogin_TextChanged);
            // 
            // listViewLogins
            // 
            this.listViewLogins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.listViewLogins.Font = new System.Drawing.Font("Courier New", 11F);
            this.listViewLogins.ForeColor = System.Drawing.Color.Transparent;
            this.listViewLogins.HideSelection = false;
            listViewItem1.UseItemStyleForSubItems = false;
            this.listViewLogins.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewLogins.Location = new System.Drawing.Point(12, 72);
            this.listViewLogins.Name = "listViewLogins";
            this.listViewLogins.Size = new System.Drawing.Size(262, 569);
            this.listViewLogins.TabIndex = 20;
            this.listViewLogins.UseCompatibleStateImageBehavior = false;
            this.listViewLogins.View = System.Windows.Forms.View.List;
            this.listViewLogins.ItemActivate += new System.EventHandler(this.listViewLogins_ItemActivate);
            // 
            // buttonAddLogin
            // 
            this.buttonAddLogin.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonAddLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddLogin.Font = new System.Drawing.Font("Courier New", 12F);
            this.buttonAddLogin.Location = new System.Drawing.Point(579, 430);
            this.buttonAddLogin.Name = "buttonAddLogin";
            this.buttonAddLogin.Size = new System.Drawing.Size(224, 56);
            this.buttonAddLogin.TabIndex = 19;
            this.buttonAddLogin.Text = "Додати";
            this.buttonAddLogin.UseVisualStyleBackColor = false;
            this.buttonAddLogin.Click += new System.EventHandler(this.buttonAddLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(471, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Введіть URL сайту";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(471, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Введіть ваш логін";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBoxUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxUrl.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxUrl.Location = new System.Drawing.Point(725, 322);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(224, 30);
            this.textBoxUrl.TabIndex = 15;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxLogin.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxLogin.Location = new System.Drawing.Point(725, 249);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(224, 30);
            this.textBoxLogin.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(456, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Додавання нового логіну";
            // 
            // labelAmountLogins
            // 
            this.labelAmountLogins.AutoSize = true;
            this.labelAmountLogins.ForeColor = System.Drawing.Color.Transparent;
            this.labelAmountLogins.Location = new System.Drawing.Point(34, 616);
            this.labelAmountLogins.Name = "labelAmountLogins";
            this.labelAmountLogins.Size = new System.Drawing.Size(0, 16);
            this.labelAmountLogins.TabIndex = 23;
            // 
            // buttonLoginExport
            // 
            this.buttonLoginExport.BackColor = System.Drawing.Color.Gray;
            this.buttonLoginExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLoginExport.Font = new System.Drawing.Font("Courier New", 10F);
            this.buttonLoginExport.Location = new System.Drawing.Point(919, 601);
            this.buttonLoginExport.Name = "buttonLoginExport";
            this.buttonLoginExport.Size = new System.Drawing.Size(151, 40);
            this.buttonLoginExport.TabIndex = 37;
            this.buttonLoginExport.Text = "Експорт";
            this.buttonLoginExport.UseVisualStyleBackColor = false;
            this.buttonLoginExport.Click += new System.EventHandler(this.buttonLoginExport_Click);
            // 
            // buttonLoginImport
            // 
            this.buttonLoginImport.BackColor = System.Drawing.Color.Gray;
            this.buttonLoginImport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLoginImport.Font = new System.Drawing.Font("Courier New", 10F);
            this.buttonLoginImport.Location = new System.Drawing.Point(762, 601);
            this.buttonLoginImport.Name = "buttonLoginImport";
            this.buttonLoginImport.Size = new System.Drawing.Size(151, 40);
            this.buttonLoginImport.TabIndex = 36;
            this.buttonLoginImport.Text = "Імпорт";
            this.buttonLoginImport.UseVisualStyleBackColor = false;
            this.buttonLoginImport.Click += new System.EventHandler(this.buttonLoginImport_Click);
            // 
            // logins_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.buttonLoginExport);
            this.Controls.Add(this.buttonLoginImport);
            this.Controls.Add(this.labelAmountLogins);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSearchLogin);
            this.Controls.Add(this.listViewLogins);
            this.Controls.Add(this.buttonAddLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label1);
            this.Name = "logins_form";
            this.Text = "logins_form";
            this.Load += new System.EventHandler(this.logins_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSearchLogin;
        private System.Windows.Forms.ListView listViewLogins;
        private System.Windows.Forms.Button buttonAddLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAmountLogins;
        private System.Windows.Forms.Button buttonLoginExport;
        private System.Windows.Forms.Button buttonLoginImport;
    }
}