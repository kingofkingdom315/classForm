namespace classForm
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
            this.leghtText = new System.Windows.Forms.TextBox();
            this.numText = new System.Windows.Forms.TextBox();
            this.fullMassText = new System.Windows.Forms.TextBox();
            this.infoText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addEmptyMassBut = new System.Windows.Forms.Button();
            this.addNumBut = new System.Windows.Forms.Button();
            this.addFullMassBut = new System.Windows.Forms.Button();
            this.minusBut = new System.Windows.Forms.Button();
            this.leghtBut = new System.Windows.Forms.Button();
            this.curText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.minusNumBut = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numBut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.clearBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leghtText
            // 
            this.leghtText.Location = new System.Drawing.Point(168, 29);
            this.leghtText.Multiline = true;
            this.leghtText.Name = "leghtText";
            this.leghtText.Size = new System.Drawing.Size(100, 40);
            this.leghtText.TabIndex = 3;
            // 
            // numText
            // 
            this.numText.Location = new System.Drawing.Point(168, 95);
            this.numText.Multiline = true;
            this.numText.Name = "numText";
            this.numText.ReadOnly = true;
            this.numText.Size = new System.Drawing.Size(100, 40);
            this.numText.TabIndex = 4;
            // 
            // fullMassText
            // 
            this.fullMassText.Location = new System.Drawing.Point(377, 29);
            this.fullMassText.Multiline = true;
            this.fullMassText.Name = "fullMassText";
            this.fullMassText.Size = new System.Drawing.Size(212, 40);
            this.fullMassText.TabIndex = 5;
            this.fullMassText.Text = "1:2:3:4";
            // 
            // infoText
            // 
            this.infoText.Location = new System.Drawing.Point(15, 29);
            this.infoText.Name = "infoText";
            this.infoText.ReadOnly = true;
            this.infoText.Size = new System.Drawing.Size(150, 337);
            this.infoText.TabIndex = 6;
            this.infoText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Инфо";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "или введите весь масив";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Введите размер массива";
            // 
            // addEmptyMassBut
            // 
            this.addEmptyMassBut.Location = new System.Drawing.Point(274, 29);
            this.addEmptyMassBut.Name = "addEmptyMassBut";
            this.addEmptyMassBut.Size = new System.Drawing.Size(90, 40);
            this.addEmptyMassBut.TabIndex = 11;
            this.addEmptyMassBut.Text = "Добавить";
            this.addEmptyMassBut.UseVisualStyleBackColor = true;
            this.addEmptyMassBut.Click += new System.EventHandler(this.addEmptyMassBut_Click);
            // 
            // addNumBut
            // 
            this.addNumBut.Location = new System.Drawing.Point(274, 95);
            this.addNumBut.Name = "addNumBut";
            this.addNumBut.Size = new System.Drawing.Size(90, 40);
            this.addNumBut.TabIndex = 12;
            this.addNumBut.Text = "Добавть";
            this.addNumBut.UseVisualStyleBackColor = true;
            // 
            // addFullMassBut
            // 
            this.addFullMassBut.Location = new System.Drawing.Point(595, 29);
            this.addFullMassBut.Name = "addFullMassBut";
            this.addFullMassBut.Size = new System.Drawing.Size(90, 40);
            this.addFullMassBut.TabIndex = 13;
            this.addFullMassBut.Text = "Добавить";
            this.addFullMassBut.UseVisualStyleBackColor = true;
            this.addFullMassBut.Click += new System.EventHandler(this.addFullMassBut_Click);
            // 
            // minusBut
            // 
            this.minusBut.Location = new System.Drawing.Point(168, 315);
            this.minusBut.Name = "minusBut";
            this.minusBut.Size = new System.Drawing.Size(139, 51);
            this.minusBut.TabIndex = 14;
            this.minusBut.Text = "кол-во отрицательных";
            this.minusBut.UseVisualStyleBackColor = true;
            // 
            // leghtBut
            // 
            this.leghtBut.Location = new System.Drawing.Point(168, 269);
            this.leghtBut.Name = "leghtBut";
            this.leghtBut.Size = new System.Drawing.Size(139, 40);
            this.leghtBut.TabIndex = 15;
            this.leghtBut.Text = "Размер масива";
            this.leghtBut.UseVisualStyleBackColor = true;
            // 
            // curText
            // 
            this.curText.Location = new System.Drawing.Point(168, 160);
            this.curText.Multiline = true;
            this.curText.Name = "curText";
            this.curText.ReadOnly = true;
            this.curText.Size = new System.Drawing.Size(100, 40);
            this.curText.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "кол-во отрицательных чисел больше числа";
            // 
            // minusNumBut
            // 
            this.minusNumBut.Location = new System.Drawing.Point(274, 160);
            this.minusNumBut.Name = "minusNumBut";
            this.minusNumBut.Size = new System.Drawing.Size(90, 40);
            this.minusNumBut.TabIndex = 18;
            this.minusNumBut.Text = "Найти";
            this.minusNumBut.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 223);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(43, 24);
            this.comboBox1.TabIndex = 19;
            // 
            // numBut
            // 
            this.numBut.Location = new System.Drawing.Point(217, 223);
            this.numBut.Name = "numBut";
            this.numBut.Size = new System.Drawing.Size(90, 40);
            this.numBut.TabIndex = 20;
            this.numBut.Text = "Найти";
            this.numBut.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "кол-во элементов после элемента №";
            // 
            // clearBut
            // 
            this.clearBut.Location = new System.Drawing.Point(595, 326);
            this.clearBut.Name = "clearBut";
            this.clearBut.Size = new System.Drawing.Size(90, 40);
            this.clearBut.TabIndex = 22;
            this.clearBut.Text = "Очистить";
            this.clearBut.UseVisualStyleBackColor = true;
            this.clearBut.Click += new System.EventHandler(this.clearBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 382);
            this.Controls.Add(this.clearBut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numBut);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.minusNumBut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.curText);
            this.Controls.Add(this.leghtBut);
            this.Controls.Add(this.minusBut);
            this.Controls.Add(this.addFullMassBut);
            this.Controls.Add(this.addNumBut);
            this.Controls.Add(this.addEmptyMassBut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.fullMassText);
            this.Controls.Add(this.numText);
            this.Controls.Add(this.leghtText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox leghtText;
        private System.Windows.Forms.TextBox numText;
        private System.Windows.Forms.TextBox fullMassText;
        private System.Windows.Forms.RichTextBox infoText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addEmptyMassBut;
        private System.Windows.Forms.Button addNumBut;
        private System.Windows.Forms.Button addFullMassBut;
        private System.Windows.Forms.Button minusBut;
        private System.Windows.Forms.Button leghtBut;
        private System.Windows.Forms.TextBox curText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minusNumBut;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button numBut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button clearBut;
    }
}

