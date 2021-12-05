namespace Taxopark
{
    // Класс, описывающий характеристики автомобиля "Mercedes-Benz E-Class"
    public class MercedesBenzEClass : PassengerCar
    {
        // Конструктор, инициализирующий характеристики (гос. номер устанавливается рандомно)
        public MercedesBenzEClass() : base(
            carClass: CarClass.E,
            maxSpeed: 260.5f,
            minFuelConsumption: 2.5f,
            maxFuelConsumption: 19f,
            number: GetRandomNumber(),
            dealer: "Mercedes-Benz",
            model: "E-Class")
        { }
        
        // Конструктор, инициализирующий характеристики (гос. номер передается в качестве параметра)
        public MercedesBenzEClass(string number) : base(
            carClass: CarClass.E,
            maxSpeed: 260.5f,
            minFuelConsumption: 2.5f,
            maxFuelConsumption: 19f,
            number: number,
            dealer: "Mercedes-Benz",
            model: "E-Class")
        { }
    }
}
