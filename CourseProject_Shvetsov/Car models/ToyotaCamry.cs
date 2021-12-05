namespace Taxopark
{
    // Класс, описывающий характеристики автомобиля "Toyota Camry"
    public class ToyotaCamry : PassengerCar
    {
        // Конструктор, инициализирующий характеристики (гос. номер устанавливается рандомно)
        public ToyotaCamry() : base(
            carClass: CarClass.D,
            maxSpeed: 220f,
            minFuelConsumption: 3f,
            maxFuelConsumption: 14f,
            number: GetRandomNumber(),
            dealer: "Toyota",
            model: "Camry")
        { }
        
        // Конструктор, инициализирующий характеристики (гос. номер передается в качестве параметра)
        public ToyotaCamry(string number) : base(
            carClass: CarClass.D,
            maxSpeed: 220f,
            minFuelConsumption: 3f,
            maxFuelConsumption: 14f,
            number: number,
            dealer: "Toyota",
            model: "Camry")
        { }
    }
}
