using System;
using System.Windows.Forms;

namespace BusStations
{
    public partial class FilterForm : Form
    {
        /// <summary>
        /// Фильтр-подстрока для фильтрации таблицы.
        /// </summary>
        public static string Filter { get; private set; }

        /// <summary>
        /// Конструктор класса, в котором происходит инициализация формы.
        /// </summary>
        public FilterForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод, устанавливающий значение поля filter текстом поля filterTextBox. 
        /// Если filter – пустая строка, то фильтр считается введенным некорректно и будет запрошен повторно. 
        /// При верном вводе фильтра происходит закрытие формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addFilterButton_Click(object sender, EventArgs e)
        {
            Filter = filterTextBox.Text;

            if (Filter != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("please enter filter");
            }
        }
    }
}
