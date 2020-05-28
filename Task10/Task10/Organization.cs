using System;

namespace Task10
{
    // Организация (абстрактный класс)
    abstract class Organization : IComparable
    {
        // Тип организации
        public string Type { get; set; }
        // Название организации
        public string Name { get; set; }
        // Количество мужчин работающих в организации
        public int Men { get; set; }
        // Количество женщин работающих в организации
        public int Women { get; set; }

        // Констуктор
        public Organization(string type, string name)
        {
            Type = type;
            Name = name;
        }

        // Констуктор
        public Organization(string type, string name, int men, int women)
        {
            Type = type;
            Name = name;
            Men = men;
            Women = women;
        }

        // Объявление виртуального метода
        public virtual void showInfo()
        {
            Console.WriteLine("Организация:");
            Console.WriteLine("Тип: " + Type + ", Название: " + Name);
        }

        // Кол-во мужчин
        public void showMen()
        {
            Console.WriteLine("Кол-во мужчин: " + Men);
        }

        // Кол-во женщин
        public void showWomen()
        {
            Console.WriteLine("Кол-во женщин: " + Women);
        }

        // Реализация интерфейса сравнения
        public int CompareTo(object obj)
        {
            // Приведение к типу Organization
            Organization temp = (Organization)obj;
            // Сравнение названий организаций
            if (String.Compare(this.Name, temp.Name) > 0)
                return 1;
            if (String.Compare(this.Name, temp.Name) < 0)
                return -1;
            return 0;
        }
    }
}
