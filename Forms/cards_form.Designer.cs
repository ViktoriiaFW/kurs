namespace Password_Manager
{
    partial class cards_form
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
            this.buttonAddCard = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.textBoxBank = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCvv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSearchCard = new System.Windows.Forms.TextBox();
            this.listViewCards = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPin = new System.Windows.Forms.TextBox();
            this.labelAmountCards = new System.Windows.Forms.Label();
            this.buttonCardExport = new System.Windows.Forms.Button();
            this.buttonCardImport = new System.Windows.Forms.Button();
            this.textBoxPickerDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddCard
            // 
            this.buttonAddCard.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonAddCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddCard.Font = new System.Drawing.Font("Courier New", 12F);
            this.buttonAddCard.Location = new System.Drawing.Point(560, 503);
            this.buttonAddCard.Name = "buttonAddCard";
            this.buttonAddCard.Size = new System.Drawing.Size(224, 56);
            this.buttonAddCard.TabIndex = 16;
            this.buttonAddCard.Text = "Додати";
            this.buttonAddCard.UseVisualStyleBackColor = false;
            this.buttonAddCard.Click += new System.EventHandler(this.buttonAddCard_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(383, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Введіть PIN код картки";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(407, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Введіть номер картки";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(419, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Введіть назву банку";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBoxCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCardNumber.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxCardNumber.Location = new System.Drawing.Point(697, 262);
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(224, 30);
            this.textBoxCardNumber.TabIndex = 11;
            // 
            // textBoxBank
            // 
            this.textBoxBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBoxBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxBank.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxBank.Location = new System.Drawing.Point(697, 189);
            this.textBoxBank.Name = "textBoxBank";
            this.textBoxBank.Size = new System.Drawing.Size(224, 30);
            this.textBoxBank.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(440, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Додавання нової картки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(383, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Введіть CVV/CVC картки";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxCvv
            // 
            this.textBoxCvv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBoxCvv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCvv.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxCvv.Location = new System.Drawing.Point(697, 325);
            this.textBoxCvv.Name = "textBoxCvv";
            this.textBoxCvv.Size = new System.Drawing.Size(224, 30);
            this.textBoxCvv.TabIndex = 18;
            this.textBoxCvv.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(59, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Пошук";
            // 
            // textBoxSearchCard
            // 
            this.textBoxSearchCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBoxSearchCard.Font = new System.Drawing.Font("Courier New", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchCard.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxSearchCard.Location = new System.Drawing.Point(37, 34);
            this.textBoxSearchCard.Name = "textBoxSearchCard";
            this.textBoxSearchCard.Size = new System.Drawing.Size(214, 32);
            this.textBoxSearchCard.TabIndex = 20;
            this.textBoxSearchCard.TextChanged += new System.EventHandler(this.textBoxSearchCard_TextChanged);
            // 
            // listViewCards
            // 
            this.listViewCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.listViewCards.Font = new System.Drawing.Font("Courier New", 11F);
            this.listViewCards.ForeColor = System.Drawing.Color.Transparent;
            this.listViewCards.HideSelection = false;
            listViewItem1.UseItemStyleForSubItems = false;
            this.listViewCards.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewCards.Location = new System.Drawing.Point(12, 72);
            this.listViewCards.Name = "listViewCards";
            this.listViewCards.Size = new System.Drawing.Size(262, 569);
            this.listViewCards.TabIndex = 19;
            this.listViewCards.UseCompatibleStateImageBehavior = false;
            this.listViewCards.View = System.Windows.Forms.View.List;
            this.listViewCards.ItemActivate += new System.EventHandler(this.listViewCards_ItemActivate);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(503, 447);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Введіть дату";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPin
            // 
            this.textBoxPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBoxPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPin.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxPin.Location = new System.Drawing.Point(697, 384);
            this.textBoxPin.Name = "textBoxPin";
            this.textBoxPin.Size = new System.Drawing.Size(224, 30);
            this.textBoxPin.TabIndex = 24;
            this.textBoxPin.UseSystemPasswordChar = true;
            // 
            // labelAmountCards
            // 
            this.labelAmountCards.AutoSize = true;
            this.labelAmountCards.ForeColor = System.Drawing.Color.Transparent;
            this.labelAmountCards.Location = new System.Drawing.Point(34, 614);
            this.labelAmountCards.Name = "labelAmountCards";
            this.labelAmountCards.Size = new System.Drawing.Size(0, 16);
            this.labelAmountCards.TabIndex = 25;
            // 
            // buttonCardExport
            // 
            this.buttonCardExport.BackColor = System.Drawing.Color.Gray;
            this.buttonCardExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCardExport.Font = new System.Drawing.Font("Courier New", 10F);
            this.buttonCardExport.Location = new System.Drawing.Point(919, 599);
            this.buttonCardExport.Name = "buttonCardExport";
            this.buttonCardExport.Size = new System.Drawing.Size(151, 40);
            this.buttonCardExport.TabIndex = 28;
            this.buttonCardExport.Text = "Експорт";
            this.buttonCardExport.UseVisualStyleBackColor = false;
            this.buttonCardExport.Click += new System.EventHandler(this.buttonCardExport_Click);
            // 
            // buttonCardImport
            // 
            this.buttonCardImport.BackColor = System.Drawing.Color.Gray;
            this.buttonCardImport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCardImport.Font = new System.Drawing.Font("Courier New", 10F);
            this.buttonCardImport.Location = new System.Drawing.Point(762, 599);
            this.buttonCardImport.Name = "buttonCardImport";
            this.buttonCardImport.Size = new System.Drawing.Size(151, 40);
            this.buttonCardImport.TabIndex = 27;
            this.buttonCardImport.Text = "Імпорт";
            this.buttonCardImport.UseVisualStyleBackColor = false;
            this.buttonCardImport.Click += new System.EventHandler(this.buttonCardImport_Click);
            // 
            // textBoxPickerDate
            // 
            this.textBoxPickerDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBoxPickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPickerDate.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxPickerDate.Location = new System.Drawing.Point(697, 441);
            this.textBoxPickerDate.Name = "textBoxPickerDate";
            this.textBoxPickerDate.Size = new System.Drawing.Size(224, 30);
            this.textBoxPickerDate.TabIndex = 39;
            // 
            // cards_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.textBoxPickerDate);
            this.Controls.Add(this.buttonCardExport);
            this.Controls.Add(this.buttonCardImport);
            this.Controls.Add(this.labelAmountCards);
            this.Controls.Add(this.textBoxPin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSearchCard);
            this.Controls.Add(this.listViewCards);
            this.Controls.Add(this.textBoxCvv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAddCard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCardNumber);
            this.Controls.Add(this.textBoxBank);
            this.Controls.Add(this.label1);
            this.Name = "cards_form";
            this.Text = "cards_form";
            this.Load += new System.EventHandler(this.cards_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddCard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCardNumber;
        private System.Windows.Forms.TextBox textBoxBank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCvv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSearchCard;
        private System.Windows.Forms.ListView listViewCards;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPin;
        private System.Windows.Forms.Label labelAmountCards;
        private System.Windows.Forms.Button buttonCardExport;
        private System.Windows.Forms.Button buttonCardImport;
        private System.Windows.Forms.TextBox textBoxPickerDate;
    }
}