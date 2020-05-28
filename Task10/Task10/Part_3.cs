using System;
using System.Text;

namespace Task10
{
    class Part_3
    {
        static void Main(string[] args)
        {
            Organization[] organizations = new Organization[] {
                new InsuranceCompany("РосГосСтрах"),
                new InsuranceCompany("АльфаСтрахование"),
                new InsuranceCompany("ИнГосСтрах"),
                new ShipbuildingCompany("Объединенная судостроительная корпорация"),
                new ShipbuildingCompany("Верхнекамский Судостроительный Комплекс"),
                new ShipbuildingCompany("РосПромРесурс (Судостроительная Компания)"),
                new Factory("Пермский пороховой завод"),
                new Factory("ОДК-Пермские моторы"),
                new Factory("Лукойл-пермнефтеоргсинтез"),
                new Library("ГКБУК 'ПГКУБ им.А М.Горького'"),
                new Library("Центральная городская библиотека имени А. С. Пушкина"),
                new Library("Библиотека для молодежи им. Л.Н. Толстого")
            };

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Практическая работа №10");
            Console.WriteLine("4) организация, страховая компания, судостроительная компания, завод, библиотека");
            Console.WriteLine("Часть 3");

            Console.WriteLine("\nСписок организаций:");
            foreach (Organization organization in organizations)
            {
                organization.showInfo();
            }

            Console.WriteLine("\nСортировка по имени");
            Array.Sort(organizations, new SortByName());

            Console.WriteLine("\nОтсортированный список организаций:");
            foreach (Organization organization in organizations)
            {
                organization.showInfo();
            }

            Console.WriteLine("\nПоиск элемента в массиве:");
            Organization findOrganization = Array.Find(organizations, compareOrganization);
            if (findOrganization == null)
            {
                Console.WriteLine("Страховая компания 'ИнГосСтрах' не найдена");
            } else
            {
                findOrganization.showInfo();
            }

            Console.WriteLine("\nПоверхностное копирование:");
            Factory factory = new Factory("ОДК-Пермские моторы");
            Factory factoryCopy1 = factory.ShallowCopy();
            factory.showInfo();
            factoryCopy1.showInfo();

            Console.WriteLine("\nКлонирование:");
            Factory factoryCopy2 = (Factory) factory.Clone();
            factory.showInfo();
            factoryCopy2.showInfo();
        }

        // Функция сравнения
        private static bool compareOrganization(Organization organization)
        {
            return organization.Name.Equals("ИнГосСтрах", StringComparison.CurrentCulture);
        }
    }
}
