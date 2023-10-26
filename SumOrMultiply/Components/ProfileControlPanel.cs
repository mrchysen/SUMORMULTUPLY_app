
using SumOrMultiply.Logic.Profiles;
using SumOrMultiply.ApplicationPlace;

namespace SumOrMultiply.Components
{
    public partial class ProfileControlPanel : UserControl
    {
        // Поля \\
        protected ProfileHandler ProfileHandler;
        protected int SelectedProfileId = 0;
        protected ModernMainForm MainForm;

        // Конструкторы \\
        public ProfileControlPanel()
        {
            InitializeComponent();
            AddingPanel.Visible = false;
        }

        // Свойства \\
        public Profile? GetSelectedProfile
        {
            get
            {
                if (ProfileHandler.Length > 0)
                {
                    return ProfileHandler[SelectedProfileId];
                }
                return null;
            }
        }

        // Методы \\
        #region Внешняя настройка элемента
        public void SetRefOnMainForm(ModernMainForm mainForm)
        {
            MainForm = mainForm;
        }

        public void SetData(ProfileHandler profileHandler)
        {
            profileHandler.Sort();

            dataGridView1.Rows.Clear();

            ProfileHandler = profileHandler;

            for (int i = 0; i < profileHandler.Length; i++)
            {
                dataGridView1.Rows.Add(i, profileHandler[i].Name);
            }
        }
        #endregion
        /// <summary>
        /// Обработчик кнопки Создать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateClick(object sender, EventArgs e)
        {
            if (AddingPanel.Visible)
                AddingPanel.Visible = false;
            else
                AddingPanel.Visible = true;
        }

        /// <summary>
        /// Обработчик кнопки Добавить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButtonClick(object sender, EventArgs e)
        {
            ProfileHandler.Add(new Profile(textBox1.Text));

            dataGridView1.Rows.Add(ProfileHandler.Length - 1, ProfileHandler[ProfileHandler.Length - 1].Name);

            AddingPanel.Visible = false;
        }

        /// <summary>
        /// Обработчик события выбора профиля в таблице.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectedCellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedProfileId = (int)e.RowIndex;
        }

        /// <summary>
        /// Обработчик кнопки выбрать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectClick(object sender, EventArgs e)
        {
            MainForm.SetSelectedProfile(GetSelectedProfile);
        }
    }
}
