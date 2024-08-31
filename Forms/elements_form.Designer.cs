namespace Password_Manager
{
    partial class elements_form
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSearchAll = new System.Windows.Forms.TextBox();
            this.listViewAll = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(544, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Усі елементи";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("High Tower Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(59, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Пошук";
            // 
            // textBoxSearchAll
            // 
            this.textBoxSearchAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBoxSearchAll.Font = new System.Drawing.Font("Courier New", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchAll.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxSearchAll.Location = new System.Drawing.Point(37, 34);
            this.textBoxSearchAll.Name = "textBoxSearchAll";
            this.textBoxSearchAll.Size = new System.Drawing.Size(214, 32);
            this.textBoxSearchAll.TabIndex = 24;
            // 
            // listViewAll
            // 
            this.listViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.listViewAll.Font = new System.Drawing.Font("Courier New", 11F);
            this.listViewAll.ForeColor = System.Drawing.Color.Transparent;
            this.listViewAll.HideSelection = false;
            listViewItem1.UseItemStyleForSubItems = false;
            this.listViewAll.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewAll.Location = new System.Drawing.Point(12, 72);
            this.listViewAll.Name = "listViewAll";
            this.listViewAll.Size = new System.Drawing.Size(262, 569);
            this.listViewAll.TabIndex = 23;
            this.listViewAll.UseCompatibleStateImageBehavior = false;
            this.listViewAll.View = System.Windows.Forms.View.List;
            // 
            // elements_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSearchAll);
            this.Controls.Add(this.listViewAll);
            this.Controls.Add(this.label1);
            this.Name = "elements_form";
            this.Text = "elements_form";
            this.Load += new System.EventHandler(this.elements_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSearchAll;
        private System.Windows.Forms.ListView listViewAll;
    }
}