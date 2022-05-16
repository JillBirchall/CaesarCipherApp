namespace CaesarCipherApp

{
    partial class InputForm
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.EncryptHeading = new System.Windows.Forms.Label();
            this.shiftLabel = new System.Windows.Forms.Label();
            this.shiftNumber = new System.Windows.Forms.NumericUpDown();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.shiftNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(28, 70);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(650, 150);
            this.inputTextBox.TabIndex = 0;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(25, 45);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(50, 13);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.Text = "Message";
            // 
            // EncryptHeading
            // 
            this.EncryptHeading.AutoSize = true;
            this.EncryptHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptHeading.Location = new System.Drawing.Point(283, 9);
            this.EncryptHeading.Name = "EncryptHeading";
            this.EncryptHeading.Size = new System.Drawing.Size(110, 20);
            this.EncryptHeading.TabIndex = 2;
            this.EncryptHeading.Text = "Caesar Cipher";
            // 
            // shiftLabel
            // 
            this.shiftLabel.AutoSize = true;
            this.shiftLabel.Location = new System.Drawing.Point(25, 235);
            this.shiftLabel.Name = "shiftLabel";
            this.shiftLabel.Size = new System.Drawing.Size(28, 13);
            this.shiftLabel.TabIndex = 3;
            this.shiftLabel.Text = "Shift";
            // 
            // shiftNumber
            // 
            this.shiftNumber.Location = new System.Drawing.Point(70, 233);
            this.shiftNumber.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.shiftNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shiftNumber.Name = "shiftNumber";
            this.shiftNumber.Size = new System.Drawing.Size(39, 20);
            this.shiftNumber.TabIndex = 4;
            this.shiftNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(28, 281);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(91, 31);
            this.encryptBtn.TabIndex = 5;
            this.encryptBtn.Text = "Encrypt!";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(139, 281);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(102, 31);
            this.decryptBtn.TabIndex = 6;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(23, 395);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(650, 150);
            this.outputTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 589);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.shiftNumber);
            this.Controls.Add(this.shiftLabel);
            this.Controls.Add(this.EncryptHeading);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.shiftNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label EncryptHeading;
        private System.Windows.Forms.Label shiftLabel;
        private System.Windows.Forms.NumericUpDown shiftNumber;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}

