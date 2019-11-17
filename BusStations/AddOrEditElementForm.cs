using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BusStationsClassLibrary;

namespace BusStations
{
    public partial class AddOrEditElementForm : Form
    {
        /// <summary>
        /// Экземпляр остановки.
        /// </summary>
        public static BusStation NewBusStation { get; set; }

        /// <summary>
        /// Конструктор класса, в котором происходит инициализация формы.
        /// </summary>
        public AddOrEditElementForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод для форматирования строки: замены ‘;’ на ‘,’ во избежание ошибок при конвертировании таблицы 
        /// в CSV-файл и удаляющий лишние пробелы в конце строки.
        /// </summary>
        /// <param name="s">Входная строка</param>
        /// <returns></returns>
        private static string FormatString(string s)
        {
            for (var i = 0; i < s.Length; i++)
            {
                s = s.Replace(';', ',');
                s = s.TrimEnd(' ');
            }
            return s;
        }

        /// <summary>
        /// Метод для проверки наличия остановки с заданным идентификационным номером в списке имеющихся.
        /// </summary>
        /// <param name="id">Идентификационный номер</param>
        /// <returns></returns>
        private static bool CheckIfItemWithThisIdExists(string id) => 
            BusStationsForm.BusStations.All(busStation => busStation.Id != id);
        

        /// <summary>
        /// Метод для проверки строки на наличие каких-либо символов, кроме цифр.
        /// </summary>
        /// <param name="s">Входная строка</param>
        /// <returns></returns>
        private static bool IsAllNumbersString(string s)
        {
            foreach (var symbol in s)
            {
                if (symbol < 48 & symbol > 57) return false;
            }

            return true;
        }

        /// <summary>
        /// Метод для проверки соответствия входной строки необходимому формату даты.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static bool CheckDateFormatString(string s)
        {
            var match = Regex.Match(s, "[0-3][0-9].[0-1][0-9].[0-9]{4}");
            return match.Success;
        }

        /// <summary>
        /// Метод для задания параметра id по информации из idTextBox.
        /// Показывает соответствующее сообщение, если остановка с таким номером уже существует в таблице.
        /// При несоответствии входной строки условиям задает параметр пустой строкой.
        /// </summary>
        /// <param name="textBoxText">Информация из idTextBox</param>
        /// <param name="id">Идентификационный номер</param>
        /// <param name="counter">Счетчик количества неверно заданных параметров</param>
        private static void SetId(string textBoxText, out string id, ref int counter)
        {
            if (!CheckIfItemWithThisIdExists(textBoxText))
            {
                MessageBox.Show(@"Bus station with this ID already exists.");
                id = string.Empty;
                return;
            }
            
            if (IsAllNumbersString(textBoxText) && CheckIfItemWithThisIdExists(textBoxText))
            {
                id = textBoxText;
            }
            else
            {
                ++counter;
                id = string.Empty;
            }
        }

        /// <summary>
        /// Метод для задания параметра registrationDate по информации из registrationDateTextBox.
        /// При несоответствии входной строки условиям задает параметр пустой строкой.
        /// </summary>
        /// <param name="textBoxText">Информация из registrationDateTextBox</param>
        /// <param name="registrationDate">Регистрационная дата остановки</param>
        /// <param name="counter">Счетчик количества неверно заданных параметров</param>
        private static void SetRegistrationDate(string textBoxText, out string registrationDate, ref int counter)
        {
            if (CheckDateFormatString(textBoxText))
            {
                registrationDate = textBoxText;
            }
            else
            {
                ++counter;
                registrationDate = string.Empty;
            }
        }

        /// <summary>
        /// Метод для задания параметра flow по информации из flowTextBox.
        /// При несоответствии входной строки условиям задает параметр пустой строкой.
        /// </summary>
        /// <param name="textBoxText">Информация из flowTextBox</param>
        /// <param name="flow">Потокооборот остановки</param>
        /// <param name="counter">Счетчик количества неверно заданных параметров</param>
        private static void SetFlow(string textBoxText, out string flow, ref int counter)
        {
            if (IsAllNumbersString(textBoxText))
            {
                flow = textBoxText;
            }
            else
            {
                ++counter;
                flow = string.Empty;
            }
        }

        /// <summary>
        /// Метод для задания параметра maintenanceTime по информации из maintenanceTimeTextBox.
        /// При несоответствии входной строки условиям задает параметр пустой строкой.
        /// </summary>
        /// <param name="textBoxText">Информация из maintenanceTimeTextBox</param>
        /// <param name="maintenanceTime"></param>
        /// <param name="counter">Счетчик количества неверно заданных параметров</param>
        private static void SetMaintenanceTime(string textBoxText, out string maintenanceTime, ref int counter)
        {
            if (IsAllNumbersString(textBoxText))
            {
                maintenanceTime = textBoxText;
            }
            else
            {
                ++counter;
                maintenanceTime = string.Empty;
            }
        }

