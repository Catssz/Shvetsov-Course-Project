namespace Taxopark
{
    // Класс, описывающий характеристики автомобиля "Renault Kangoo"
    public class RenaultKangoo : PassengerCar
    {
        // Конструктор, инициализирующий характеристики (гос. номер устанавливается рандомно)
        public RenaultKangoo() : base(
            carClass: CarClass.M,
            maxSpeed: 130f,
            minFuelConsumption: 4.3f,
            maxFuelConsumption: 10.2f,
            number: GetRandomNumber(),
            dealer: "Renault",
            model: "Kangoo")
        { }
        
        // Конструктор, инициализирующий характеристики (гос. номер передается в качестве параметра)
        public RenaultKangoo(string number) : base(
            carClass: CarClass.M,
            maxSpeed: 130f,
            minFuelConsumption: 4.3f,
            maxFuelConsumption: 10.2f,
            number: number,
            dealer: "Renault",
            model: "Kangoo")
        { }
    }
}
