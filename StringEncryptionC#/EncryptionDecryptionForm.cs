using EncryptStringActions;

namespace EncryptionDecryption
{
    public partial class EncryptionDecryptionForm : Form
    {
        public EncryptionDecryptionForm()
        {
            InitializeComponent();
        }

        // Method to encrypt a string entered in tbTextToEncrypt and display in the tbEncryptedText on the leave event of tbTextToEncrypt
        private void tbTextToEncrypt_Leave(object sender, EventArgs e)
        {
            tbEncryptedText.Text = StringCipher.EncryptThisString(tbTextToEncrypt.Text);
        }

        // Method to decrypt a string entered in tbEncryptedText and display in tbTextToEncrypt on the leave event of tbEncryptedText
        private void tbEncryptedText_Leave(object sender, EventArgs e)
        {
            tbTextToEncrypt.Text = StringCipher.DecryptThisString(tbEncryptedText.Text);
        }

        private void tbTextToEncrypt_DoubleClick(object sender, EventArgs e)
        {
            tbTextToEncrypt.SelectAll(); 
        }

        private void tbEncryptedText_DoubleClick(object sender, EventArgs e)
        {
            tbEncryptedText.SelectAll();
        }
    }
}