        /// <summary>
        /// Метод для получения информации о новой остановке.
        /// Если какие-то данные были введены некорректно, сообщает об этом пользователю с помощью messageBox,
        /// иначе инициализирует новую остановку данными, заданными пользователем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetInformationButton_Click(object sender, EventArgs e)
        {
            var counter = 0;

            var name = FormatString(nameTextBox.Text);
            SetId(idTextBox.Text, out var id, ref counter);
            SetRegistrationDate(registrationDateTextBox.Text, out var registrationDate, ref counter);
            var location = FormatString(locationTextBox.Text);
            var owner = FormatString(ownerTextBox.Text);
            SetFlow(flowTextBox.Text, out var flow, ref counter);
            SetMaintenanceTime(maintenanceTimeTextBox.Text, out var maintenanceTime, ref counter);
            var road = FormatString(roadTextBox.Text);

            if (counter > 0)
            {
                MessageBox.Show(@"You entered incorrect data. Please try again.");
            }
            else
            {
                NewBusStation = new BusStation(name, 
                                               id, 
                                               registrationDate, 
                                               location, 
                                               new Owner(owner), 
                                               flow, 
                                               maintenanceTime, 
                                               road);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        /// <summary>
        ///  Метод для создания текста всплывающей подсказки для пользователя.
        /// </summary>
        /// <param name="labelText">Объект, на который "вешается" всплывающая подсказка.</param>
        /// <returns></returns>
        private static string TipInfo(string labelText) =>
            $"{labelText} cannot contain ';'. This symbol will be \n automatically replaced with ',' if entered.";

        /// <summary>
        /// Метод для отображения всплывающей подсказки при наведении на элемент управления nameLabel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameLabel_MouseMove(object sender, MouseEventArgs e)
        {
            stringFieldToolTip.ShowAlways = true;
            stringFieldToolTip.SetToolTip(nameLabel, TipInfo(nameLabel.Text));
        }

        /// <summary>
        /// Метод для отображения всплывающей подсказки при наведении на элемент управления idLabel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IdLabel_MouseMove(object sender, MouseEventArgs e)
        {
            digitsFieldToolTip.ShowAlways = true;
            digitsFieldToolTip.SetToolTip(idLabel, $"{idLabel.Text} should contain only digits.");
        }

        /// <summary>
        /// Метод для отображения всплывающей подсказки при наведении на элемент управления registrationDateLabel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegistrationDateLabel_MouseMove(object sender, MouseEventArgs e)
        {
            rdToolTip.ShowAlways = true;
            rdToolTip.SetToolTip(registrationDateLabel, "Registration date should have format DD.MM.YYYY.");
        }

        /// <summary>
        /// Метод для отображения всплывающей подсказки при наведении на элемент управления locationLabel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LocationLabel_MouseMove(object sender, MouseEventArgs e)
        {
            stringFieldToolTip.ShowAlways = true;
            stringFieldToolTip.SetToolTip(locationLabel, TipInfo(locationLabel.Text));
        }

        /// <summary>
        /// Метод для отображения всплывающей подсказки при наведении на элемент управления ownerLabel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OwnerLabel_MouseMove(object sender, MouseEventArgs e)
        {
            stringFieldToolTip.ShowAlways = true;
            stringFieldToolTip.SetToolTip(ownerLabel, TipInfo(ownerLabel.Text));
        }

        /// <summary>
        /// Метод для отображения всплывающей подсказки при наведении на элемент управления flowLabel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlowLabel_MouseMove(object sender, MouseEventArgs e)
        {
            digitsFieldToolTip.ShowAlways = true;
            digitsFieldToolTip.SetToolTip(flowLabel, $"{flowLabel.Text} should contain only digits.");
        }

        /// <summary>
        /// Метод для отображения всплывающей подсказки при наведении на элемент управления maintenanceTimeLabel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaintenanceTimeLabel_MouseMove(object sender, MouseEventArgs e)
        {
            digitsFieldToolTip.ShowAlways = true;
            digitsFieldToolTip.SetToolTip(maintenanceTimeLabel, "Maintenance time should contain only digits.");
        }

        /// <summary>
        /// Метод для отображения всплывающей подсказки при наведении на элемент управления roadLabel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoadLabel_MouseMove(object sender, MouseEventArgs e)
        {
            stringFieldToolTip.ShowAlways = true;
            stringFieldToolTip.SetToolTip(roadLabel, TipInfo(roadLabel.Text));
        }
    }
}
