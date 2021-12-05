namespace Taxopark
{
    // Класс, описывающий характеристики автомобиля "Toyota RAV4"
    public class ToyotaRAV4 : PassengerCar
    {
        // Конструктор, инициализирующий характеристики (гос. номер устанавливается рандомно)
        public ToyotaRAV4() : base(
            carClass: CarClass.J,
            maxSpeed: 195f,
            minFuelConsumption: 4.5f,
            maxFuelConsumption: 11.2f,
            number: GetRandomNumber(),
            dealer: "Toyota",
            model: "RAV4")
        { }
        
        // Конструктор, инициализирующий характеристики (гос. номер передается в качестве параметра)
        public ToyotaRAV4(string number) : base(
            carClass: CarClass.J,
            maxSpeed: 195f,
            minFuelConsumption: 4.5f,
            maxFuelConsumption: 11.2f,
            number: number,
            dealer: "Toyota",
            model: "RAV4")
        { }
    }
}
