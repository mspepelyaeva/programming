using System;

namespace Task10
{
    // Библиотека
    class Library : Organization
    {
        // Констуктор
        public Library(string name) : base("Библиотека", name)
        {
        }

        // Констуктор
        public Library(string name, int men, int women) : base("Библиотека", name, men, women)
        {
        }

        // Переопределение метода
        public override void showInfo()
        {
            Console.WriteLine("Библиотека: " + Name);
        }
    }
}
