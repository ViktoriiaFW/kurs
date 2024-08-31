using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class gen_form : Form
    {
        public gen_form()
        {
            InitializeComponent();
        }

        private void buttonAddCard_Click(object sender, EventArgs e)
        {
            int genNumber = 0;
            string RandomString = "";
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!@#$^&*";

            if (!int.TryParse(textBoxGenNumber.Text, out genNumber))
            {
                MessageBox.Show("Введіть коректне значення кількості знаків.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (6 > genNumber || genNumber > 32)
            {
                MessageBox.Show("Введіть кількість більше 6 та менше 32 знаків.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBoxPassResult.Visible = true;
            buttonPassCopy.Visible = true;
            buttonResetPass.Visible = true;
            Random rnd = new Random();
            for (int i = 0; i < genNumber; i++)
            {
                char randomChar = chars[rnd.Next(chars.Length)];
                RandomString += randomChar;
            }
            textBoxPassResult.Text = RandomString;
        }

        private void buttonPassCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxPassResult.Text);
            MessageBox.Show("Пароль успішно скопійований!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonResetPass_Click(object sender, EventArgs e)
        {
            textBoxPassResult.Visible = false;
            textBoxGenNumber.Clear();
            textBoxPassResult.Clear();
            buttonPassCopy.Visible = false;
            buttonResetPass.Visible = false;
        }
    }
}