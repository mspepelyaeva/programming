using System;

namespace Task10
{
    // Страховая компания
    class InsuranceCompany : Organization
    {
        // Констуктор
        public InsuranceCompany(string name) : base("Страховая компания", name)
        {
        }

        // Констуктор
        public InsuranceCompany(string name, int men, int women) : base("Страховая компания", name, men, women)
        {
        }

        // Переопределение метода
        public override void showInfo()
        {
            Console.WriteLine("Страховая компания: " + Name);
        }
    }
}
