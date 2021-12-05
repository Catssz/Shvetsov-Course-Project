using System.Text.RegularExpressions;

namespace Taxopark
{
    // Перечисление, хранящее все возможные классы легковых автомобилей
    public enum CarClass
    {
        A, B, C, D, E, F, J, M, S
    }

    /**
     * Абстрактный класс "Легковой автомобиль"
     * 
     * В связи с данной абстрактностью, характеристики автомобиля (поля класса) могут иметь различную локализацию.
     * Но в рамках данной программы характеристики устанавливаются учитывая российскую метрику и российский стандарт гос. номеров
     */
    public abstract class PassengerCar
    {
        // Класс легкового автомобиля
        public CarClass carClass { get; protected set; }

        // Максимальная скорость (средняя по модификациям), измеряемая в км/ч
        public float maxSpeed { get; protected set; }
        // Минимальный и максимальный расход топлива, измеряемый в л/100км
        public float minFuelConsumption { get; protected set; }
        public float maxFuelConsumption { get; protected set; }

        // Гос. номер автомобиля, вида "a000aa, 00 RUS"
        // Приватное поле, хранящее непосредственно гос. номер (либо корректный либо null)
        private string _number;

        // Публичное свойство для инициализации приватного поля
        public string number { 
            // При простом обращении к свойству, вернуть значение поля _number
            get => _number; 
            
            // При присвоении значения свойству
            protected set
            {
                // Проверить подходит ли значение под маску: "[буква][3 цифры][2 буквы], [2 или 3 цифры] RUS"
                if(Regex.IsMatch(value, @"^[А-ЯЁа-яё]\d{3}[А-ЯЁа-яё]{2}, \d{2,3} RUS$"))
                {
                    // Если да, установить присваемое значение
                    _number = value;
                } else
                {
                    // Если нет, установить значение - null
                    _number = null;
                }
            }
        }
        // Официальный диллер
        public string dealer { get; protected set; }
        // Модель автомобиля
        public string model { get; protected set; }

        /** 
         * Получение рандомного гос. номера заданной страны (по умолчанию - России)
         * 
         * Метод является статическим для того, чтобы можно было генерировать гос. номер отдельно от класса автомобиля
         */
        public static string GetRandomNumber()
        {
            /**
             * Вернуть строку состоящую из:
             * 
             * 1) Серии (1 буква)
             * 2) Регистрационного номера (3 цифры)
             * 3) Серии (2 буквы)
             * 4) Кода региона (2 или 3 цифры)
             * 5) Страны (RUS)
             */
            return RandomData.GetString(1) + RandomData.GetInteger(100, 1000) + RandomData.GetString(2) + ", " + RandomData.GetInteger(10, 1000) + " RUS";
        }

        // Конструктор, доступный только для классов-наследников, использующийся для инициализации полей
        protected PassengerCar(CarClass carClass, float maxSpeed, float minFuelConsumption, float maxFuelConsumption, string number, string dealer, string model)
        {
            this.carClass = carClass;

            this.maxSpeed = maxSpeed;
            this.minFuelConsumption = minFuelConsumption;
            this.maxFuelConsumption = maxFuelConsumption;

            this.number = number;
            this.dealer = dealer;
            this.model = model;
        }
    }
}
