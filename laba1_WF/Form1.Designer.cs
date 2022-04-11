
namespace laba1_WF
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.шифрованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дешифрованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.защитаРСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лаб1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лаб2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лаб3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лаб4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лаб5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.часть1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.часть2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.защитаРСToolStripMenuItem,
            this.обАвтореToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.toolStripSeparator1,
            this.шифрованиеToolStripMenuItem,
            this.дешифрованиеToolStripMenuItem,
            this.toolStripSeparator2,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // шифрованиеToolStripMenuItem
            // 
            this.шифрованиеToolStripMenuItem.Name = "шифрованиеToolStripMenuItem";
            this.шифрованиеToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.шифрованиеToolStripMenuItem.Text = "Шифрование";
            // 
            // дешифрованиеToolStripMenuItem
            // 
            this.дешифрованиеToolStripMenuItem.Name = "дешифрованиеToolStripMenuItem";
            this.дешифрованиеToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.дешифрованиеToolStripMenuItem.Text = "Дешифрование";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // защитаРСToolStripMenuItem
            // 
            this.защитаРСToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лаб1ToolStripMenuItem,
            this.лаб2ToolStripMenuItem,
            this.лаб3ToolStripMenuItem,
            this.лаб4ToolStripMenuItem,
            this.лаб5ToolStripMenuItem});
            this.защитаРСToolStripMenuItem.Name = "защитаРСToolStripMenuItem";
            this.защитаРСToolStripMenuItem.Size = new System.Drawing.Size(198, 20);
            this.защитаРСToolStripMenuItem.Text = "Технология Программирования";
            this.защитаРСToolStripMenuItem.Click += new System.EventHandler(this.защитаРСToolStripMenuItem_Click);
            // 
            // лаб1ToolStripMenuItem
            // 
            this.лаб1ToolStripMenuItem.Name = "лаб1ToolStripMenuItem";
            this.лаб1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.лаб1ToolStripMenuItem.Text = "Лаб 1";
            this.лаб1ToolStripMenuItem.Click += new System.EventHandler(this.лаб1ToolStripMenuItem_Click);
            // 
            // лаб2ToolStripMenuItem
            // 
            this.лаб2ToolStripMenuItem.Name = "лаб2ToolStripMenuItem";
            this.лаб2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.лаб2ToolStripMenuItem.Text = "Лаб 2";
            this.лаб2ToolStripMenuItem.Click += new System.EventHandler(this.лаб2ToolStripMenuItem_Click);
            // 
            // лаб3ToolStripMenuItem
            // 
            this.лаб3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.часть1ToolStripMenuItem,
            this.часть2ToolStripMenuItem});
            this.лаб3ToolStripMenuItem.Name = "лаб3ToolStripMenuItem";
            this.лаб3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.лаб3ToolStripMenuItem.Text = "Лаб 3";
            this.лаб3ToolStripMenuItem.Click += new System.EventHandler(this.лаб3ToolStripMenuItem_Click);
            // 
            // лаб4ToolStripMenuItem
            // 
            this.лаб4ToolStripMenuItem.Name = "лаб4ToolStripMenuItem";
            this.лаб4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.лаб4ToolStripMenuItem.Text = "Лаб 4";
            // 
            // лаб5ToolStripMenuItem
            // 
            this.лаб5ToolStripMenuItem.Name = "лаб5ToolStripMenuItem";
            this.лаб5ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.лаб5ToolStripMenuItem.Text = "Лаб 5";
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.обАвтореToolStripMenuItem.Text = "Об Авторе";
            this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.обАвтореToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(225, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Приветствую!!!";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(713, 415);
            this.textBox1.TabIndex = 1;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // часть1ToolStripMenuItem
            // 
            this.часть1ToolStripMenuItem.Name = "часть1ToolStripMenuItem";
            this.часть1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.часть1ToolStripMenuItem.Text = "Часть 1";
            this.часть1ToolStripMenuItem.Click += new System.EventHandler(this.часть1ToolStripMenuItem_Click);
            // 
            // часть2ToolStripMenuItem
            // 
            this.часть2ToolStripMenuItem.Name = "часть2ToolStripMenuItem";
            this.часть2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.часть2ToolStripMenuItem.Text = "Часть 2";
            this.часть2ToolStripMenuItem.Click += new System.EventHandler(this.часть2ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 357);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бадретдинова Гузель 3043";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шифрованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дешифрованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem защитаРСToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лаб1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лаб2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лаб3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лаб4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лаб5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem часть1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem часть2ToolStripMenuItem;
    }
}

