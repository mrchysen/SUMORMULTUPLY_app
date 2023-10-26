namespace SumOrMultiply.ApplicationPlace
{
    partial class ModernMainForm
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
            button1.BackColor = System.Drawing.Color.FromArgb(200, 67, 112, 112);
            button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(166, 166, 166);
            button2.BackColor = System.Drawing.Color.FromArgb(200, 67, 112, 112);
            button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(166, 166, 166);
            button3.BackColor = System.Drawing.Color.FromArgb(200, 67, 112, 112);
            button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(166, 166, 166);
            button4.BackColor = System.Drawing.Color.FromArgb(200, 67, 112, 112);
            button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(166, 166, 166);
            button5.BackColor = System.Drawing.Color.FromArgb(200, 67, 112, 112);
            button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(166, 166, 166);
            button6.BackColor = System.Drawing.Color.FromArgb(200, 67, 112, 112);
            button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(166, 166, 166);

            playPanel1.SetDelegateToPlayButton((o, e) =>
            {
                ModernPlayProcess modernPlayProcess = new ModernPlayProcess(playPanel1.GetDifficult(),playPanel1.GetTypeOfGame(), SelectedProfile, playPanel1.GetTime());
                modernPlayProcess.SetLocation(Location);
                modernPlayProcess.SetSize(Size);
                modernPlayProcess.Owner = this;
                this.Visible = false;
                modernPlayProcess.ShowDialog();
                this.SetSelectedProfile(SelectedProfile);
            });
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModernMainForm));
            ButtonPanel = new Panel();
            button6 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            infoPanel = new Components.InfoPanel();
            profilePointsPanel = new Components.ProfilePointsPanel();
            profileControlPanel1 = new Components.ProfileControlPanel();
            playPanel1 = new Components.PlayPanel();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonPanel
            // 
            ButtonPanel.BackColor = Color.RosyBrown;
            ButtonPanel.Controls.Add(button6);
            ButtonPanel.Controls.Add(label7);
            ButtonPanel.Controls.Add(label6);
            ButtonPanel.Controls.Add(label5);
            ButtonPanel.Controls.Add(label4);
            ButtonPanel.Controls.Add(label3);
            ButtonPanel.Controls.Add(label2);
            ButtonPanel.Controls.Add(label1);
            ButtonPanel.Controls.Add(button5);
            ButtonPanel.Controls.Add(button4);
            ButtonPanel.Controls.Add(button3);
            ButtonPanel.Controls.Add(button2);
            ButtonPanel.Controls.Add(button1);
            ButtonPanel.Dock = DockStyle.Left;
            ButtonPanel.Location = new Point(0, 0);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(298, 441);
            ButtonPanel.TabIndex = 0;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button6.BackColor = Color.Transparent;
            button6.Font = new Font("Comic Sans MS", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(51, 236);
            button6.Name = "button6";
            button6.Size = new Size(247, 48);
            button6.TabIndex = 12;
            button6.Text = "Профиль не выбран";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.Location = new Point(5, 238);
            label7.Name = "label7";
            label7.Size = new Size(45, 48);
            label7.TabIndex = 11;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.Font = new Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(298, 53);
            label6.TabIndex = 10;
            label6.Text = "SUMORMULTIPLY";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(5, 190);
            label5.Name = "label5";
            label5.Size = new Size(45, 48);
            label5.TabIndex = 9;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(5, 393);
            label4.Name = "label4";
            label4.Size = new Size(45, 48);
            label4.TabIndex = 8;
            // 
            // label3
            // 
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(5, 53);
            label3.Name = "label3";
            label3.Size = new Size(45, 48);
            label3.TabIndex = 7;
            // 
            // label2
            // 
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(5, 100);
            label2.Name = "label2";
            label2.Size = new Size(45, 48);
            label2.TabIndex = 6;
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(5, 144);
            label1.Name = "label1";
            label1.Size = new Size(45, 48);
            label1.TabIndex = 5;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.BackColor = Color.Transparent;
            button5.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(51, 393);
            button5.Name = "button5";
            button5.Size = new Size(247, 48);
            button5.TabIndex = 4;
            button5.Text = "Выход";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += ExitClick;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button4.BackColor = Color.Transparent;
            button4.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(51, 190);
            button4.Name = "button4";
            button4.Size = new Size(247, 48);
            button4.TabIndex = 3;
            button4.Text = "О приложении";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += AboutApplicationClick;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.Transparent;
            button3.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(51, 144);
            button3.Name = "button3";
            button3.Size = new Size(247, 48);
            button3.TabIndex = 2;
            button3.Text = "Профиль";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += ControlProfileButtonClick;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(51, 99);
            button2.Name = "button2";
            button2.Size = new Size(247, 48);
            button2.TabIndex = 1;
            button2.Text = "Очки";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += PointsButtonClick;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(51, 53);
            button1.Name = "button1";
            button1.Size = new Size(247, 48);
            button1.TabIndex = 0;
            button1.Text = "Играть";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += PlayButtonClick;
            // 
            // infoPanel
            // 
            infoPanel.BackColor = Color.Transparent;
            infoPanel.Dock = DockStyle.Fill;
            infoPanel.InfoText = "";
            infoPanel.Location = new Point(298, 0);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(486, 441);
            infoPanel.TabIndex = 1;
            // 
            // profilePointsPanel
            // 
            profilePointsPanel.BackColor = Color.Transparent;
            profilePointsPanel.Dock = DockStyle.Fill;
            profilePointsPanel.Location = new Point(298, 0);
            profilePointsPanel.Name = "profilePointsPanel";
            profilePointsPanel.Size = new Size(486, 441);
            profilePointsPanel.TabIndex = 11;
            // 
            // profileControlPanel1
            // 
            profileControlPanel1.BackColor = Color.Transparent;
            profileControlPanel1.Dock = DockStyle.Fill;
            profileControlPanel1.Location = new Point(298, 0);
            profileControlPanel1.Name = "profileControlPanel1";
            profileControlPanel1.Size = new Size(486, 441);
            profileControlPanel1.TabIndex = 11;
            // 
            // playPanel1
            // 
            playPanel1.BackColor = Color.Transparent;
            playPanel1.Dock = DockStyle.Fill;
            playPanel1.Location = new Point(298, 0);
            playPanel1.Name = "playPanel1";
            playPanel1.Size = new Size(486, 441);
            playPanel1.TabIndex = 12;
            // 
            // ModernMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(784, 441);
            Controls.Add(playPanel1);
            Controls.Add(profileControlPanel1);
            Controls.Add(profilePointsPanel);
            Controls.Add(infoPanel);
            Controls.Add(ButtonPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 480);
            Name = "ModernMainForm";
            Text = "SUMORMULTIPLY";
            FormClosing += ModernMainForm_FormClosing;
            Load += ModernMainForm_Load;
            ButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel ButtonPanel;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private Components.InfoPanel infoPanel;
        private Components.ProfilePointsPanel profilePointsPanel;
        private Components.ProfileControlPanel profileControlPanel1;
        private Label label7;
        private Button button6;
        private Components.PlayPanel playPanel1;
    }
}