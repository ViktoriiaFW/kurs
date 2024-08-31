using System;
using System.Windows.Forms;
using PMLibrary.Forms.LoginManager;

namespace Password_Manager.EditForms
{
    public partial class edit_login : Form
    {
        private int selectedIndex;
        public edit_login(int index, string login, string url)
        {
            InitializeComponent();
            selectedIndex = index;
            textBoxLoginEdit.Text = login;
            textBoxUrlEdit.Text = url;
        }

        private void buttonLoginEdit_Click(object sender, EventArgs e)
        {
            if (!IsUrlValid(textBoxUrlEdit.Text))
            {
                MessageBox.Show("Введіть коректний URL!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string newLogin = textBoxLoginEdit.Text;
            string newUrl = textBoxUrlEdit.Text;

            LoginManager loginManager = new LoginManager();

            Login updatedLogin = new Login
            {
                username = newLogin,
                url = newUrl,
            };

            loginManager.UpdateLogin(selectedIndex, updatedLogin);
            MessageBox.Show("Дані логіну було успішно відредаговано!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonDeleteLogin_Click(object sender, EventArgs e)
        {
            LoginManager loginManager = new LoginManager();
            loginManager.DeleteLogin(selectedIndex);
            MessageBox.Show("Логін було успішно видалено", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            textBoxLoginEdit.Clear();
            textBoxUrlEdit.Clear();
        }

        private bool IsUrlValid(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out Uri result)
                && (result.Scheme == Uri.UriSchemeHttp || result.Scheme == Uri.UriSchemeHttps);
        }
    }
}
