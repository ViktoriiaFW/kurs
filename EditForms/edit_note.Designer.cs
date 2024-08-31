namespace Password_Manager.EditForms
{
    partial class edit_note
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
            this.textBoxNoteEdit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNameNoteEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNoteEdit = new System.Windows.Forms.Button();
            this.buttonNoteDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNoteEdit
            // 
            this.textBoxNoteEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.textBoxNoteEdit.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxNoteEdit.Location = new System.Drawing.Point(254, 223);
            this.textBoxNoteEdit.Multiline = true;
            this.textBoxNoteEdit.Name = "textBoxNoteEdit";
            this.textBoxNoteEdit.Size = new System.Drawing.Size(574, 275);
            this.textBoxNoteEdit.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(352, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 22);
            this.label2.TabIndex = 35;
            this.label2.Text = "Назва замітки";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxNameNoteEdit
            // 
            this.textBoxNameNoteEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxNameNoteEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxNameNoteEdit.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxNameNoteEdit.Location = new System.Drawing.Point(556, 163);
            this.textBoxNameNoteEdit.Name = "textBoxNameNoteEdit";
            this.textBoxNameNoteEdit.Size = new System.Drawing.Size(224, 30);
            this.textBoxNameNoteEdit.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(349, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 37);
            this.label1.TabIndex = 33;
            this.label1.Text = "Редагування нотатки";
            // 
            // buttonNoteEdit
            // 
            this.buttonNoteEdit.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonNoteEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNoteEdit.Font = new System.Drawing.Font("Courier New", 12F);
            this.buttonNoteEdit.Location = new System.Drawing.Point(308, 534);
            this.buttonNoteEdit.Name = "buttonNoteEdit";
            this.buttonNoteEdit.Size = new System.Drawing.Size(224, 56);
            this.buttonNoteEdit.TabIndex = 68;
            this.buttonNoteEdit.Text = "Редагувати";
            this.buttonNoteEdit.UseVisualStyleBackColor = false;
            this.buttonNoteEdit.Click += new System.EventHandler(this.buttonNoteEdit_Click);
            // 
            // buttonNoteDelete
            // 
            this.buttonNoteDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonNoteDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNoteDelete.Font = new System.Drawing.Font("Courier New", 12F);
            this.buttonNoteDelete.Location = new System.Drawing.Point(556, 534);
            this.buttonNoteDelete.Name = "buttonNoteDelete";
            this.buttonNoteDelete.Size = new System.Drawing.Size(224, 56);
            this.buttonNoteDelete.TabIndex = 67;
            this.buttonNoteDelete.Text = "Видалити";
            this.buttonNoteDelete.UseVisualStyleBackColor = false;
            this.buttonNoteDelete.Click += new System.EventHandler(this.buttonNoteDelete_Click);
            // 
            // edit_note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.buttonNoteEdit);
            this.Controls.Add(this.buttonNoteDelete);
            this.Controls.Add(this.textBoxNoteEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNameNoteEdit);
            this.Controls.Add(this.label1);
            this.Name = "edit_note";
            this.Text = "edit_note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNoteEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNameNoteEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNoteEdit;
        private System.Windows.Forms.Button buttonNoteDelete;
    }
}