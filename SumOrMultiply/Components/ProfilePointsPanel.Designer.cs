namespace SumOrMultiply.Components
{
    partial class ProfilePointsPanel
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dataDridId = new DataGridViewTextBoxColumn();
            dataGridName = new DataGridViewTextBoxColumn();
            dataGridPoints = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 408);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 36);
            label1.TabIndex = 1;
            label1.Text = "Очки";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataDridId, dataGridName, dataGridPoints });
            dataGridView1.Location = new Point(3, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(608, 366);
            dataGridView1.TabIndex = 0;
            // 
            // dataDridId
            // 
            dataDridId.Frozen = true;
            dataDridId.HeaderText = "Номер";
            dataDridId.Name = "dataDridId";
            dataDridId.ReadOnly = true;
            // 
            // dataGridName
            // 
            dataGridName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridName.HeaderText = "Имя";
            dataGridName.Name = "dataGridName";
            dataGridName.ReadOnly = true;
            // 
            // dataGridPoints
            // 
            dataGridPoints.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridPoints.HeaderText = "Очки";
            dataGridPoints.Name = "dataGridPoints";
            // 
            // ProfilePointsPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Name = "ProfilePointsPanel";
            Size = new Size(614, 408);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private DataGridViewTextBoxColumn dataDridId;
        private DataGridViewTextBoxColumn dataGridName;
        private DataGridViewTextBoxColumn dataGridPoints;
    }
}
