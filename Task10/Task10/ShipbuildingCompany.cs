using System;

namespace Task10
{
    // Судостроительная компания
    class ShipbuildingCompany : Organization
    {
        // Констуктор
        public ShipbuildingCompany(string name) : base("Судостроительная компания", name)
        {
        }

        // Констуктор
        public ShipbuildingCompany(string name, int men, int women) : base("Судостроительная компания", name, men, women)
        {
        }

        // Переопределение метода
        public override void showInfo()
        {
            Console.WriteLine("Судостроительная компания: " + Name);
        }
    }
}
