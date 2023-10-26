using SumOrMultiply.Logic;
using System.Text.RegularExpressions;

namespace SumOrMultiply.Components
{
    public partial class PlayPanel : UserControl
    {
        // Конструктор \\
        public PlayPanel()
        {
            InitializeComponent();
            UserInitialization();
        }
        // Методы \\
        /// <summary>
        /// Получить сложность
        /// </summary>
        /// <returns></returns>
        public int GetDifficult() => Convert.ToInt32(numericUpDown1.Value);
        /// <summary>
        /// Получить тип игры
        /// </summary>
        /// <returns></returns>
        public TypeOfGame GetTypeOfGame()
        {
            TypeOfGame result;

            result = comboBox1.SelectedItem.ToString() switch
            {
                "Сложение" => TypeOfGame.Addition,
                "Умножение" => TypeOfGame.Multiplication,
            };

            return result;
        }
        public void SetDelegateToPlayButton(EventHandler click)
        {
            button1.Click += click;
        }
        public int GetTime()
        {
            int time = 0;
            var data = textBox1.Text.Split(":");

            time = 60 * Convert.ToInt32(data[0]) + Convert.ToInt32(data[1]);

            return time;
        }



        private void textBox1_Leave(object sender, EventArgs e)
        {
            string pattern = "[0-9][0-9]:[0-9][0-9]";
            Regex regex = new Regex(pattern);
            if (!regex.IsMatch(textBox1.Text))
            {
                textBox1.Text = "02:00";
            }
            else
            {
                var data = textBox1.Text.Split(":");
                if (data.Length == 2 && data[0].Length == 2 && data[1].Length == 2)
                {
                    if (!(Operation.IsNumeral(data[0]) && Operation.IsNumeral(data[1])))
                    {
                        textBox1.Text = "02:00";
                    }
                    else
                    {
                        if (Convert.ToInt32(data[1]) >= 60)
                        {
                            textBox1.Text = $"{data[0]}:00";
                        }
                    }
                }
                else
                {
                    textBox1.Text = "02:00";
                }
            }
        }
    }
}
