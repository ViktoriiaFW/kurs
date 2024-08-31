using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using PMLibrary.Forms.CardManager;
using PMLibrary.Forms.NoteManager;
using PMLibrary.Forms.PassManager;
using PMLibrary.Forms.LoginManager;

namespace Password_Manager
{
    public partial class elements_form : Form
    {
        private PasswordManager passwordManager;
        private LoginManager loginManager;
        private CardManager cardManager;
        private NoteManager noteManager;
        public elements_form()
        {
            InitializeComponent();
            passwordManager = new PasswordManager();
            loginManager = new LoginManager();
            cardManager = new CardManager();
            noteManager = new NoteManager();
        }

        private void elements_form_Load(object sender, EventArgs e)
        {
            DisplayAllElements();
        }

        private void DisplayAllElements()
        {
            listViewAll.Items.Clear();

            PasswordManager passwordManager = new PasswordManager();
            passwordManager.LoadPasswords();
            List<Password> passwords = passwordManager.GetPasswords();

            LoginManager loginManager = new LoginManager();
            loginManager.LoadLogins();
            List<Login> logins = loginManager.GetLogins();

            NoteManager noteManager = new NoteManager();
            noteManager.LoadNotes();
            List<Note> notes = noteManager.GetNotes();

            CardManager cardManager = new CardManager();
            cardManager.LoadCards();
            List<Card> cards = cardManager.GetCards();

            listViewAll.GridLines = true;

            listViewAll.Items.Add("-------Паролі--------");

            foreach (Password password in passwords)
            {
                listViewAll.Items.Add(new ListViewItem(new[] { password.username, password.passwordvalue, password.url }));
            }

            listViewAll.Items.Add("-------Картки--------");

            foreach (Card card in cards)
            {
                listViewAll.Items.Add(new ListViewItem(new[] { card.bank, card.pin, card.cvv, card.expirydate }));
            }

            listViewAll.Items.Add("-------Логіни--------");

            foreach (Login login in logins) {
                listViewAll.Items.Add(new ListViewItem(new[] { login.username, login.url }));
            }

            listViewAll.Items.Add("-------Нотатки-------");

            foreach (Note note in notes)
            {
                listViewAll.Items.Add(new ListViewItem(new[] {note.name, note.notevalue}));
            }
        }
    }
}