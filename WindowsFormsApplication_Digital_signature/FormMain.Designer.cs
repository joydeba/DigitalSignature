namespace WindowsFormsApplication_Digital_signature
{
    partial class Form_Main_win
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
            this.groupBox_signature = new System.Windows.Forms.GroupBox();
            this.groupBox_encryption = new System.Windows.Forms.GroupBox();
            this.panel__sig_bob = new System.Windows.Forms.Panel();
            this.panel__sig_alice = new System.Windows.Forms.Panel();
            this.panel__enc_bob = new System.Windows.Forms.Panel();
            this.panel__enc_alice = new System.Windows.Forms.Panel();
            this.label_plain_text = new System.Windows.Forms.Label();
            this.textBox_plaintext = new System.Windows.Forms.TextBox();
            this.button_gen_encryption = new System.Windows.Forms.Button();
            this.button_gen_hashvalue = new System.Windows.Forms.Button();
            this.richTextBox_sig_hash_value = new System.Windows.Forms.RichTextBox();
            this.richTextBox_encrypted_text = new System.Windows.Forms.RichTextBox();
            this.button_sig_verify = new System.Windows.Forms.Button();
            this.label_verify_status = new System.Windows.Forms.Label();
            this.button_decryped_text = new System.Windows.Forms.Button();
            this.label_decrypt_text = new System.Windows.Forms.Label();
            this.groupBox_signature.SuspendLayout();
            this.groupBox_encryption.SuspendLayout();
            this.panel__sig_bob.SuspendLayout();
            this.panel__sig_alice.SuspendLayout();
            this.panel__enc_bob.SuspendLayout();
            this.panel__enc_alice.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_signature
            // 
            this.groupBox_signature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_signature.Controls.Add(this.panel__sig_alice);
            this.groupBox_signature.Controls.Add(this.panel__sig_bob);
            this.groupBox_signature.Location = new System.Drawing.Point(12, 13);
            this.groupBox_signature.Name = "groupBox_signature";
            this.groupBox_signature.Size = new System.Drawing.Size(315, 317);
            this.groupBox_signature.TabIndex = 0;
            this.groupBox_signature.TabStop = false;
            this.groupBox_signature.Text = "Digital Signature";
            // 
            // groupBox_encryption
            // 
            this.groupBox_encryption.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_encryption.Controls.Add(this.panel__enc_alice);
            this.groupBox_encryption.Controls.Add(this.panel__enc_bob);
            this.groupBox_encryption.Location = new System.Drawing.Point(365, 13);
            this.groupBox_encryption.Name = "groupBox_encryption";
            this.groupBox_encryption.Size = new System.Drawing.Size(324, 317);
            this.groupBox_encryption.TabIndex = 1;
            this.groupBox_encryption.TabStop = false;
            this.groupBox_encryption.Text = "Encryption";
            // 
            // panel__sig_bob
            // 
            this.panel__sig_bob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel__sig_bob.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel__sig_bob.Controls.Add(this.richTextBox_sig_hash_value);
            this.panel__sig_bob.Controls.Add(this.button_gen_hashvalue);
            this.panel__sig_bob.Controls.Add(this.textBox_plaintext);
            this.panel__sig_bob.Controls.Add(this.label_plain_text);
            this.panel__sig_bob.Location = new System.Drawing.Point(21, 33);
            this.panel__sig_bob.Name = "panel__sig_bob";
            this.panel__sig_bob.Size = new System.Drawing.Size(245, 116);
            this.panel__sig_bob.TabIndex = 0;
            // 
            // panel__sig_alice
            // 
            this.panel__sig_alice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel__sig_alice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel__sig_alice.Controls.Add(this.label_verify_status);
            this.panel__sig_alice.Controls.Add(this.button_sig_verify);
            this.panel__sig_alice.Location = new System.Drawing.Point(21, 174);
            this.panel__sig_alice.Name = "panel__sig_alice";
            this.panel__sig_alice.Size = new System.Drawing.Size(245, 116);
            this.panel__sig_alice.TabIndex = 1;
            // 
            // panel__enc_bob
            // 
            this.panel__enc_bob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel__enc_bob.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel__enc_bob.Controls.Add(this.richTextBox_encrypted_text);
            this.panel__enc_bob.Controls.Add(this.button_gen_encryption);
            this.panel__enc_bob.Location = new System.Drawing.Point(56, 33);
            this.panel__enc_bob.Name = "panel__enc_bob";
            this.panel__enc_bob.Size = new System.Drawing.Size(247, 116);
            this.panel__enc_bob.TabIndex = 1;
            // 
            // panel__enc_alice
            // 
            this.panel__enc_alice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel__enc_alice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel__enc_alice.Controls.Add(this.label_decrypt_text);
            this.panel__enc_alice.Controls.Add(this.button_decryped_text);
            this.panel__enc_alice.Location = new System.Drawing.Point(56, 174);
            this.panel__enc_alice.Name = "panel__enc_alice";
            this.panel__enc_alice.Size = new System.Drawing.Size(247, 116);
            this.panel__enc_alice.TabIndex = 1;
            // 
            // label_plain_text
            // 
            this.label_plain_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_plain_text.AutoSize = true;
            this.label_plain_text.Location = new System.Drawing.Point(19, 23);
            this.label_plain_text.Name = "label_plain_text";
            this.label_plain_text.Size = new System.Drawing.Size(79, 13);
            this.label_plain_text.TabIndex = 0;
            this.label_plain_text.Text = "Enter PlainText";
            // 
            // textBox_plaintext
            // 
            this.textBox_plaintext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_plaintext.Location = new System.Drawing.Point(104, 20);
            this.textBox_plaintext.Name = "textBox_plaintext";
            this.textBox_plaintext.Size = new System.Drawing.Size(129, 20);
            this.textBox_plaintext.TabIndex = 1;
            // 
            // button_gen_encryption
            // 
            this.button_gen_encryption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button_gen_encryption.Location = new System.Drawing.Point(14, 23);
            this.button_gen_encryption.Name = "button_gen_encryption";
            this.button_gen_encryption.Size = new System.Drawing.Size(98, 78);
            this.button_gen_encryption.TabIndex = 2;
            this.button_gen_encryption.Text = "Encrypt plaintext using alice\'s public key";
            this.button_gen_encryption.UseVisualStyleBackColor = true;
            // 
            // button_gen_hashvalue
            // 
            this.button_gen_hashvalue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_gen_hashvalue.Location = new System.Drawing.Point(16, 47);
            this.button_gen_hashvalue.Name = "button_gen_hashvalue";
            this.button_gen_hashvalue.Size = new System.Drawing.Size(111, 56);
            this.button_gen_hashvalue.TabIndex = 2;
            this.button_gen_hashvalue.Text = "Generate Hash using Bob\'s private key";
            this.button_gen_hashvalue.UseVisualStyleBackColor = true;
            // 
            // richTextBox_sig_hash_value
            // 
            this.richTextBox_sig_hash_value.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_sig_hash_value.Location = new System.Drawing.Point(133, 47);
            this.richTextBox_sig_hash_value.Name = "richTextBox_sig_hash_value";
            this.richTextBox_sig_hash_value.Size = new System.Drawing.Size(100, 54);
            this.richTextBox_sig_hash_value.TabIndex = 3;
            this.richTextBox_sig_hash_value.Text = "";
            // 
            // richTextBox_encrypted_text
            // 
            this.richTextBox_encrypted_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_encrypted_text.Location = new System.Drawing.Point(131, 23);
            this.richTextBox_encrypted_text.Name = "richTextBox_encrypted_text";
            this.richTextBox_encrypted_text.Size = new System.Drawing.Size(100, 78);
            this.richTextBox_encrypted_text.TabIndex = 4;
            this.richTextBox_encrypted_text.Text = "";
            // 
            // button_sig_verify
            // 
            this.button_sig_verify.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_sig_verify.Location = new System.Drawing.Point(16, 24);
            this.button_sig_verify.Name = "button_sig_verify";
            this.button_sig_verify.Size = new System.Drawing.Size(217, 23);
            this.button_sig_verify.TabIndex = 0;
            this.button_sig_verify.Text = "Verify signature using bob\'s public key";
            this.button_sig_verify.UseVisualStyleBackColor = true;
            // 
            // label_verify_status
            // 
            this.label_verify_status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_verify_status.AutoSize = true;
            this.label_verify_status.Location = new System.Drawing.Point(102, 67);
            this.label_verify_status.Name = "label_verify_status";
            this.label_verify_status.Size = new System.Drawing.Size(105, 13);
            this.label_verify_status.TabIndex = 1;
            this.label_verify_status.Text = "Click Verify Button....";
            // 
            // button_decryped_text
            // 
            this.button_decryped_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_decryped_text.Location = new System.Drawing.Point(14, 24);
            this.button_decryped_text.Name = "button_decryped_text";
            this.button_decryped_text.Size = new System.Drawing.Size(217, 23);
            this.button_decryped_text.TabIndex = 0;
            this.button_decryped_text.Text = "Decrypt text using alice\'s private key";
            this.button_decryped_text.UseVisualStyleBackColor = true;
            // 
            // label_decrypt_text
            // 
            this.label_decrypt_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_decrypt_text.AutoSize = true;
            this.label_decrypt_text.Location = new System.Drawing.Point(105, 67);
            this.label_decrypt_text.Name = "label_decrypt_text";
            this.label_decrypt_text.Size = new System.Drawing.Size(44, 13);
            this.label_decrypt_text.TabIndex = 1;
            this.label_decrypt_text.Text = "Wait.....";
            // 
            // Form_Main_win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 342);
            this.Controls.Add(this.groupBox_encryption);
            this.Controls.Add(this.groupBox_signature);
            this.Name = "Form_Main_win";
            this.Text = "Signature And Encryption";
            this.groupBox_signature.ResumeLayout(false);
            this.groupBox_encryption.ResumeLayout(false);
            this.panel__sig_bob.ResumeLayout(false);
            this.panel__sig_bob.PerformLayout();
            this.panel__sig_alice.ResumeLayout(false);
            this.panel__sig_alice.PerformLayout();
            this.panel__enc_bob.ResumeLayout(false);
            this.panel__enc_alice.ResumeLayout(false);
            this.panel__enc_alice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_signature;
        private System.Windows.Forms.GroupBox groupBox_encryption;
        private System.Windows.Forms.Panel panel__sig_alice;
        private System.Windows.Forms.Panel panel__sig_bob;
        private System.Windows.Forms.Panel panel__enc_alice;
        private System.Windows.Forms.Panel panel__enc_bob;
        private System.Windows.Forms.Label label_verify_status;
        private System.Windows.Forms.Button button_sig_verify;
        private System.Windows.Forms.RichTextBox richTextBox_sig_hash_value;
        private System.Windows.Forms.Button button_gen_hashvalue;
        private System.Windows.Forms.TextBox textBox_plaintext;
        private System.Windows.Forms.Label label_plain_text;
        private System.Windows.Forms.Label label_decrypt_text;
        private System.Windows.Forms.Button button_decryped_text;
        private System.Windows.Forms.RichTextBox richTextBox_encrypted_text;
        private System.Windows.Forms.Button button_gen_encryption;
    }
}

