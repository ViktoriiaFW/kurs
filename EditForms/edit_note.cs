using System;
using System.Windows.Forms;
using PMLibrary.Forms.NoteManager;

namespace Password_Manager.EditForms
{
    public partial class edit_note : Form
    {
        private int selectedIndex;
        public edit_note(int index, string name, string noteText)
        {
            InitializeComponent();
            selectedIndex = index;
            textBoxNameNoteEdit.Text = name;
            textBoxNoteEdit.Text = noteText;
        }

        private void buttonNoteEdit_Click(object sender, EventArgs e)
        {
            string name = textBoxNameNoteEdit.Text;
            string noteText = textBoxNoteEdit.Text;

            NoteManager noteManager = new NoteManager();

            Note updatedNote = new Note
            {
                name = name,
                notevalue = noteText,
            };

            noteManager.UpdateNote(selectedIndex, updatedNote);
            MessageBox.Show("Дані нотатки було успішно відредаговано!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonNoteDelete_Click(object sender, EventArgs e)
        {
            NoteManager noteManager = new NoteManager();
            noteManager.DeleteNote(selectedIndex);
            MessageBox.Show("Нотатку було успішно видалено", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            textBoxNameNoteEdit.Clear();
            textBoxNoteEdit.Clear();
        }
    }
}
