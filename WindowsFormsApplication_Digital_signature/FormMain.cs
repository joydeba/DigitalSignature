using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication_Digital_signature
{
    public partial class Form_Main_win : Form
    {
        public Form_Main_win()
        {
            InitializeComponent();
        }

        Alice myReceiver = new Alice();
        Bob mySender = new Bob();
        byte[] encrypted;
        byte[] signature;

        private void button_gen_hashvalue_Click(object sender, EventArgs e)
        {
            if (richTextBox_encrypted_text.Text == "")
                MessageBox.Show("First click on encrypt button");
            else
            {
                signature = mySender.HashAndSign(encrypted);
                richTextBox_sig_hash_value.Text = Convert.ToBase64String(encrypted);
            }
        }

        private void button_gen_encryption_Click(object sender, EventArgs e)
        {
            if (textBox_plaintext.Text == "")
            {
                MessageBox.Show("Please enter a string to sign");

            }
            else
            {
                byte[] toEncrypt = Encoding.Unicode.GetBytes(textBox_plaintext.Text);
                encrypted = mySender.EncryptData(myReceiver.PublicParameters(), toEncrypt);
                richTextBox_encrypted_text.Text = Convert.ToBase64String(encrypted);
            }
        }

        private void button_sig_verify_Click(object sender, EventArgs e)
        {
            if (myReceiver.VerifyHash(mySender.PublicParameters(), encrypted, signature))
                label_verify_status.Text = "Signature Valid";

            else
                label_verify_status.Text = "Invalid Signature";
        }

        private void button_decryped_text_Click(object sender, EventArgs e)
        {
            label_decrypt_text.Text = myReceiver.DecryptData(encrypted);
        }
    }
}
