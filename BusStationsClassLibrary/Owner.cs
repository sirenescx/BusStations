using System.Collections.Generic;

namespace BusStationsClassLibrary
{
    /// <summary>
    /// Класс Владелец.
    /// </summary>
    public class Owner
    {
        /// <summary>
        /// Ассоциативный массив со всеми объектами владельцев, состоящий из пар вида: наименование компании-владельца, владелец.
        /// </summary>
        static readonly Dictionary<string, Owner> Owners = new Dictionary<string, Owner>();

        /// <summary>
        /// Наименование владельца остановки.
        /// </summary>
        public string OwnerName { get; set; }

        /// <summary>
        /// Конструктор, инициализирующий словарь BusStations и задающий значение свойству OwnerName
        /// </summary>
        /// <param name="ownerName">Наименование владельца остановки</param>
        public Owner(string ownerName)
        {
            OwnerName = ownerName;
            BusStations = new Dictionary<string, int>();
        }

        /// <summary>
        /// Метод, добавляющий наименование компании-владельца, если его нет в словаре.
        /// </summary>
        /// <param name="ownerName">Наименование владельца остановки</param>
        /// <returns></returns>
        public static Owner GetOwnerByName(string ownerName)
        {
            if (!Owners.ContainsKey(ownerName))
            {
                Owners[ownerName] = new Owner(ownerName);
            }

            return Owners[ownerName];
        }

        /// <summary>
        /// Свойство доступа к словарю со всеми объектами остановок с парами вида: наименование компании-владельца, 
        /// количество остановок с таким названием у владельца;
        /// </summary>
        public Dictionary<string, int> BusStations { get; }

        /// <summary>
        /// Метод, добавляющий упоминание об остановке.
        /// </summary>
        /// <param name="busStationName">Название остановки</param>
        public void AddBusStation(string busStationName)
        {
            if (BusStations.ContainsKey(busStationName))
            {
                ++BusStations[busStationName];
            }
            else
            { 
                BusStations[busStationName] = 1;
            }
        }

        /// <summary>
        /// Метод, удаляющий упоминание об остановке. 
        /// Если были удалены все остановки у данной компании-владельца, то их количество устанавливается нулем.
        /// </summary>
        /// <param name="busStationName">Название остановки</param>
        public void RemoveBusStation(string busStationName)
        {
            if (!BusStations.ContainsKey(busStationName))
            {
                return;
            }

            --BusStations[busStationName];

            if (BusStations[busStationName] == 0)
            {
                BusStations.Remove(busStationName);
            }
        }

        /// <summary>
        /// Метод для обновления информации об остановках.
        /// </summary>
        /// <param name="busStations">Список остановок</param>
        public static void ResetOwners(List<BusStation> busStations)
        {
            Owners.Clear();
            foreach (var busStation in busStations)
            {
                busStation.Owner = GetOwnerByName(busStation.Owner.OwnerName);
                busStation.Owner.AddBusStation(busStation.Name);
            }
        }
    }
}