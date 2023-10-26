using SumOrMultiply.Logic;
using SumOrMultiply.Logic.Profiles;

namespace SumOrMultiply.ApplicationPlace
{

    /// <summary>
    /// Модная форма
    /// </summary>
    public partial class ModernMainForm : Form
    {
        // Поля \\
        protected string PathToProfiles = Directory.GetCurrentDirectory() + "\\profiles.txt";
        protected Profile? SelectedProfile = null;
        protected ProfileHandler ProfileHandler = new ProfileHandler();

        // Конструкторы \\
        public ModernMainForm()
        {
            InitializeComponent();
            UserInitialization();
            PlayButtonClick(this, new EventArgs());
        }

        // Методы \\
        /// <summary>
        /// Возвращает размер окна
        /// </summary>
        /// <returns></returns>
        public Size GetSize() => this.Size;
        /// <summary>
        /// Возвращает позицию окна
        /// </summary>
        /// <returns></returns>
        public Point GetPosition() => this.Location;

        /// <summary>
        /// Обработчик кнопки Выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Вызывается ProfileControlPanel, где задаётся профиль.
        /// </summary>
        /// <param name="profile"></param>
        public void SetSelectedProfile(Profile profile)
        {
            SelectedProfile = profile;
            button6.Text = profile.Name;

            ToolTip context = new ToolTip();
            context.SetToolTip(button6, $"Профиль:\n{profile.Name}\n{profile.Points} очков");
        }

        /// <summary>
        /// Считывание данных о форме.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModernMainForm_Load(object sender, EventArgs e)
        {
            // Взятие файла конфигурации
            if (File.Exists(Directory.GetCurrentDirectory() + "\\config.txt"))
            {
                using (StreamReader sw = new StreamReader(Directory.GetCurrentDirectory() + "\\config.txt"))
                {
                    string? line = sw.ReadLine(); // "Width Heigth"
                    var lines = line.Split();

                    Width = int.Parse(lines[0]);
                    Height = int.Parse(lines[1]);

                    line = sw.ReadLine(); // "X Y"
                    lines = line.Split();

                    Location = new Point(int.Parse(lines[0]), int.Parse(lines[1]));
                }
            }
            // Взятие файла с профилями
            if (File.Exists(PathToProfiles))
            {
                ProfileHandler.ReadFromFile(PathToProfiles);
            }
        }



        /// <summary>
        /// Сохранение данных о форме.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModernMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Запись в файл с конфигурацией
            using (StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "\\config.txt"))
            {
                sw.WriteLine($"{Width} {Height}");
                sw.WriteLine($"{Location.X} {Location.Y}");
            }

            // Запись в файл с профилями
            ProfileHandler.WriteToFile(PathToProfiles);
        }

        /// <summary>
        /// Кнопка О приложении
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutApplicationClick(object sender, EventArgs e)
        {
            SetActiveControl(infoPanel);

            string path = Directory.GetCurrentDirectory() + "\\README.txt";

            if (File.Exists(path))
            {
                string text;
                using (StreamReader sr = new StreamReader(path)) text = sr.ReadToEnd();
                infoPanel.InfoText = text;
            }
            else
            {
                infoPanel.InfoText = "Error:\nНе найден файл README.txt :(";
            }
        }

        /// <summary>
        /// Задача активного окружения.
        /// </summary>
        /// <param name="control"></param>
        protected void SetActiveControl(Control control)
        {
            infoPanel.Visible = false;
            profilePointsPanel.Visible = false;
            profileControlPanel1.Visible = false;
            playPanel1.Visible = false;

            control.Visible = true;
        }

        /// <summary>
        /// Обработчки кнопки Очки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PointsButtonClick(object sender, EventArgs e)
        {
            SetActiveControl(profilePointsPanel);

            profilePointsPanel.SetData(ProfileHandler);
        }

        /// <summary>
        /// Обработчик кнопки Профиль
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControlProfileButtonClick(object sender, EventArgs e)
        {
            SetActiveControl(profileControlPanel1);

            profileControlPanel1.SetRefOnMainForm(this);
            profileControlPanel1.SetData(ProfileHandler);
        }

        /// <summary>
        /// Обработчик кнопки Играть
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayButtonClick(object sender, EventArgs e)
        {
            SetActiveControl(playPanel1);

            if (SelectedProfile == null)
            {
                SelectedProfile = new Profile("Без аккаунта");
            }
        }
    }
}
