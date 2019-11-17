using BusStationsClassLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BusStations
{
    public partial class BusStationsForm : Form
    {
        /// <summary>
        /// Список экземпляров остановок.
        /// </summary>
        public static List<BusStation> BusStations = new List<BusStation>();

        /// <summary>
        /// Строка, содержащая заголовки таблицы;
        /// </summary>
        public static string Headers;

        /// <summary>
        /// Список остановок, которые сейчас отображаются в таблице.
        /// </summary>
        public static List<BusStation> DisplayedBusStations = new List<BusStation>();

        /// <summary>
        /// Конструктор класса, в котором происходит инициализация формы, ее минимального и максимально возможного размера. 
        /// </summary>
        public BusStationsForm()
        {
            InitializeComponent();
            var resolution = Screen.PrimaryScreen.Bounds.Size;
            MinimumSize = new Size(resolution.Width / 2, resolution.Height / 2);
            MaximumSize = resolution;
        }

        /// <summary>
        /// Свойство доступа к MaximumSize
        /// </summary>
        public sealed override Size MaximumSize
        {
            get => base.MaximumSize;
            set => base.MaximumSize = value;
        }

        /// <summary>
        /// Свойство доступа к MinimumSize
        /// </summary>
        public sealed override Size MinimumSize
        {
            get => base.MinimumSize;
            set => base.MinimumSize = value;
        }

        /// <summary>
        /// Метод для добавления элемента в таблицу.
        /// </summary>
        /// <param name="busStation"></param>
        public void AddElementToGrid(BusStation busStation)
        {
            dataGridView.Rows.Add(busStation.Name, 
                                  busStation.Id, 
                                  busStation.RegistrationDate,
                                  busStation.Location, 
                                  busStation.Owner.OwnerName, 
                                  busStation.Flow,
                                  busStation.MaintenanceTime, 
                                  busStation.Road);
        }

        /// <summary>
        /// Метод для нумерации строк таблицы.
        /// </summary>
        public void UpdateNumbersInGrid()
        {
            for (var i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        /// <summary>
        /// Метод для изменения элемента в выбранной строке таблицы.
        /// </summary>
        /// <param name="busStation"></param>
        /// <param name="rowIndex"></param>
        public void ChangeElementInGrid(BusStation busStation, int rowIndex)
        {
            dataGridView.Rows[rowIndex].SetValues(busStation.Name, 
                                                  busStation.Id, 
                                                  busStation.RegistrationDate, 
                                                  busStation.Location, 
                                                  busStation.Owner.OwnerName, 
                                                  busStation.Flow,
                                                  busStation.MaintenanceTime, 
                                                  busStation.Road);
        }

        /// <summary>
        /// Метод для форматирования строки.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string TrimUselessQuotes(string s)
        {
            s = s.TrimStart('"', ' ', ',', '.');
            s = s.TrimEnd('"');
            return s;
        }

        /// <summary>
        /// Метод для сортировки таблицы полю Name в алфавитном порядке.
        /// </summary>
        public void SortByAlphabeticalOrderName()
        {
            var orderedDisplayedElements = from displayedBusStation in DisplayedBusStations
                                           orderby displayedBusStation.Name
                                           select displayedBusStation;

            dataGridView.Rows.Clear();

            foreach (var displayedBusStation in orderedDisplayedElements)
            {
                AddElementToGrid(displayedBusStation);
            }
        }

        /// <summary>
        /// Метод для сортировки таблицы полю Owner в алфавитном порядке.
        /// </summary>
        public void SortByAlphabeticalOrderOwner()
        {
            var orderedDisplayedElements = from displayedBusStation in DisplayedBusStations
                                           orderby displayedBusStation.Owner.OwnerName
                                           select displayedBusStation;

            dataGridView.Rows.Clear();

            foreach (var displayedBusStation in orderedDisplayedElements)
            {
                AddElementToGrid(displayedBusStation);
            }
        }

        /// <summary>
        /// Метод для сортировки таблицы по полю Name по возрастанию поля Flow.
        /// </summary>
        public void SortByAscendingOrderName()
        {
            var orderedDisplayedElements = from displayedBusStation in DisplayedBusStations
                                           orderby displayedBusStation.Flow.Length,
                                                   displayedBusStation.Flow,
                                                   displayedBusStation.Name
                                           select displayedBusStation;

            dataGridView.Rows.Clear();

            foreach (var displayedBusStation in orderedDisplayedElements)
            {
                AddElementToGrid(displayedBusStation);
            }
        }

        /// <summary>
        /// Метод для сортировки таблицы по полю Owner по возрастанию поля Flow.
        /// </summary>
        public void SortByAscendingOrderOwner()
        {
            var orderedDisplayedElements = from displayedBusStation in DisplayedBusStations
                                           orderby displayedBusStation.Flow.Length,
                                                   displayedBusStation.Flow,
                                                   displayedBusStation.Owner.OwnerName
                                           select displayedBusStation;

            dataGridView.Rows.Clear();

            foreach (var displayedBusStation in orderedDisplayedElements)
            {
                AddElementToGrid(displayedBusStation);
            }
        }

        /// <summary>
        /// Метод для сортировки таблицы по возрастанию количества остановок у владельца.
        /// </summary>
        public void SortByAmountOfBusStations()
        {
            var orderedDisplayedElements = from displayedBusStation in DisplayedBusStations
                                           orderby displayedBusStation.AmountOfBusStations(),
                                                   displayedBusStation.Owner.OwnerName
                                           select displayedBusStation;

            dataGridView.Rows.Clear();

            foreach (var displayedBusStation in orderedDisplayedElements)
            {
                AddElementToGrid(displayedBusStation);
            }
        }

        /// <summary>
        /// Метод для фильтрации таблицы по полю Flow.
        /// </summary>
        /// <param name="filter"></param>
        public void ApplyFlowFilter(string filter)
        {
            var filteredBusStations =
                BusStations.Where(busStation =>
                    busStation.Flow.ToLower().Contains(filter.ToLower())).ToList();

            var filteredDisplayedBusStations =
                DisplayedBusStations.Where(displayedBusStation =>
                    displayedBusStation.Flow.ToLower().Contains(filter.ToLower())).ToList();

            if (filteredDisplayedBusStations.Count == 0 || filteredBusStations.Count == 0)
            {
                MessageBox.Show(@"No items found.");
            }
            else
            {
                dataGridView.Rows.Clear();

                foreach (var filteredDisplayedBusStation in filteredDisplayedBusStations)
                {
                    AddElementToGrid(filteredDisplayedBusStation);
                }
            }
        }

        /// <summary>
        /// Метод для фильтрации таблицы по полю Road.
        /// </summary>
        /// <param name="filter"></param>
        public void ApplyRoadFilter(string filter)
        {
            var filteredBusStations =
                BusStations.Where(busStation =>
                    busStation.Road.ToLower().Contains(filter.ToLower())).ToList();

            var filteredDisplayedBusStations =
                DisplayedBusStations.Where(displayedBusStation =>
                    displayedBusStation.Road.ToLower().Contains(filter.ToLower())).ToList();

            if (filteredDisplayedBusStations.Count == 0 || filteredBusStations.Count == 0)
            {
                MessageBox.Show(@"No items found.");
            }
            else
            {
                dataGridView.Rows.Clear();

                foreach (var filteredDisplayedBusStation in filteredDisplayedBusStations)
                {
                    AddElementToGrid(filteredDisplayedBusStation);
                }
            }
        }

        /// <summary>
        /// Метод для открытия файла и занесения информации из файла в объекты класса BusStation, 
        /// а также заполнение таблицы dataGridView этими данными.
        /// </summary>
        public void OpenFile()
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = @"csv files(*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                try
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var fileStream = openFileDialog.OpenFile();

                        using (var reader = new StreamReader(fileStream, Encoding.GetEncoding(1251)))
                        {
                            string line;
                            Headers = reader.ReadLine();
                            while ((line = reader.ReadLine()) != null)
                            {
                                var cells = line.Split(';');
                                var busStation = new BusStation(
                                    TrimUselessQuotes(cells[0]), 
                                    cells[1], 
                                    cells[2], 
                                    TrimUselessQuotes(cells[3]),
                                    new Owner(TrimUselessQuotes(cells[4])), 
                                    cells[5], 
                                    cells[6], 
                                    TrimUselessQuotes(cells[7]));
                                busStation.Owner = BusStationsClassLibrary.Owner.GetOwnerByName(busStation.Owner.OwnerName);
                                busStation.Owner.AddBusStation(busStation.Name);
                                BusStations.Add(busStation);
                                DisplayedBusStations.Add(busStation);
                                AddElementToGrid(busStation);
                            }
                        }
                    }
                    UpdateNumbersInGrid();
                }
                catch (Exception ex) { MessageBox.Show(@"Error opening file: " + ex.Message); }
            }
        }

        /// <summary>
        /// Обработчик события открытия файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BusStations.Count != 0)
            {
                var dialogResult = MessageBox.Show(@"Are you sure you want to close this file and open new file?",
                    @"Open new file", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult != DialogResult.Yes)
                {
                    return;
                }

                dataGridView.Rows.Clear();
                BusStations.Clear();
                DisplayedBusStations.Clear();
                OpenFile();

                if (dataGridView.RowCount > 1)
                {
                    DeleteToolStripButton.Enabled = true;
                }
            }
            else
            {
                OpenFile();
            }
        }

        /// <summary>
        /// Метод для отображения информации о произошедшей ошибки в MessageBox.
        /// </summary>
        /// <param name="operation">Операция, которую производил пользователь</param>
        private static void ShowError(string operation)
        {
            MessageBox.Show($@"Something went wrong with {operation}. Please try again.",
                @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Обработчик события для добавления элемента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                var addElementForm = new AddOrEditElementForm();

                if (addElementForm.ShowDialog(this) == DialogResult.OK)
                {
                    var newBusStation = AddOrEditElementForm.NewBusStation;
                    newBusStation.Owner = BusStationsClassLibrary.Owner.GetOwnerByName(newBusStation.Owner.OwnerName);
                    newBusStation.Owner.AddBusStation(newBusStation.Name);
                    DisplayedBusStations.Add(newBusStation);
                    BusStations.Add(newBusStation);
                    AddElementToGrid(newBusStation);
                }

                UpdateNumbersInGrid();
                addElementForm.Dispose();
            }
            catch (Exception)
            {
                ShowError("adding element");
            }
        }

        /// <summary>
        /// Обработчик события для редактирования элемента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (BusStations.Count == 0)
                {
                    MessageBox.Show(@"Please choose file to edit.");
                }
                else
                {
                    var editElementForm = new AddOrEditElementForm
                    {
                        Text = @"Edit element"
                    };

                    if (editElementForm.ShowDialog(this) == DialogResult.OK)
                    {
                        var newBusStation = AddOrEditElementForm.NewBusStation;

                        var id = newBusStation.Id;
                        int dIndex = 0, ddIndex = 0;

                        for (var i = 0; i < BusStations.Count; i++)
                        {
                            if (BusStations[i].Id == id) dIndex = i;
                        }

                        for (var i = 0; i < DisplayedBusStations.Count; i++)
                        {
                            if (DisplayedBusStations[i].Id == id) ddIndex = i;
                        }

                        BusStationsClassLibrary.Owner.ResetOwners(BusStations);
                        BusStationsClassLibrary.Owner.ResetOwners(DisplayedBusStations);
                        DisplayedBusStations[ddIndex] = newBusStation;
                        BusStations[dIndex] = newBusStation;

                        if (dataGridView.CurrentRow != null)
                        {
                            ChangeElementInGrid(newBusStation, dataGridView.CurrentRow.Index);
                        }
                    }

                    UpdateNumbersInGrid();
                    editElementForm.Dispose();
                }
            }
            catch (Exception)
            {
                ShowError("editing element");
            }
        }

        /// <summary>
        /// Обработчик события для удаления элемента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (BusStations.Count == 0)
                {
                    MessageBox.Show(@"Please choose file to delete from.");
                    return;
                }

                if (dataGridView.Rows.Count == 1)
                {
                    DeleteToolStripButton.Enabled = false;
                }
                else
                {
                    if (dataGridView.CurrentRow != null)
                    {
                        var index = dataGridView.CurrentRow.Index;
                        var busStation = new BusStation(dataGridView.Rows[index].Cells[0].Value.ToString(),
                            dataGridView.Rows[index].Cells[1].Value.ToString(),
                            dataGridView.Rows[index].Cells[2].Value.ToString(),
                            dataGridView.Rows[index].Cells[3].Value.ToString(),
                            new Owner(dataGridView.Rows[index].Cells[4].Value.ToString()),
                            dataGridView.Rows[index].Cells[5].Value.ToString(),
                            dataGridView.Rows[index].Cells[6].Value.ToString(),
                            dataGridView.Rows[index].Cells[7].Value.ToString());
                        var id = busStation.Id;
                        int dIndex = 0, ddIndex = 0;

                        for (var i = 0; i < BusStations.Count; i++)
                        {
                            if (BusStations[i].Id == id) dIndex = i;
                        }

                        for (var i = 0; i < DisplayedBusStations.Count; i++)
                        {
                            if (DisplayedBusStations[i].Id == id) ddIndex = i;
                        }

                        busStation.Owner.RemoveBusStation(busStation.Name);
                        dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);
                        DisplayedBusStations.RemoveAt(ddIndex);
                        BusStations.RemoveAt(dIndex);
                    }
                }

                UpdateNumbersInGrid();
            }
            catch (Exception)
            {
                ShowError("deleting element");
            }
        }

        /// <summary>
        /// Обработчик события для сортировки таблицы по алфавитному порядку поля Name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortByAscendingNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BusStations.Count == 0)
                {
                    MessageBox.Show(@"Please choose file to sort.");
                }

                SortByAlphabeticalOrderName();
                UpdateNumbersInGrid();
            }
            catch (Exception)
            {
                ShowError("sorting");
            }
        }

        /// <summary>
        /// Обработчик события для сортировки таблицы по алфавитному порядку поля Owner.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortByAscendingOwnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BusStations.Count == 0)
                {
                    MessageBox.Show(@"Please choose file to sort.");
                }

                SortByAlphabeticalOrderOwner();
                UpdateNumbersInGrid();
            }
            catch (Exception)
            {
                ShowError("sorting");
            }
        }

        /// <summary>
        /// Обработчик события для сортировки таблицы по возрастанию поля Flow по полю Name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortByAscendingFlowNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BusStations.Count == 0)
                {
                    MessageBox.Show(@"Please choose file to sort.");
                }

                SortByAscendingOrderName();
                UpdateNumbersInGrid();
            }
            catch (Exception)
            {
                ShowError("sorting");
            }
        }

        /// <summary>
        /// Обработчик события для сортировки таблицы по возрастанию поля Flow по полю Owner.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortByAscendingFlowOwnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BusStations.Count == 0)
                {
                    MessageBox.Show(@"Please choose file to sort.");
                }

                SortByAscendingOrderOwner();
                UpdateNumbersInGrid();
            }
            catch (Exception)
            {
                ShowError("sorting");
            }
        }

        /// <summary>
        /// Метод для отмены сортировки/фильтрации в таблице.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UndoSortingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BusStations.Count == 0)
            {
                return;
            }

            dataGridView.Rows.Clear();

            foreach (var displayedBusStation in DisplayedBusStations)
            {
                AddElementToGrid(displayedBusStation);
            }

            UpdateNumbersInGrid();

            if (dataGridView.RowCount > 1)
            {
                DeleteToolStripButton.Enabled = true;
            }
        }

        /// <summary>
        /// Обработчик события для фильтрации файла по полю Flow.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlowFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BusStations.Count == 0)
                {
                    MessageBox.Show(@"Please choose file to filter.");
                }
                else
                {
                    var filterForm = new FilterForm();

                    if (filterForm.ShowDialog(this) == DialogResult.OK)
                    {
                        ApplyFlowFilter(FilterForm.Filter);
                        UpdateNumbersInGrid();
                    }

                    filterForm.Dispose();
                }
            }
            catch (Exception)
            {
                ShowError("filtration");
            }
        }

        /// <summary>
        /// Обработчик события для фильтрации файла по полю Road.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoadFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BusStations.Count == 0)
                {
                    MessageBox.Show(@"Please choose file to filter.");
                }
                else
                {
                    var filterForm = new FilterForm();

                    if (filterForm.ShowDialog(this) == DialogResult.OK)
                    {
                        ApplyRoadFilter(FilterForm.Filter);
                        UpdateNumbersInGrid();
                    }

                    filterForm.Dispose();
                }
            }
            catch (Exception)
            {
                ShowError("filtration");
            }
        }

        /// <summary>
        /// Обработчик события для сортировки таблицы по возрастанию количества остановок у владельца.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ByAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BusStations.Count == 0)
                {
                    MessageBox.Show(@"Please choose file to sort.");
                }

                SortByAmountOfBusStations();
                UpdateNumbersInGrid();
            }
            catch (Exception)
            {
                ShowError("filtration");
            }
        }

        /// <summary>
        /// Обработчик события для сохранения содержимого таблицы в новый файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAsNewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.RowCount == 0)
            {
                MessageBox.Show(@"Please choose file to save.");
                return;
            }

            var savedBusStations = new List<BusStation>();
            for (var i = 0; i < dataGridView.RowCount; i++)
            {
                savedBusStations.Add(new BusStation(dataGridView.Rows[i].Cells[0].Value.ToString(),
                                     dataGridView.Rows[i].Cells[1].Value.ToString(),
                                     dataGridView.Rows[i].Cells[2].Value.ToString(),
                                     dataGridView.Rows[i].Cells[3].Value.ToString(),
                                     new BusStationsClassLibrary.Owner(dataGridView.Rows[i].Cells[4].Value.ToString()),
                                     dataGridView.Rows[i].Cells[5].Value.ToString(),
                                     dataGridView.Rows[i].Cells[6].Value.ToString(),
                                     dataGridView.Rows[i].Cells[7].Value.ToString()));
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = @"csv files(*.csv)|*.csv";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.CreatePrompt = false;
                saveFileDialog.CheckFileExists = false;

                try
                {
                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    var filePath = saveFileDialog.FileName;

                    using (var writer = new StreamWriter(filePath, false, Encoding.Default))
                    {
                        writer.WriteLine(Headers);
                        foreach (var savedBusStation in savedBusStations)
                        {
                            writer.Write(savedBusStation.ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Обработчик события для сохранения содержимого таблицы вместо уже существующего файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReplaceExistingFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.RowCount == 0)
            {
                MessageBox.Show(@"Please choose file to save.");
                return;
            }

            var savedBusStations = new List<BusStation>();
            for (var i = 0; i < dataGridView.RowCount; i++)
            {
                savedBusStations.Add(new BusStation(dataGridView.Rows[i].Cells[0].Value.ToString(),
                                     dataGridView.Rows[i].Cells[1].Value.ToString(),
                                     dataGridView.Rows[i].Cells[2].Value.ToString(),
                                     dataGridView.Rows[i].Cells[3].Value.ToString(),
                                     new BusStationsClassLibrary.Owner(dataGridView.Rows[i].Cells[4].Value.ToString()),
                                     dataGridView.Rows[i].Cells[5].Value.ToString(),
                                     dataGridView.Rows[i].Cells[6].Value.ToString(),
                                     dataGridView.Rows[i].Cells[7].Value.ToString()));
            }

            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = @"csv files(*.csv)|*.csv";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.CreatePrompt = false;
                saveFileDialog.CheckFileExists = true;

                try
                {
                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    var filePath = saveFileDialog.FileName;

                    using (StreamWriter writer = new StreamWriter(filePath, false, System.Text.Encoding.Default))
                    {
                        writer.WriteLine(Headers);
                        foreach (var savedBusStation in savedBusStations)
                        {
                            writer.Write(savedBusStation.ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Обработчик события для сохранения содержимого таблицы, добавляя его в уже существующий файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToExistingFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.RowCount == 0)
            {
                MessageBox.Show(@"Please choose file to save.");
                return;
            }

            var savedBusStations = new List<BusStation>();
            for (var i = 0; i < dataGridView.RowCount; i++)
            {
                savedBusStations.Add(new BusStation(dataGridView.Rows[i].Cells[0].Value.ToString(),
                                     dataGridView.Rows[i].Cells[1].Value.ToString(),
                                     dataGridView.Rows[i].Cells[2].Value.ToString(),
                                     dataGridView.Rows[i].Cells[3].Value.ToString(),
                                     new BusStationsClassLibrary.Owner(dataGridView.Rows[i].Cells[4].Value.ToString()),
                                     dataGridView.Rows[i].Cells[5].Value.ToString(),
                                     dataGridView.Rows[i].Cells[6].Value.ToString(),
                                     dataGridView.Rows[i].Cells[7].Value.ToString()));
            }


            var busStationsInFile = new List<BusStation>();

            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = @"csv files(*.csv)|*.csv";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.OverwritePrompt = false;
                saveFileDialog.CreatePrompt = true;
                saveFileDialog.CheckFileExists = true;

                try
                {
                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    var filePath = saveFileDialog.FileName;

                    using (var reader = new StreamReader(filePath, Encoding.GetEncoding(1251)))
                    {
                        string line;
                        reader.ReadLine();
                        while ((line = reader.ReadLine()) != null)
                        {
                            var cells = line.Split(';');
                            var b = new BusStation(TrimUselessQuotes(cells[0]), cells[1], cells[2], TrimUselessQuotes(cells[3]),
                                new Owner(TrimUselessQuotes(cells[4])), cells[5], cells[6], TrimUselessQuotes(cells[7]));
                            busStationsInFile.Add(b);
                        }
                    }

                    var flag = true;

                    foreach (var savedBusStation in savedBusStations)
                    {
                        foreach (var busStation in busStationsInFile)
                        {
                            if (savedBusStation.Id == busStation.Id)
                            {
                                flag = false;
                            }
                        }
                    }

                    if (flag == false)
                    {
                        MessageBox.Show(@"This file already contains bus station with ID from your file. Saving could not be done.",
                            @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        using (StreamWriter writer = new StreamWriter(filePath, true, System.Text.Encoding.Default))
                        {
                            foreach (var savedBusStation in savedBusStations)
                            {
                                writer.Write(savedBusStation.ToString());
                            }
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        /// <summary>
        /// Обработчик события для изменения количества отображаемых элементов в таблице.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.Rows.Count == 0)
                {
                    MessageBox.Show(@"Please choose file.");
                }
                else
                {
                    var amountOfDisplayedItemsForm = new AmountOfDisplayedItemsForm();
                    if (amountOfDisplayedItemsForm.ShowDialog(this) == DialogResult.OK)
                    {
                        dataGridView.Rows.Clear();
                        DisplayedBusStations.Clear();

                        for (var i = 0; i < AmountOfDisplayedItemsForm.Amount; i++)
                        {
                            DisplayedBusStations.Add(BusStations[i]);
                            AddElementToGrid(BusStations[i]);
                        }

                        UpdateNumbersInGrid();
                        if (dataGridView.RowCount > 1)
                        {
                            DeleteToolStripButton.Enabled = true;
                        }
                    }

                    amountOfDisplayedItemsForm.Dispose();
                }
            }
            catch (Exception)
            {
                ShowError("changing amount of displayed elements");
            }
        }
    }
}
