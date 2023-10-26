namespace SumOrMultiply.Components
{
    partial class PlayPanel
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

        protected void UserInitialization()
        {
            comboBox1.Items.Add("Умножение");
            comboBox1.Items.Add("Сложение");
            comboBox1.SelectedIndex = 0;
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 365);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(3, 169);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(567, 65);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(192, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(366, 23);
            textBox1.TabIndex = 7;
            textBox1.Text = "02:00";
            textBox1.Leave += textBox1_Leave;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(177, 53);
            label3.TabIndex = 6;
            label3.Text = "Время";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(numericUpDown1);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(3, 104);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(564, 65);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown1.Location = new Point(192, 31);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(366, 23);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(0, 9);
            label4.Name = "label4";
            label4.Size = new Size(180, 53);
            label4.TabIndex = 6;
            label4.Text = "Сложность";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(3, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(564, 65);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 9);
            label2.Name = "label2";
            label2.Size = new Size(180, 53);
            label2.TabIndex = 6;
            label2.Text = "Тип игры";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(192, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(366, 23);
            comboBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(320, 314);
            button1.Name = "button1";
            button1.Size = new Size(247, 48);
            button1.TabIndex = 2;
            button1.Text = "Начать игру";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(214, 36);
            label1.TabIndex = 1;
            label1.Text = "Настройка игры";
            // 
            // PlayPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Name = "PlayPanel";
            Size = new Size(570, 365);
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Button button1;
        private ComboBox comboBox1;
        private GroupBox groupBox3;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Label label3;
    }
}
