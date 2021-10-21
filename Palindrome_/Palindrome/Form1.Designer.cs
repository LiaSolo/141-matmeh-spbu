
namespace Palindrome
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkButton = new System.Windows.Forms.Button();
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.answerLabel = new System.Windows.Forms.Label();
            this.сlearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(141, 180);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(150, 35);
            this.checkButton.TabIndex = 0;
            this.checkButton.Text = "Палиндром???";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // mainTextBox
            // 
            this.mainTextBox.Location = new System.Drawing.Point(141, 134);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(300, 27);
            this.mainTextBox.TabIndex = 1;
            // 
            // answerLabel
            // 
            this.answerLabel.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.answerLabel.Location = new System.Drawing.Point(104, 231);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(369, 100);
            this.answerLabel.TabIndex = 2;
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // сlearButton
            // 
            this.сlearButton.Location = new System.Drawing.Point(291, 180);
            this.сlearButton.Name = "сlearButton";
            this.сlearButton.Size = new System.Drawing.Size(150, 35);
            this.сlearButton.TabIndex = 3;
            this.сlearButton.Text = "Очистить";
            this.сlearButton.UseVisualStyleBackColor = true;
            this.сlearButton.Click += new System.EventHandler(this.сlearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.сlearButton);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.checkButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check palindrome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Button сlearButton;
    }
}

