using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Password_Manager.EditForms;
using System.Net.Http;
using PMLibrary.Forms.LoginManager;

namespace Password_Manager
{
    public partial class logins_form : Form
    {
        public logins_form()
        {
            InitializeComponent();
        }

        private void buttonAddLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text) || string.IsNullOrEmpty(textBoxUrl.Text))
            {
                MessageBox.Show("Введіть коректні значення!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!IsUrlValid(textBoxUrl.Text))
            {
                MessageBox.Show("Введіть коректний URL!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Login login = new Login
            {
                username = textBoxLogin.Text,
                url = textBoxUrl.Text
            };

            LoginManager loginManager = new LoginManager();
            loginManager.AddLogin(login);
            DisplayLogins();
            MessageBox.Show("Логін успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxLogin.Clear();
            textBoxUrl.Clear();
        }

        private bool IsUrlValid(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out Uri result)
                && (result.Scheme == Uri.UriSchemeHttp || result.Scheme == Uri.UriSchemeHttps);
        }

        private void DisplayLogins()
        {
            listViewLogins.Items.Clear();

            LoginManager loginManager = new LoginManager();
            loginManager.LoadLogins();

            foreach (Login login in loginManager.GetLogins())
            {
                listViewLogins.Items.Add(new ListViewItem(new[] { login.username, login.url }));
            }

            labelAmountLogins.Text = "Записів: " + loginManager.GetLogins().Count.ToString();
        }

        private void logins_form_Load(object sender, EventArgs e)
        {
            DisplayLogins();
        }

        private void textBoxSearchLogin_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearchLogin.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                DisplayLogins();
                return;
            }

            foreach (ListViewItem item in listViewLogins.Items)
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
                    listViewLogins.Items.Remove(item);
                }
            }
        }

        private void buttonLoginImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON файли (*.json)|*.json|Усі файли (*.*)|*.*";
            openFileDialog.Title = "Виберіть файл для імпорту";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sourceFilePath = openFileDialog.FileName;
                    LoginManager loginManager = new LoginManager();
                    string destinationFilePath = loginManager.filePath;

                    if (Path.GetExtension(sourceFilePath).ToLower() != ".json")
                    {
                        MessageBox.Show("Обраний файл не є JSON файлом.\nБудь ласка, виберіть файл із розширенням .json.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    File.Copy(sourceFilePath, destinationFilePath, true);

                    DisplayLogins();
                    MessageBox.Show($"Файл було успішно імпортовано.", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Сталася помилка під час копіювання файлу: {ex.Message}", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonLoginExport_Click(object sender, EventArgs e)
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            try
            {
                LoginManager loginManager = new LoginManager();
                string sourceFilePath = loginManager.filePath;
                string destinationFilePath = Path.Combine(documentsPath, "logins.json");

                if (File.Exists(sourceFilePath))
                {
                    string json = File.ReadAllText(sourceFilePath);

                    if (!string.IsNullOrEmpty(json) && json != "[]")
                    {
                        File.Copy(sourceFilePath, destinationFilePath, true);
                        MessageBox.Show($"Усі логіни було експортовано в\n{destinationFilePath}", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Файл логінів порожній!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Файл логінів не існує!\nДодайте хоча б один логін.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка під час копіювання файлу: " + ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewLogins_ItemActivate(object sender, EventArgs e)
        {
            if (listViewLogins.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewLogins.SelectedItems[0];

                int index = listViewLogins.SelectedItems[0].Index;
                string login = selectedItem.SubItems[0].Text;
                string url = selectedItem.SubItems[1].Text;
                if (ParentForm is FormMain mainForm)
                {
                    mainForm.PanelForm(new edit_login(index, login, url));
                }
            }
        }
    }
}