namespace BusStationsClassLibrary
{
    /// <summary>
    /// Класс остановки
    /// </summary>
    public class BusStation
    {
        /// <summary>
        /// Название остановки.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Идентификационный номер остановки.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Дата регистрации остановки.
        /// </summary>
        public string RegistrationDate { get; }

        /// <summary>
        /// Расположение остановки.
        /// </summary>
        public string Location { get; }

        /// <summary>
        /// Потокооборот остановки.
        /// </summary>
        public string Flow { get; }

        /// <summary>
        /// Владелец остановки.
        /// </summary>
        public Owner Owner { get; set; }

        /// <summary>
        /// Время обслуживания остановки.
        /// </summary>
        public string MaintenanceTime { get; }

        /// <summary>
        /// Наименование дороги, на которой находится остановка
        /// </summary>
        public string Road { get; }
        /// <summary>
        /// Конструктор класса остановки, задающий значения всем свойствам.
        /// </summary>
        /// <param name="name">Название остановки</param>
        /// <param name="id">Идентификационный номер остановки</param>
        /// <param name="registrationDate">Дата регистрации остановки</param>
        /// <param name="location">Расположение остановки</param>
        /// <param name="owner">Владелец остановки</param>
        /// <param name="flow">Потокооборот остановки</param>
        /// <param name="maintenanceTime">Время обслуживания остановки</param>
        /// <param name="road">Дорога, на которой находится остановка</param>
        public BusStation(string name, string id, string registrationDate, string location, 
                          Owner owner, string flow, string maintenanceTime, string road)
        {
            Name = name;
            Id = id;
            RegistrationDate = registrationDate;
            Location = location;
            Owner = owner;
            Flow = flow;
            MaintenanceTime = maintenanceTime;
            Road = road;
        }

        /// <summary>
        /// Свойство для подсчета количество остановок у компании-владельца.
        /// </summary>
        /// <returns></returns>
        public int AmountOfBusStations() => Owner.BusStations.Count;

        /// <summary>
        /// Переопределенный метод, формирующий и возвращающий строку со сведениями об элементе класса.  
        /// </summary>
        /// <returns></returns>
        public override string ToString() => 
            $"{Name};{Id};{RegistrationDate};{Location};{Owner.OwnerName};{Flow};{MaintenanceTime};{Road}\n";
    }
}
