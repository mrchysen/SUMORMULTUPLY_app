namespace SumOrMultiply.Components
{
    partial class ProfileControlPanel
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            AddingPanel = new Panel();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            dataGridId = new DataGridViewTextBoxColumn();
            dataGridName = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel1.SuspendLayout();
            AddingPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(AddingPanel);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(696, 437);
            panel1.TabIndex = 0;
            // 
            // AddingPanel
            // 
            AddingPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AddingPanel.Controls.Add(groupBox1);
            AddingPanel.Controls.Add(button3);
            AddingPanel.Location = new Point(3, 89);
            AddingPanel.Name = "AddingPanel";
            AddingPanel.Size = new Size(233, 291);
            AddingPanel.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(227, 59);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Имя";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 31);
            textBox1.TabIndex = 0;
            textBox1.Text = "Имя";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(3, 240);
            button3.Name = "button3";
            button3.Size = new Size(227, 48);
            button3.TabIndex = 0;
            button3.Text = "Добавить";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += AddButtonClick;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(3, 39);
            button2.Name = "button2";
            button2.Size = new Size(233, 48);
            button2.TabIndex = 4;
            button2.Text = "Создать";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += CreateClick;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(3, 386);
            button1.Name = "button1";
            button1.Size = new Size(233, 48);
            button1.TabIndex = 3;
            button1.Text = "Выбрать";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += SelectClick;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridId, dataGridName });
            dataGridView1.Location = new Point(242, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(451, 395);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += SelectedCellClick;
            // 
            // dataGridId
            // 
            dataGridId.Frozen = true;
            dataGridId.HeaderText = "id";
            dataGridId.Name = "dataGridId";
            dataGridId.ReadOnly = true;
            // 
            // dataGridName
            // 
            dataGridName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridName.HeaderText = "Name";
            dataGridName.Name = "dataGridName";
            // 
            // label1
            // 
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 36);
            label1.TabIndex = 1;
            label1.Text = "Профиль";
            // 
            // ProfileControlPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Name = "ProfileControlPanel";
            Size = new Size(696, 437);
            panel1.ResumeLayout(false);
            AddingPanel.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridId;
        private DataGridViewTextBoxColumn dataGridName;
        private Button button1;
        private Button button2;
        private Panel AddingPanel;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button button3;
    }
}
