namespace Taxopark
{
    // Класс, описывающий характеристики автомобиля "Chevrolet Aveo"
    public class ChevroletAveo : PassengerCar
    {
        // Конструктор, инициализирующий характеристики (гос. номер устанавливается рандомно)
        public ChevroletAveo() : base(
            carClass: CarClass.B,
            maxSpeed: 189f,
            minFuelConsumption: 3.8f,
            maxFuelConsumption: 8.4f,
            number: GetRandomNumber(),
            dealer: "Chevrolet",
            model: "Aveo")
        { }

        // Конструктор, инициализирующий характеристики (гос. номер передается в качестве параметра)
        public ChevroletAveo(string number) : base(
            carClass: CarClass.B,
            maxSpeed: 189f,
            minFuelConsumption: 3.8f,
            maxFuelConsumption: 8.4f,
            number: number,
            dealer: "Chevrolet",
            model: "Aveo")
        { }
    }
}
