namespace EncryptionDecryption
{
    partial class EncryptionDecryptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTextToEncrypt = new Label();
            tbTextToEncrypt = new TextBox();
            tbEncryptedText = new TextBox();
            lblTextToDecrypt = new Label();
            SuspendLayout();
            // 
            // lblTextToEncrypt
            // 
            lblTextToEncrypt.AutoSize = true;
            lblTextToEncrypt.Location = new Point(12, 9);
            lblTextToEncrypt.Name = "lblTextToEncrypt";
            lblTextToEncrypt.Size = new Size(70, 20);
            lblTextToEncrypt.TabIndex = 0;
            lblTextToEncrypt.Text = "Plain text";
            // 
            // tbTextToEncrypt
            // 
            tbTextToEncrypt.Location = new Point(39, 32);
            tbTextToEncrypt.Name = "tbTextToEncrypt";
            tbTextToEncrypt.Size = new Size(749, 27);
            tbTextToEncrypt.TabIndex = 1;
            tbTextToEncrypt.DoubleClick += tbTextToEncrypt_DoubleClick;
            tbTextToEncrypt.Leave += tbTextToEncrypt_Leave;
            // 
            // tbEncryptedText
            // 
            tbEncryptedText.Location = new Point(39, 100);
            tbEncryptedText.Name = "tbEncryptedText";
            tbEncryptedText.Size = new Size(749, 27);
            tbEncryptedText.TabIndex = 3;
            tbEncryptedText.DoubleClick += tbEncryptedText_DoubleClick;
            tbEncryptedText.Leave += tbEncryptedText_Leave;
            // 
            // lblTextToDecrypt
            // 
            lblTextToDecrypt.AutoSize = true;
            lblTextToDecrypt.Location = new Point(12, 77);
            lblTextToDecrypt.Name = "lblTextToDecrypt";
            lblTextToDecrypt.Size = new Size(104, 20);
            lblTextToDecrypt.TabIndex = 2;
            lblTextToDecrypt.Text = "Encrypted text";
            // 
            // EncryptionDecryptionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 149);
            Controls.Add(tbEncryptedText);
            Controls.Add(lblTextToDecrypt);
            Controls.Add(tbTextToEncrypt);
            Controls.Add(lblTextToEncrypt);
            Name = "EncryptionDecryptionForm";
            Text = "EncryptionDecryptionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTextToEncrypt;
        private TextBox tbTextToEncrypt;
        private TextBox tbEncryptedText;
        private Label lblTextToDecrypt;
    }
}