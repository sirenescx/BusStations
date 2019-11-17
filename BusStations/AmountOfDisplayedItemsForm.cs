using System;
using System.Windows.Forms;

namespace BusStations
{
    public partial class AmountOfDisplayedItemsForm : Form
    {
        /// <summary>
        /// Количество отображаемых элементов в таблице.
        /// </summary>
        private static int _amount;

        /// <summary>
        /// Свойство доступа к полю _amount.
        /// </summary>
        public static int Amount => _amount;

        /// <summary>
        /// Конструктор класса, в котором происходит инициализация формы.
        /// </summary>
        public AmountOfDisplayedItemsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод, устанавливающий количество отображаемых элементов числом из поля amountTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeAmountButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(amountTextBox.Text, out _amount) && 
                _amount > 1 && 
                _amount <= BusStationsForm.BusStations.Count)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show($@"Please enter correct number 1 < N < {BusStationsForm.BusStations.Count + 1}");
            }
        }
    }
}
