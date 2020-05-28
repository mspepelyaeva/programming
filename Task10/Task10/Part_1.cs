using System;
using System.Text;

namespace Task10
{
    class Part_1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Практическая работа №10");
            Console.WriteLine("4) организация, страховая компания, судостроительная компания, завод, библиотека");
            Console.WriteLine("Часть 1");

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

            foreach (Organization organization in organizations)
            {
                organization.showInfo();
            }
        }
    }
}
