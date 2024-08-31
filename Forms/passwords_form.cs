using System;
using System.Windows.Forms;
using System.IO;
using PMLibrary.Forms.PassManager;

namespace Password_Manager
{
    public partial class passwords_form : Form
    {
        public passwords_form()
        {
            InitializeComponent();
        }

        private void passwords_form_Load(object sender, EventArgs e)
        {
            DisplayPasswords();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" || textBoxPassword.Text == "" || textBoxUrl.Text == "")
            {
                MessageBox.Show("Введіть коректні значення!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!IsUrlValid(textBoxUrl.Text))
            {
                MessageBox.Show("Введіть коректний URL!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Password password = new Password
            {
                username = textBoxLogin.Text,
                passwordvalue = textBoxPassword.Text,
                url = textBoxUrl.Text
            };

            PasswordManager passwordManager = new PasswordManager();
            passwordManager.AddPassword(password);
            DisplayPasswords();
            MessageBox.Show("Пароль успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxLogin.Clear();
            textBoxPassword.Clear();
            textBoxUrl.Clear();
        }

        private bool IsUrlValid(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out Uri result)
                && (result.Scheme == Uri.UriSchemeHttp || result.Scheme == Uri.UriSchemeHttps);
        }

        private void DisplayPasswords()
        {
            listViewPasswords.Items.Clear();

            PasswordManager passwordManager = new PasswordManager();
            passwordManager.LoadPasswords();

            foreach (Password password in passwordManager.GetPasswords())
            {
                listViewPasswords.Items.Add(new ListViewItem(new[] { password.username, password.passwordvalue, password.url }));
            }

            labelAmountPass.Text = "Записів: " + passwordManager.GetPasswords().Count.ToString();
        }

        private void listViewPasswords_ItemActivate(object sender, EventArgs e)
        {
            if (listViewPasswords.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewPasswords.SelectedItems[0];

                int index = listViewPasswords.SelectedItems[0].Index;
                string username = selectedItem.SubItems[0].Text;
                string passwordValue = selectedItem.SubItems[1].Text;
                string url = selectedItem.SubItems[2].Text;

                if (ParentForm is FormMain mainForm)
                {
                    mainForm.PanelForm(new edit_password(index, username, passwordValue, url));
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearchPassword.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                DisplayPasswords();
                return;
            }

            foreach (ListViewItem item in listViewPasswords.Items)
            {
                bool matchesSearch = item.Text.ToLower().Contains(searchText);
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    matchesSearch |= subItem.Text.ToLower().Contains(searchText);
                }

                if (matchesSearch)
                {
                    item.EnsureVisible();
                }
                else
                {
                    listViewPasswords.Items.Remove(item);
                }
            }
        }

        private void buttonPassExport_Click(object sender, EventArgs e)
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            try
            {
                PasswordManager passwordManager = new PasswordManager();
                string sourceFilePath = passwordManager.filePath;
                string destinationFilePath = Path.Combine(documentsPath, "password.json");

                if (File.Exists(sourceFilePath))
                {
                    File.Copy(sourceFilePath, destinationFilePath, true);
                    MessageBox.Show($"Усі паролі було експортовано в\n{destinationFilePath}", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Файл паролів не існує!\nДодайте хоча б один пароль.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка під час копіювання файлу: " + ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPassImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON файли (*.json)|*.json|Усі файли (*.*)|*.*";
            openFileDialog.Title = "Виберіть файл для імпорту";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sourceFilePath = openFileDialog.FileName;
                    PasswordManager passwordManager = new PasswordManager();
                    string destinationFilePath = passwordManager.filePath;

                    if (Path.GetExtension(sourceFilePath).ToLower() != ".json")
                    {
                        MessageBox.Show("Обраний файл не є JSON файлом.\nБудь ласка, виберіть файл із розширенням .json.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    File.Copy(sourceFilePath, destinationFilePath, true);

                    DisplayPasswords();
                    MessageBox.Show($"Файл було успішно імпортовано.", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Сталася помилка під час копіювання файлу: {ex.Message}", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}