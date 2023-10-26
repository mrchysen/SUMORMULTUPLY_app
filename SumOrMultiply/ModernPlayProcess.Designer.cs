namespace SumOrMultiply.ApplicationPlace
{
    partial class ModernPlayProcess
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

        protected void UserInitialization()
        {
            button5.BackColor = System.Drawing.Color.FromArgb(200, 67, 112, 112);
            button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(166, 166, 166);
            button6.BackColor = System.Drawing.Color.FromArgb(200, 67, 112, 112);
            button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(166, 166, 166);
            richTextBox2.Visible = false;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModernPlayProcess));
            panel1 = new Panel();
            richTextBox2 = new RichTextBox();
            button6 = new Button();
            label7 = new Label();
            button5 = new Button();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            panel4 = new Panel();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            panel5 = new Panel();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(richTextBox2);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 441);
            panel1.TabIndex = 0;
            // 
            // richTextBox2
            // 
            richTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            richTextBox2.Location = new Point(5, 110);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(287, 274);
            richTextBox2.TabIndex = 15;
            richTextBox2.Text = "";
            richTextBox2.ZoomFactor = 2F;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button6.BackColor = Color.Transparent;
            button6.Font = new Font("Comic Sans MS", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(51, 56);
            button6.Name = "button6";
            button6.Size = new Size(247, 48);
            button6.TabIndex = 14;
            button6.Text = "Имя профиля";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label7
            // 
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.Location = new Point(5, 58);
            label7.Name = "label7";
            label7.Size = new Size(45, 48);
            label7.TabIndex = 13;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.BackColor = Color.Transparent;
            button5.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(3, 390);
            button5.Name = "button5";
            button5.Size = new Size(292, 48);
            button5.TabIndex = 12;
            button5.Text = "Завершить";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += CompleteButtonClick;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.Font = new Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(298, 53);
            label6.TabIndex = 11;
            label6.Text = "SUMORMULTIPLY";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Comic Sans MS", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(37, 7);
            label2.Name = "label2";
            label2.Size = new Size(142, 38);
            label2.TabIndex = 16;
            label2.Text = "Тут очки";
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(-1, -4);
            label1.Name = "label1";
            label1.Size = new Size(45, 48);
            label1.TabIndex = 15;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.Font = new Font("Comic Sans MS", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(289, 6);
            label4.Name = "label4";
            label4.Size = new Size(153, 38);
            label4.TabIndex = 18;
            label4.Text = "Время 00:00";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(435, -3);
            label3.Name = "label3";
            label3.Size = new Size(45, 48);
            label3.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(298, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(486, 441);
            panel2.TabIndex = 20;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 0, 2);
            tableLayoutPanel1.Controls.Add(panel5, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(486, 441);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(480, 44);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Controls.Add(richTextBox1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 248);
            panel4.Name = "panel4";
            panel4.Size = new Size(480, 190);
            panel4.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(350, 86);
            button1.Name = "button1";
            button1.Size = new Size(92, 74);
            button1.TabIndex = 13;
            button1.Text = "Ок";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(37, 33);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(405, 127);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.ZoomFactor = 5F;
            richTextBox1.KeyDown += richTextBox1_KeyDown;
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 53);
            panel5.Name = "panel5";
            panel5.Size = new Size(480, 189);
            panel5.TabIndex = 2;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Comic Sans MS", 52F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(480, 189);
            label5.TabIndex = 0;
            label5.Text = "Пример";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // ModernPlayProcess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(784, 441);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 480);
            Name = "ModernPlayProcess";
            Text = "SUMORMULTIPLY";
            FormClosing += ModernPlayProcess_FormClosing;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Button button5;
        private Button button6;
        private Label label7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label5;
        private RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
        private RichTextBox richTextBox2;
        private Button button1;
    }
}