using System;
using System.Text;

namespace Task10
{
    class Part_2
    {

        static void Main(string[] args)
        {
            Organization[] organizations = new Organization[] { 
                new InsuranceCompany("РосГосСтрах", 2, 12),
                new InsuranceCompany("АльфаСтрахование", 1, 10),
                new InsuranceCompany("ИнГосСтрах", 3, 15),

                new ShipbuildingCompany("Объединенная судостроительная корпорация", 120, 30),
                new ShipbuildingCompany("Верхнекамский Судостроительный Комплекс", 112, 34),
                new ShipbuildingCompany("РосПромРесурс (Судостроительная Компания)", 244, 71),

                new Factory("Пермский пороховой завод", 98, 43, 25),
                new Factory("ОДК-Пермские моторы", 351, 142, 72),
                new Factory("Лукойл-пермнефтеоргсинтез", 293, 88, 54),

                new Library("ГКБУК 'ПГКУБ им.А М.Горького'", 0, 12),
                new Library("Центральная городская библиотека имени А. С. Пушкина", 2, 29),
                new Library("Библиотека для молодежи им. Л.Н. Толстого", 1, 10)
            };

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Практическая работа №10");
            Console.WriteLine("4) организация, страховая компания, судостроительная компания, завод, библиотека");
            Console.WriteLine("Часть 2");
            Console.WriteLine("9. Количество инженеров на заводе.");
            Console.WriteLine("15. Количество мужчин (женщин).");
            Console.WriteLine("28. Количество библиотек в городе.");
            Console.WriteLine("0. Выход.");
            int variant;
            do
            {
                Console.WriteLine("Выберите вариант запроса (9, 15, 28, 0):");
                bool ok = int.TryParse(Console.ReadLine(), out variant)
                    && (variant == 0 || variant == 9 || variant == 15 || variant == 28);
                if (!ok)
                    continue;
                switch (variant)
                {
                    case 9:
                        variant9(ref organizations);
                        break;
                    case 15:
                        variant15(ref organizations);
                        break;
                    case 28:
                        variant28(ref organizations);
                        break;
                }
            } while (variant != 0);
            Console.ReadLine();
        }

        // 9. Количество инженеров на заводе
        private static void variant9(ref Organization[] organizations)
        {
            foreach (Organization organization in organizations)
            {
                if (organization is Factory)
                {
                    Factory factory = organization as Factory;
                    factory.showInfo();
                    factory.showEngineerCount();
                }
            }
        }

        // 15. Количество мужчин (женщин)
        private static void variant15(ref Organization[] organizations)
        {
            foreach (Organization organization in organizations)
            {
                organization.showInfo();
                organization.showMen();
                organization.showWomen();
                Console.WriteLine();
            }
        }

        // 28. Количество библиотек в городе
        private static void variant28(ref Organization[] organizations)
        {
            int cnt = 0;
            foreach (Organization organization in organizations)
            {
                if (organization is Library)
                {
                    cnt++;
                }
            }
            Console.WriteLine("В городе {0} библиотек", cnt);
            Console.WriteLine();
        }
    }
}
