namespace Taxopark
{
    // Класс, описывающий характеристики автомобиля "Kia Picanto"
    public class KiaPicanto: PassengerCar
    {
        // Конструктор, инициализирующий характеристики (гос. номер устанавливается рандомно)
        public KiaPicanto() : base(
            carClass: CarClass.A,
            maxSpeed: 160f,
            minFuelConsumption: 4.2f,
            maxFuelConsumption: 5.8f,
            number: GetRandomNumber(),
            dealer: "Kia",
            model: "Picanto") 
        { }

        // Конструктор, инициализирующий характеристики (гос. номер передается в качестве параметра)
        public KiaPicanto(string number) : base(
            carClass: CarClass.A,
            maxSpeed: 160f,
            minFuelConsumption: 4.2f,
            maxFuelConsumption: 5.8f,
            number: number,
            dealer: "Kia",
            model: "Picanto")
        { }
    }
}
