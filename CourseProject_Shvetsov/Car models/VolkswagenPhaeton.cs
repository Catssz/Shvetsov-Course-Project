namespace Taxopark
{
    // Класс, описывающий характеристики автомобиля "Volkswagen Phaeton"
    public class VolkswagenPhaeton : PassengerCar
    {
        // Конструктор, инициализирующий характеристики (гос. номер устанавливается рандомно)
        public VolkswagenPhaeton() : base(
            carClass: CarClass.F,
            maxSpeed: 245.7f,
            minFuelConsumption: 8.5f,
            maxFuelConsumption: 15.6f,
            number: GetRandomNumber(),
            dealer: "Volkswagen",
            model: "Phaeton")
        { }
        
        // Конструктор, инициализирующий характеристики (гос. номер передается в качестве параметра)
        public VolkswagenPhaeton(string number) : base(
            carClass: CarClass.F,
            maxSpeed: 245.7f,
            minFuelConsumption: 8.5f,
            maxFuelConsumption: 15.6f,
            number: number,
            dealer: "Volkswagen",
            model: "Phaeton")
        { }
    }
}
