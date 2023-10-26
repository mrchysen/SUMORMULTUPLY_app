using SumOrMultiply.Logic;
using SumOrMultiply.Logic.Equations;
using SumOrMultiply.Logic.Profiles;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SumOrMultiply.ApplicationPlace
{
    public partial class ModernPlayProcess : Form
    {
        // Поля \\
        protected Profile Profile;
        protected TypeOfGame TypeOfGame;
        protected float Difficult;
        protected int Points = 0;
        protected int Time = 120;
        protected int TrueAns = 0;
        protected int AmountOfEquations = 0;
        protected Equation Equation;

        // Конструкторы \\
        public ModernPlayProcess(int difficult, TypeOfGame type, Profile profile, int Time)
        {
            InitializeComponent();
            UserInitialization();

            button6.Text = profile.Name;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button6, $"Профиль:\n{profile.Name}\n{profile.Points} очков");

            Profile = profile;
            TypeOfGame = type;
            Difficult = difficult;
            this.Time = Time;

            SetPoints(0);
            SetTime(Time);

            timer1.Interval = 1000;
            timer1.Enabled = true;

            CreateEquation();
            richTextBox1.Select();
        }

        /// <summary>
        /// Задать размер окна
        /// </summary>
        /// <param name="size"></param>
        public void SetSize(Size size) => this.Size = size;
        /// <summary>
        /// Задать место окна
        /// </summary>
        /// <param name="location"></param>
        public void SetLocation(Point location) => this.Location = location;

        public void SetTime(int time)
        {
            string min = (time / 60 >= 10) ? (time / 60).ToString() : "0" + (time / 60).ToString();
            string sec = (time % 60 >= 10) ? (time % 60).ToString() : "0" + (time % 60).ToString();

            label4.Text = $"Время {min}:{sec}";
        }
        public void SetPoints(int points)
        {
            label2.Text = "Очки " + points.ToString();
        }


        public void CreateEquation()
        {
            if (TypeOfGame == TypeOfGame.Multiplication)
            {
                Equation = new BinaryMultiply(new Logic.Generators.GeneratorForMultiplication((int)Difficult));
                label5.Text = Equation.EquationWithNumbers;
            }
            else
            {
                Equation = new BinaryAddition(new Logic.Generators.GeneratorForAddition((int)Difficult));
                label5.Text = Equation.EquationWithNumbers;
            }
        }

        private void ModernPlayProcess_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Visible = true;
            Owner.Location = Location;
            Owner.Size = Size;
        }

        /// <summary>
        /// Задать обработчик нажатия на кнопку
        /// </summary>
        /// <param name="click"></param>
        private void CompleteButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time--;
            SetTime(Time);

            if (Time < 0)
            {
                SetTime(0);
                label5.Font = new Font("Comic Sans MS", 44);
                label5.Text = "<-- Статистика";
                richTextBox1.Enabled = false;
                button1.Enabled = false;
                timer1.Enabled = false;
                richTextBox2.Visible = true;
                UpdateStatistic();
            }
        }

        protected void UpdateStatistic()
        {
            string info = "Статистика\n" +
                $"Профиль: {Profile.Name}\n" +
                $"Всего очков: {Profile.Points}\n" +
                $"Данная сессия\n" +
                $"Правильных ответов: {TrueAns}\n" +
                $"Количество ответов: {AmountOfEquations}";

            richTextBox2.Text = info;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Visible)
                richTextBox2.Visible = false;
            else
                richTextBox2.Visible = true;

            UpdateStatistic();
        }

        protected async void CheckAnswer()
        {
            int answer;
            if (int.TryParse(richTextBox1.Text, out answer))
            {
                if (answer == Equation.Result)
                {
                    int WinPoints = (TypeOfGame == TypeOfGame.Addition) ? (int)Difficult : 2 * (int)Difficult;
                    Profile.Points += WinPoints;
                    Points += WinPoints;
                    label5.Text = "Правильно";
                    Difficult += 0.25f;
                    TrueAns++;
                    if (Difficult > 10)
                        Difficult = 10;
                }
                else
                {
                    label5.Text = "Неправильно";
                    Difficult -= 0.25f;
                    if (Difficult < 1)
                        Difficult = 1;
                }
            }
            else
            {
                label5.Text = "Неправильно";
                Difficult -= 0.25f;
                if (Difficult < 1)
                    Difficult = 1;
            }

            AmountOfEquations++;

            await Task.Delay(1000);

            richTextBox1.ZoomFactor = 1;
            richTextBox1.ResetText();
            richTextBox1.ZoomFactor = 5;

            SetPoints(Points);
            UpdateStatistic();
            CreateEquation();

            if (Time <= 0)
            {
                label5.Font = new Font("Comic Sans MS", 44);
                label5.Text = "<-- Статистика";
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckAnswer();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }
    }
}
