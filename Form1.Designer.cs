namespace Skladero
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
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpmenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.c1txtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.c2txtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.c3txtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.QtxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NtxtBox = new System.Windows.Forms.TextBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.T0AlttxtBox = new System.Windows.Forms.TextBox();
            this.n0AlttxtBox = new System.Windows.Forms.TextBox();
            this.ptxtBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.T0txtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.n0txtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.NametxtBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.программаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(394, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenuItem,
            this.SaveMenuItem,
            this.SaveAsMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenMenuItem.Text = "Открыть";
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveMenuItem.Text = "Сохранить";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // SaveAsMenuItem
            // 
            this.SaveAsMenuItem.Name = "SaveAsMenuItem";
            this.SaveAsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveAsMenuItem.Text = "Сохранить как";
            this.SaveAsMenuItem.Click += new System.EventHandler(this.SaveAsMenuItem_Click);
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpmenuItem,
            this.AboutMenuItem});
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.программаToolStripMenuItem.Text = "Программа";
            // 
            // HelpmenuItem
            // 
            this.HelpmenuItem.Name = "HelpmenuItem";
            this.HelpmenuItem.Size = new System.Drawing.Size(180, 22);
            this.HelpmenuItem.Text = "Справка";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AboutMenuItem.Text = "О программе";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Затраты на 1 партию";
            // 
            // c1txtBox
            // 
            this.c1txtBox.Location = new System.Drawing.Point(189, 94);
            this.c1txtBox.Name = "c1txtBox";
            this.c1txtBox.Size = new System.Drawing.Size(193, 20);
            this.c1txtBox.TabIndex = 1;
            this.c1txtBox.TextChanged += new System.EventHandler(this.C1txtBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Затраты хранения 1 ед. запаса";
            // 
            // c2txtBox
            // 
            this.c2txtBox.Location = new System.Drawing.Point(189, 127);
            this.c2txtBox.Name = "c2txtBox";
            this.c2txtBox.Size = new System.Drawing.Size(193, 20);
            this.c2txtBox.TabIndex = 2;
            this.c2txtBox.TextChanged += new System.EventHandler(this.C2txtBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Штраф за дефицит";
            // 
            // c3txtBox
            // 
            this.c3txtBox.Location = new System.Drawing.Point(189, 162);
            this.c3txtBox.Name = "c3txtBox";
            this.c3txtBox.Size = new System.Drawing.Size(193, 20);
            this.c3txtBox.TabIndex = 3;
            this.c3txtBox.TextChanged += new System.EventHandler(this.C3txtBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Общий промежуток времени";
            // 
            // QtxtBox
            // 
            this.QtxtBox.Location = new System.Drawing.Point(189, 197);
            this.QtxtBox.Name = "QtxtBox";
            this.QtxtBox.Size = new System.Drawing.Size(193, 20);
            this.QtxtBox.TabIndex = 4;
            this.QtxtBox.TextChanged += new System.EventHandler(this.QtxtBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Общий объем запаса за период";
            // 
            // NtxtBox
            // 
            this.NtxtBox.Location = new System.Drawing.Point(189, 237);
            this.NtxtBox.Name = "NtxtBox";
            this.NtxtBox.Size = new System.Drawing.Size(193, 20);
            this.NtxtBox.TabIndex = 5;
            this.NtxtBox.TextChanged += new System.EventHandler(this.NtxtBox_TextChanged);
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(86, 285);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(209, 23);
            this.CalculateBtn.TabIndex = 6;
            this.CalculateBtn.Text = "Расчитать";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.T0AlttxtBox);
            this.groupBox1.Controls.Add(this.n0AlttxtBox);
            this.groupBox1.Controls.Add(this.ptxtBox);
            this.groupBox1.Location = new System.Drawing.Point(201, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 226);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "С ДИФИЦИТОМ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Интервал между поставками";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Оптимальный размер партии";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Плотность убытков";
            // 
            // T0AlttxtBox
            // 
            this.T0AlttxtBox.BackColor = System.Drawing.Color.White;
            this.T0AlttxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.T0AlttxtBox.Location = new System.Drawing.Point(9, 190);
            this.T0AlttxtBox.Name = "T0AlttxtBox";
            this.T0AlttxtBox.ReadOnly = true;
            this.T0AlttxtBox.Size = new System.Drawing.Size(167, 20);
            this.T0AlttxtBox.TabIndex = 13;
            // 
            // n0AlttxtBox
            // 
            this.n0AlttxtBox.BackColor = System.Drawing.Color.White;
            this.n0AlttxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.n0AlttxtBox.Location = new System.Drawing.Point(9, 123);
            this.n0AlttxtBox.Name = "n0AlttxtBox";
            this.n0AlttxtBox.ReadOnly = true;
            this.n0AlttxtBox.Size = new System.Drawing.Size(167, 20);
            this.n0AlttxtBox.TabIndex = 12;
            // 
            // ptxtBox
            // 
            this.ptxtBox.BackColor = System.Drawing.Color.White;
            this.ptxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptxtBox.Location = new System.Drawing.Point(9, 55);
            this.ptxtBox.Name = "ptxtBox";
            this.ptxtBox.ReadOnly = true;
            this.ptxtBox.Size = new System.Drawing.Size(167, 20);
            this.ptxtBox.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.T0txtBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.n0txtBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(13, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 226);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "БЕЗ ДИФИЦИТА";
            // 
            // T0txtBox
            // 
            this.T0txtBox.BackColor = System.Drawing.Color.White;
            this.T0txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.T0txtBox.Location = new System.Drawing.Point(9, 123);
            this.T0txtBox.Name = "T0txtBox";
            this.T0txtBox.ReadOnly = true;
            this.T0txtBox.Size = new System.Drawing.Size(167, 20);
            this.T0txtBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Интервал между поставками";
            // 
            // n0txtBox
            // 
            this.n0txtBox.BackColor = System.Drawing.Color.White;
            this.n0txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.n0txtBox.Location = new System.Drawing.Point(9, 55);
            this.n0txtBox.Name = "n0txtBox";
            this.n0txtBox.ReadOnly = true;
            this.n0txtBox.Size = new System.Drawing.Size(167, 20);
            this.n0txtBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Оптимальный объем партии";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Наименование";
            // 
            // NametxtBox
            // 
            this.NametxtBox.Location = new System.Drawing.Point(117, 42);
            this.NametxtBox.Name = "NametxtBox";
            this.NametxtBox.Size = new System.Drawing.Size(265, 20);
            this.NametxtBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 565);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.NtxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.QtxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.c3txtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.c2txtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NametxtBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.c1txtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Управление запасами";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpmenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox c1txtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox c2txtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox c3txtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox QtxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NtxtBox;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox T0AlttxtBox;
        private System.Windows.Forms.TextBox n0AlttxtBox;
        private System.Windows.Forms.TextBox ptxtBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox T0txtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox n0txtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NametxtBox;
    }
}

