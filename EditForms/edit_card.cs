using System;
using System.Windows.Forms;
using PMLibrary.Forms.CardManager;

namespace Password_Manager
{
    public partial class edit_card : Form
    {
        private int selectedIndex;
        public edit_card(int index, string nameBank, string numberCard, string cvv, string pin, string dateTime)
        {
            InitializeComponent();
            selectedIndex = index;
            textBoxBankEdit.Text = nameBank;
            textBoxCardNumberEdit.Text = numberCard;
            textBoxCvvEdit.Text = cvv.ToString();
            textBoxPinEdit.Text = pin.ToString();
            textBoxPickerDateEdit.Text = dateTime;
        }

        private void buttonEditCard_Click(object sender, EventArgs e)
        {
            string newBankName = textBoxBankEdit.Text;
            string newCardNumber = textBoxCardNumberEdit.Text;
            string newCvv = textBoxCvvEdit.Text;
            string newPin = textBoxPinEdit.Text;
            string newExpiryDate = textBoxPickerDateEdit.Text;

            CardManager cardManager = new CardManager();

            Card updatedCard = new Card
            {
                bank = newBankName,
                cardnumber = newCardNumber,
                cvv = newCvv,
                pin = newPin,
                expirydate = newExpiryDate,
            };

            cardManager.UpdateCard(selectedIndex, updatedCard);
            MessageBox.Show("Дані карти було успішно відредаговано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDeleteCard_Click(object sender, EventArgs e)
        {
            CardManager cardManager = new CardManager();
            cardManager.DeleteCard(selectedIndex);
            MessageBox.Show("Картку було успішно видалено", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            textBoxBankEdit.Clear();
            textBoxCardNumberEdit.Clear();
            textBoxCvvEdit.Clear();
            textBoxPinEdit.Clear();
            textBoxPickerDateEdit.Clear();
        }
    }
}