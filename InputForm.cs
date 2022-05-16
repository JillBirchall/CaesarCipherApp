using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CaesarCipherApp
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            string decryptedMessage = CaesarCipher.DecryptMessage(inputTextBox.Text, (int)shiftNumber.Value);
            outputTextBox.Text = decryptedMessage;
            label3.Text = "Decrypted Message";
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            string encryptedMessage = CaesarCipher.EncryptMessage(inputTextBox.Text, (int)shiftNumber.Value);
            outputTextBox.Text = encryptedMessage;
            label3.Text = "Encrypted Message";

        }

    }
}
