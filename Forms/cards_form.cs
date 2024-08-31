using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using PMLibrary.Forms.CardManager;

namespace Password_Manager
{
    public partial class cards_form : Form
    {
        public cards_form()
        {
            InitializeComponent();
        }

        private void cards_form_Load(object sender, EventArgs e)
        {
            DisplayCards();
        }

        private void buttonAddCard_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxBank.Text)
                || string.IsNullOrEmpty(textBoxCardNumber.Text)
                || textBoxCardNumber.Text.Length < 16
                || string.IsNullOrEmpty(textBoxCvv.Text)
                || textBoxCvv.Text.Length < 3)
            {
                MessageBox.Show("Введіть коректні значення!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime currentDate = DateTime.Now;
            DateTime pickedDate;
            if (!DateTime.TryParseExact(textBoxPickerDate.Text, new[] { "MM/yy", "MM/yyyy" }, CultureInfo.InvariantCulture, DateTimeStyles.None, out pickedDate))
            {
                MessageBox.Show("Введено неправильну дату!\nВведіть у форматі mm/yyyyy або mm/yyy", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else if (pickedDate <= currentDate.AddDays(30)) {
                MessageBox.Show("Термін вашої картки має закінчуватися не раніше ніж через місяць!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Card card = new Card
            {
                bank = textBoxBank.Text,
                cardnumber = textBoxCardNumber.Text,
                expirydate = textBoxPickerDate.Text,
                cvv = textBoxCvv.Text,
                pin = textBoxPin.Text
            };

            SaveCardToJson(card);
            DisplayCards();
            MessageBox.Show("Карту успішно додано.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxBank.Clear();
            textBoxCardNumber.Clear();
            textBoxCvv.Clear();
            textBoxPin.Clear();
            textBoxPickerDate.Clear();
        }

        private void DisplayCards()
        {
            listViewCards.Items.Clear();

            CardManager cardManager = new CardManager();
            cardManager.LoadCards();

            foreach (Card card in cardManager.GetCards())
            {
                listViewCards.Items.Add(new ListViewItem(new[] { card.bank, card.cardnumber, card.expirydate, card.cvv, card.pin }));
            }

            labelAmountCards.Text = "Записів: " + cardManager.GetCards().Count.ToString();
        }

        private void SaveCardToJson(Card card)
        {
            CardManager cardManager = new CardManager();
            cardManager.AddCard(card);
        }

        private void textBoxSearchCard_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearchCard.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                DisplayCards();
                return;
            }

            foreach (ListViewItem item in listViewCards.Items)
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
                    listViewCards.Items.Remove(item);
                }
            }
        }

        private void buttonCardImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON файли (*.json)|*.json|Усі файли (*.*)|*.*";
            openFileDialog.Title = "Виберіть файл для імпорту";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sourceFilePath = openFileDialog.FileName;
                    CardManager cardManager = new CardManager();
                    string destinationFilePath = cardManager.filePath;

                    if (Path.GetExtension(sourceFilePath).ToLower() != ".json")
                    {
                        MessageBox.Show("Обраний файл не є JSON файлом.\nБудь ласка, виберіть файл із розширенням .json.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    File.Copy(sourceFilePath, destinationFilePath, true);

                    DisplayCards();
                    MessageBox.Show($"Файл було успішно імпортовано.", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Сталася помилка під час копіювання файлу: {ex.Message}", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonCardExport_Click(object sender, EventArgs e)
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            try
            {
                CardManager cardManager = new CardManager();
                string sourceFilePath = cardManager.filePath;
                string destinationFilePath = Path.Combine(documentsPath, "cards.json");

                if (File.Exists(sourceFilePath))
                {
                    File.Copy(sourceFilePath, destinationFilePath, true);
                    MessageBox.Show($"Усі картки було експортовано в\n{destinationFilePath}", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Файл карток не існує!\nДодайте хоча б одну картку.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка під час копіювання файлу: " + ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewCards_ItemActivate(object sender, EventArgs e)
        {
            if (listViewCards.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewCards.SelectedItems[0];

                int index = listViewCards.SelectedItems[0].Index;
                string nameBank = selectedItem.SubItems[0].Text;
                string numberCard = selectedItem.SubItems[1].Text;
                string dateTime = selectedItem.SubItems[2].Text;
                string pin = selectedItem.SubItems[3].Text;
                string cvv = selectedItem.SubItems[4].Text;
                if (ParentForm is FormMain mainForm)
                {
                    mainForm.PanelForm(new edit_card(index, nameBank, numberCard, cvv, pin, dateTime));
                }
            }
        }
    }
}