using System;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class FormMain : Form
    {
        private Form active;
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelForm(new elements_form());
        }

        public void PanelForm(Form fm)
        {
            if (active != null)
                active.Close();

            active = fm;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fm);
            this.panel1.Tag = fm;
            fm.BringToFront();
            fm.Show();
        }

        private void el_button_Click(object sender, EventArgs e)
        {
            PanelForm(new elements_form());
        }

        private void password_button_Click(object sender, EventArgs e)
        {
            PanelForm(new passwords_form());
        }

        private void cards_button_Click(object sender, EventArgs e)
        {
            PanelForm(new cards_form());
        }

        private void logins_button_Click(object sender, EventArgs e)
        {
            PanelForm(new logins_form());
        }

        private void notes_button_Click(object sender, EventArgs e)
        {
            PanelForm(new notes_form());
        }

        private void buttonGeneration_Click(object sender, EventArgs e)
        {
            PanelForm(new gen_form());
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ви вийшли з аккаунту.\nАвторизуйтесь ще раз.", "Вихід з аккаунту", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}