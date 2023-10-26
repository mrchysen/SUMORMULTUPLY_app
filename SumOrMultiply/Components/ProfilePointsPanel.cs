using SumOrMultiply.Logic.Profiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumOrMultiply.Components
{
    /// <summary>
    /// Компонент, показывающий имя / очки.
    /// </summary>
    public partial class ProfilePointsPanel : UserControl
    {
        public ProfilePointsPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Задать данные. Читает данные профилей из profileHandler
        /// </summary>
        /// <param name="profileHandler"></param>
        public void SetData(ProfileHandler profileHandler)
        {
            profileHandler.Sort();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < profileHandler.Length; i++)
            {
                dataGridView1.Rows.Add(i, profileHandler[i].Name, profileHandler[i].Points);
            }
        }

    }
}
