namespace Taxopark
{
    // Класс, описывающий характеристики автомобиля "Volkswagen Golf"
    public class VolkswagenGolf : PassengerCar
    {
        // Конструктор, инициализирующий характеристики (гос. номер устанавливается рандомно)
        public VolkswagenGolf() : base(
            carClass: CarClass.C,
            maxSpeed: 250f,
            minFuelConsumption: 1.5f,
            maxFuelConsumption: 14.5f,
            number: GetRandomNumber(),
            dealer: "Volkswagen",
            model: "Golf")
        { }
        
        // Конструктор, инициализирующий характеристики (гос. номер передается в качестве параметра)
        public VolkswagenGolf(string number) : base(
            carClass: CarClass.C,
            maxSpeed: 250f,
            minFuelConsumption: 1.5f,
            maxFuelConsumption: 14.5f,
            number: number,
            dealer: "Volkswagen",
            model: "Golf")
        { }
    }
}
