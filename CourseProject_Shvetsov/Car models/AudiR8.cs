namespace Taxopark
{
    // Класс, описывающий характеристики автомобиля "Audi R8"
    public class AudiR8 : PassengerCar
    {
        // Конструктор, инициализирующий характеристики (гос. номер устанавливается рандомно)
        public AudiR8() : base(
            carClass: CarClass.S,
            maxSpeed: 323f,
            minFuelConsumption: 11.4f,
            maxFuelConsumption: 14.9f,
            number: GetRandomNumber(),
            dealer: "Audi",
            model: "R8")
        { }
        
        // Конструктор, инициализирующий характеристики (гос. номер передается в качестве параметра)
        public AudiR8(string number) : base(
            carClass: CarClass.S,
            maxSpeed: 323f,
            minFuelConsumption: 11.4f,
            maxFuelConsumption: 14.9f,
            number: number,
            dealer: "Audi",
            model: "R8")
        { }
    }
}
