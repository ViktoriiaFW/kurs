using System;
using System.Windows.Forms;
using PMLibrary.Forms.PassManager;

namespace Password_Manager
{
    public partial class edit_password : Form
    {
        private int selectedIndex;
        public edit_password(int index, string username, string password, string url)
        {
            InitializeComponent();
            selectedIndex = index;
            textBoxLoginEdit.Text = username;
            textBoxPasswordEdit.Text = password;
            textBoxUrlEdit.Text = url;
        }

        private void buttonPasswordEdit_Click(object sender, EventArgs e)
        {
            string newUsername = textBoxLoginEdit.Text;
            string newPassword = textBoxPasswordEdit.Text;
            string newUrl = textBoxUrlEdit.Text;

            PasswordManager passwordManager = new PasswordManager();

            Password updatedPassword = new Password
            {
                username = newUsername,
                passwordvalue = newPassword,
                url = newUrl
            };

            passwordManager.UpdatePassword(selectedIndex, updatedPassword);
            MessageBox.Show("Пароль успішно відредагований", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDeletePass_Click(object sender, EventArgs e)
        {
            PasswordManager passwordManager = new PasswordManager();
            passwordManager.DeletePassword(selectedIndex);
            MessageBox.Show("Пароль було успішно видалено", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            textBoxLoginEdit.Clear();
            textBoxPasswordEdit.Clear();
            textBoxUrlEdit.Clear();
        }
    }
}