
namespace Палиндром
{
    partial class PalindromForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PalindromForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.PictureReptile = new System.Windows.Forms.PictureBox();
            this.pictureCat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureReptile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCat)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 71);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 52);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(113, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Палиндром?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label1.Location = new System.Drawing.Point(46, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тут будет ответ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cyan;
            this.button2.Location = new System.Drawing.Point(113, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PictureReptile
            // 
            this.PictureReptile.BackColor = System.Drawing.Color.Transparent;
            this.PictureReptile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureReptile.BackgroundImage")));
            this.PictureReptile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureReptile.Location = new System.Drawing.Point(262, 356);
            this.PictureReptile.Name = "PictureReptile";
            this.PictureReptile.Size = new System.Drawing.Size(100, 94);
            this.PictureReptile.TabIndex = 4;
            this.PictureReptile.TabStop = false;
            this.PictureReptile.Click += new System.EventHandler(this.PictureReptile_Click);
            // 
            // pictureCat
            // 
            this.pictureCat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureCat.BackgroundImage")));
            this.pictureCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureCat.Location = new System.Drawing.Point(1, 341);
            this.pictureCat.Name = "pictureCat";
            this.pictureCat.Size = new System.Drawing.Size(116, 109);
            this.pictureCat.TabIndex = 5;
            this.pictureCat.TabStop = false;
            this.pictureCat.Click += new System.EventHandler(this.pictureCat_Click);
            // 
            // PalindromForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.pictureCat);
            this.Controls.Add(this.PictureReptile);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PalindromForm";
            this.Text = "Палиндром от Лии";
            ((System.ComponentModel.ISupportInitialize)(this.PictureReptile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox PictureReptile;
        private System.Windows.Forms.PictureBox pictureCat;
    }
}

