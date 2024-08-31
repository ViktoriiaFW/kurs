namespace Password_Manager
{
    partial class gen_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGenNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddCard = new System.Windows.Forms.Button();
            this.textBoxPassResult = new System.Windows.Forms.TextBox();
            this.buttonPassCopy = new System.Windows.Forms.Button();
            this.buttonResetPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(411, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Генерування";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 15F);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(74, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Пароль";
            // 
            // textBoxGenNumber
            // 
            this.textBoxGenNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBoxGenNumber.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxGenNumber.Location = new System.Drawing.Point(535, 285);
            this.textBoxGenNumber.Name = "textBoxGenNumber";
            this.textBoxGenNumber.Size = new System.Drawing.Size(113, 22);
            this.textBoxGenNumber.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 10F);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(233, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Введіть кількість знаків:";
            // 
            // buttonAddCard
            // 
            this.buttonAddCard.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonAddCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddCard.Font = new System.Drawing.Font("Courier New", 10F);
            this.buttonAddCard.Location = new System.Drawing.Point(668, 278);
            this.buttonAddCard.Name = "buttonAddCard";
            this.buttonAddCard.Size = new System.Drawing.Size(151, 36);
            this.buttonAddCard.TabIndex = 17;
            this.buttonAddCard.Text = "Згенерувати";
            this.buttonAddCard.UseVisualStyleBackColor = false;
            this.buttonAddCard.Click += new System.EventHandler(this.buttonAddCard_Click);
            // 
            // textBoxPassResult
            // 
            this.textBoxPassResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBoxPassResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxPassResult.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxPassResult.Location = new System.Drawing.Point(836, 285);
            this.textBoxPassResult.Name = "textBoxPassResult";
            this.textBoxPassResult.ReadOnly = true;
            this.textBoxPassResult.Size = new System.Drawing.Size(149, 24);
            this.textBoxPassResult.TabIndex = 18;
            this.textBoxPassResult.Visible = false;
            // 
            // buttonPassCopy
            // 
            this.buttonPassCopy.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonPassCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPassCopy.Font = new System.Drawing.Font("Courier New", 9F);
            this.buttonPassCopy.Location = new System.Drawing.Point(991, 269);
            this.buttonPassCopy.Name = "buttonPassCopy";
            this.buttonPassCopy.Size = new System.Drawing.Size(79, 25);
            this.buttonPassCopy.TabIndex = 20;
            this.buttonPassCopy.Text = "Copy";
            this.buttonPassCopy.UseVisualStyleBackColor = false;
            this.buttonPassCopy.Visible = false;
            this.buttonPassCopy.Click += new System.EventHandler(this.buttonPassCopy_Click);
            // 
            // buttonResetPass
            // 
            this.buttonResetPass.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonResetPass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonResetPass.Font = new System.Drawing.Font("Courier New", 9F);
            this.buttonResetPass.Location = new System.Drawing.Point(991, 300);
            this.buttonResetPass.Name = "buttonResetPass";
            this.buttonResetPass.Size = new System.Drawing.Size(79, 25);
            this.buttonResetPass.TabIndex = 21;
            this.buttonResetPass.Text = "Reset";
            this.buttonResetPass.UseVisualStyleBackColor = false;
            this.buttonResetPass.Visible = false;
            this.buttonResetPass.Click += new System.EventHandler(this.buttonResetPass_Click);
            // 
            // gen_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.buttonResetPass);
            this.Controls.Add(this.buttonPassCopy);
            this.Controls.Add(this.textBoxPassResult);
            this.Controls.Add(this.buttonAddCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxGenNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "gen_form";
            this.Text = "gen_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGenNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddCard;
        private System.Windows.Forms.TextBox textBoxPassResult;
        private System.Windows.Forms.Button buttonPassCopy;
        private System.Windows.Forms.Button buttonResetPass;
    }
}