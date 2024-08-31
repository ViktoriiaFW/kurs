using Password_Manager.EditForms;
using System;
using System.IO;
using System.Windows.Forms;
using PMLibrary.Forms.NoteManager;

namespace Password_Manager
{
    public partial class notes_form : Form
    {
        public notes_form()
        {
            InitializeComponent();
        }

        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNameNote.Text) || string.IsNullOrEmpty(textBoxNote.Text))
            {
                MessageBox.Show("Введіть коректні значення!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBoxNameNote.Text.Length > 30)
            {
                MessageBox.Show("Назва не може бути більше 30 символів!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Note note = new Note
            {
                name = textBoxNameNote.Text,
                notevalue = textBoxNote.Text
            };

            NoteManager noteManager = new NoteManager();
            noteManager.AddNote(note);
            DisplayNotes();
            MessageBox.Show("Нотатка успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxNameNote.Clear();
            textBoxNote.Clear();
        }

        private void DisplayNotes()
        {
            listViewNotes.Items.Clear();

            NoteManager noteManager = new NoteManager();
            noteManager.LoadNotes();

            foreach (Note note in noteManager.GetNotes())
            {
                listViewNotes.Items.Add(new ListViewItem(new[] { note.name, note.notevalue }));
            }

            labelAmountNotes.Text = "Записів: " + noteManager.GetNotes().Count.ToString();
        }

        private void notes_form_Load(object sender, EventArgs e)
        {
            DisplayNotes();
        }

        private void textBoxSearchNote_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearchNote.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                DisplayNotes();
                return;
            }

            foreach (ListViewItem item in listViewNotes.Items)
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
                    listViewNotes.Items.Remove(item);
                }
            }
        }

        private void buttonNotesImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON файли (*.json)|*.json|Усі файли (*.*)|*.*";
            openFileDialog.Title = "Виберіть файл для імпорту";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sourceFilePath = openFileDialog.FileName;
                    NoteManager noteManager = new NoteManager();
                    string destinationFilePath = noteManager.filePath;

                    if (Path.GetExtension(sourceFilePath).ToLower() != ".json")
                    {
                        MessageBox.Show("Обраний файл не є JSON файлом.\nБудь ласка, виберіть файл із розширенням .json.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    File.Copy(sourceFilePath, destinationFilePath, true);

                    DisplayNotes();
                    MessageBox.Show($"Файл було успішно імпортовано.", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Сталася помилка під час копіювання файлу: {ex.Message}", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonNotesExport_Click(object sender, EventArgs e)
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            try
            {
                NoteManager noteManager = new NoteManager();
                string sourceFilePath = noteManager.filePath;
                string destinationFilePath = Path.Combine(documentsPath, "notes.json");

                if (File.Exists(sourceFilePath))
                {
                    File.Copy(sourceFilePath, destinationFilePath, true);
                    MessageBox.Show($"Усі нотатки було експортовано в\n{destinationFilePath}", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Файл нотаток не існує!\nДодайте хоча б одну нотатку.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка під час копіювання файлу: " + ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewNotes_ItemActivate(object sender, EventArgs e)
        {
            if (listViewNotes.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewNotes.SelectedItems[0];

                int index = listViewNotes.SelectedItems[0].Index;
                string name = selectedItem.SubItems[0].Text;
                string text = selectedItem.SubItems[1].Text;
                if (ParentForm is FormMain mainForm)
                {
                    mainForm.PanelForm(new edit_note(index, name, text));
                }
            }
        }
    }
}
