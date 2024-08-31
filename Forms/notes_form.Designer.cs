namespace Password_Manager
{
    partial class notes_form
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
            this.textBoxSearchNote = new System.Windows.Forms.TextBox();
            this.listViewNotes = new System.Windows.Forms.ListView();
            this.buttonAddNote = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNameNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.labelAmountNotes = new System.Windows.Forms.Label();
            this.buttonNotesExport = new System.Windows.Forms.Button();
            this.buttonNotesImport = new System.Windows.Forms.Button();
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
            this.label5.TabIndex = 31;
            this.label5.Text = "Пошук";
            // 
            // textBoxSearchNote
            // 
            this.textBoxSearchNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBoxSearchNote.Font = new System.Drawing.Font("Courier New", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchNote.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxSearchNote.Location = new System.Drawing.Point(37, 34);
            this.textBoxSearchNote.Name = "textBoxSearchNote";
            this.textBoxSearchNote.Size = new System.Drawing.Size(214, 32);
            this.textBoxSearchNote.TabIndex = 30;
            this.textBoxSearchNote.TextChanged += new System.EventHandler(this.textBoxSearchNote_TextChanged);
            // 
            // listViewNotes
            // 
            this.listViewNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.listViewNotes.Font = new System.Drawing.Font("Courier New", 11F);
            this.listViewNotes.ForeColor = System.Drawing.Color.Transparent;
            this.listViewNotes.HideSelection = false;
            listViewItem1.UseItemStyleForSubItems = false;
            this.listViewNotes.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewNotes.Location = new System.Drawing.Point(12, 72);
            this.listViewNotes.Name = "listViewNotes";
            this.listViewNotes.Size = new System.Drawing.Size(262, 569);
            this.listViewNotes.TabIndex = 29;
            this.listViewNotes.UseCompatibleStateImageBehavior = false;
            this.listViewNotes.View = System.Windows.Forms.View.List;
            this.listViewNotes.ItemActivate += new System.EventHandler(this.listViewNotes_ItemActivate);
            // 
            // buttonAddNote
            // 
            this.buttonAddNote.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddNote.Font = new System.Drawing.Font("Courier New", 12F);
            this.buttonAddNote.Location = new System.Drawing.Point(545, 536);
            this.buttonAddNote.Name = "buttonAddNote";
            this.buttonAddNote.Size = new System.Drawing.Size(224, 56);
            this.buttonAddNote.TabIndex = 28;
            this.buttonAddNote.Text = "Додати";
            this.buttonAddNote.UseVisualStyleBackColor = false;
            this.buttonAddNote.Click += new System.EventHandler(this.buttonAddNote_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(389, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Введіть назву замітки";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxNameNote
            // 
            this.textBoxNameNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxNameNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxNameNote.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxNameNote.Location = new System.Drawing.Point(686, 173);
            this.textBoxNameNote.Name = "textBoxNameNote";
            this.textBoxNameNote.Size = new System.Drawing.Size(224, 30);
            this.textBoxNameNote.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(421, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 37);
            this.label1.TabIndex = 23;
            this.label1.Text = "Додавання нової нотатки";
            // 
            // textBoxNote
            // 
            this.textBoxNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.textBoxNote.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxNote.Location = new System.Drawing.Point(366, 233);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(574, 275);
            this.textBoxNote.TabIndex = 32;
            // 
            // labelAmountNotes
            // 
            this.labelAmountNotes.AutoSize = true;
            this.labelAmountNotes.ForeColor = System.Drawing.Color.Transparent;
            this.labelAmountNotes.Location = new System.Drawing.Point(34, 613);
            this.labelAmountNotes.Name = "labelAmountNotes";
            this.labelAmountNotes.Size = new System.Drawing.Size(0, 16);
            this.labelAmountNotes.TabIndex = 33;
            // 
            // buttonNotesExport
            // 
            this.buttonNotesExport.BackColor = System.Drawing.Color.Gray;
            this.buttonNotesExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNotesExport.Font = new System.Drawing.Font("Courier New", 10F);
            this.buttonNotesExport.Location = new System.Drawing.Point(892, 601);
            this.buttonNotesExport.Name = "buttonNotesExport";
            this.buttonNotesExport.Size = new System.Drawing.Size(151, 40);
            this.buttonNotesExport.TabIndex = 35;
            this.buttonNotesExport.Text = "Експорт";
            this.buttonNotesExport.UseVisualStyleBackColor = false;
            this.buttonNotesExport.Click += new System.EventHandler(this.buttonNotesExport_Click);
            // 
            // buttonNotesImport
            // 
            this.buttonNotesImport.BackColor = System.Drawing.Color.Gray;
            this.buttonNotesImport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNotesImport.Font = new System.Drawing.Font("Courier New", 10F);
            this.buttonNotesImport.Location = new System.Drawing.Point(735, 601);
            this.buttonNotesImport.Name = "buttonNotesImport";
            this.buttonNotesImport.Size = new System.Drawing.Size(151, 40);
            this.buttonNotesImport.TabIndex = 34;
            this.buttonNotesImport.Text = "Імпорт";
            this.buttonNotesImport.UseVisualStyleBackColor = false;
            this.buttonNotesImport.Click += new System.EventHandler(this.buttonNotesImport_Click);
            // 
            // notes_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.buttonNotesExport);
            this.Controls.Add(this.buttonNotesImport);
            this.Controls.Add(this.labelAmountNotes);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSearchNote);
            this.Controls.Add(this.listViewNotes);
            this.Controls.Add(this.buttonAddNote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNameNote);
            this.Controls.Add(this.label1);
            this.Name = "notes_form";
            this.Text = "notes_form";
            this.Load += new System.EventHandler(this.notes_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSearchNote;
        private System.Windows.Forms.ListView listViewNotes;
        private System.Windows.Forms.Button buttonAddNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNameNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Label labelAmountNotes;
        private System.Windows.Forms.Button buttonNotesExport;
        private System.Windows.Forms.Button buttonNotesImport;
    }
}