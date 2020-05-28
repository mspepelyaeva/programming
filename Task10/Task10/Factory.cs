using System;

namespace Task10
{
    // Завод
    class Factory : Organization
    {
        // Тип организации
        public int Engineer { get; set; }

        // Констуктор
        public Factory(string name) : base("Завод", name)
        {
        }

        // Констуктор
        public Factory(string name, int men, int women, int engineer) : base("Завод", name, men, women)
        {
            Engineer = engineer;
        }

        // Переопределение метода
        public override void showInfo()
        {
            Console.WriteLine("Завод: " + Name);
        }

        // Кол-во инженеров
        public void showEngineerCount()
        {
            Console.WriteLine("Кол-во инженеров: " + Engineer);
        }

        // Поверхностное копирование
        public Factory ShallowCopy()
        {
            return (Factory)this.MemberwiseClone();
        }

        // Клонирование
        public object Clone()
        {
            return new Factory("Клон: " + this.Name);
        }
    }
}
