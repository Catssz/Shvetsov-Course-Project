using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Taxopark
{
    public partial class MainForm : Form
    {
        // Список всех легковых автомобилей таксопарка
        List<PassengerCar> cars = new List<PassengerCar>();

        // Список пар диллер-модели
        Dictionary<string, List<string>> models = new Dictionary<string, List<string>>();

        // Делегат для события ошибки (по сути описывает методы-обработчики)
        private delegate void ErrorHandler(string message);

        // Событие ошибки
        private event ErrorHandler Error;

        // Конструктор формы
        public MainForm()
        {
            // Инициализация компонентов (системный метод, создан автоматически)
            InitializeComponent();
        }

        // Метод, вызывающийся при загрузке формы
        private void Form1_Load(object sender, EventArgs e)
        {
            // Инициализация таблиц
            InitializeTable(carsTable);
            InitializeTable(filteredCarsTable);

            // Инициализация массива пар диллер-модели
            InitializeModels();

            // Добавление диллеров в выпадающий список
            dealerSelect.Items.AddRange(models.Keys.ToArray());

            // Установка дефотного состояния секции добавления автомобиля
            SetAddSectionDefaultState();

            // Установка дефолтного состояния таблицы всех автомобилей
            SetDefaultCars();

            // Добавление обработчика ошибок событию
            Error += ShowError;
        }

        // Метод инициализации таблицы (добавления ее столбцов и редактирования характеристик)
        private void InitializeTable(DataGridView table)
        {
            // Создание столбцов таблицы (первый параметр - ключ в массиве столбцов, второй - заголовок)
            table.Columns.Add("id", "№");
            table.Columns.Add("number", "Гос. номер");
            table.Columns.Add("dealer", "Дилер");
            table.Columns.Add("model", "Модель");
            table.Columns.Add("maxSpeed", "Максимальная скорость");
            table.Columns.Add("minFuelConsumption", "Минимальный РТ");
            table.Columns.Add("maxFuelConsumption", "Максимальный РТ");
            table.Columns.Add("class", "Класс");

            // Редактирование свойств таблицы

            // Данные в таблице - только для чтения
            table.ReadOnly = true;
            // Ширина столбца по содержимому
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // Убрать строку добавления новой строки
            table.AllowUserToAddRows = false;
            // Убрать первый столбец, отображающий выделение строки
            table.RowHeadersVisible = false;
        }

        // Метод, инициализирующий словарь пар диллер-модели
        private void InitializeModels()
        {
            models.Add("Kia", new List<string> { "Picanto" });
            models.Add("Chevrolet", new List<string> { "Aveo" });
            models.Add("Audi", new List<string> { "R8" });
            models.Add("Mercedes-Benz", new List<string> { "E-Class" });
            models.Add("Renault", new List<string> { "Kangoo" });
            models.Add("Toyota", new List<string> { "Camry", "RAV4" });
            models.Add("Volkswagen", new List<string> { "Golf", "Phaeton" });
        }

        // Метод, добавляющий в таблицу автомобили по умолчанию, т.е. при запуске программы несколько автомобилей уже будут в списке
        private void SetDefaultCars()
        {
            // Очистка таблицы
            carsTable.Rows.Clear();

            // Установка значения списка автомобилей по умолчанию
            cars.Add(new KiaPicanto());
            // Останавливаем поток на 0.01 секунды для того, чтобы при генерации случайного гос. номера не сгенерировало для всех автомобилей
            // одинаковые, т.к. время между созданием этих экземпляров очень мало, а 0.01 секунды на производительности программы никак не отразится
            Thread.Sleep(10);
            cars.Add(new ChevroletAveo());
            Thread.Sleep(10);
            cars.Add(new VolkswagenGolf());
            Thread.Sleep(10);
            cars.Add(new ToyotaCamry());
            Thread.Sleep(10);
            cars.Add(new MercedesBenzEClass());
            Thread.Sleep(10);
            cars.Add(new VolkswagenPhaeton());
            Thread.Sleep(10);
            cars.Add(new ToyotaRAV4());
            Thread.Sleep(10);
            cars.Add(new RenaultKangoo());
            Thread.Sleep(10);
            cars.Add(new AudiR8());

            // Непосредственно добавление строки в таблицу
            foreach(PassengerCar car in cars)
            {
                ShowRow(carsTable, car);
            }
        }

        // Метод, добавляющий строку в таблицу с характеристиками переданного автомобиля в качестве значений ячеек
        private void ShowRow(DataGridView table, PassengerCar car)
        {
            // Получение индекса созданной на месте строки
            int index = table.Rows.Add();

            // Вынесение строки в отдельную переменную для удобства
            DataGridViewRow row = table.Rows[index];

            // Инициализация каждой из ячеек строки
            row.Cells["id"].Value = index + 1;
            row.Cells["number"].Value = car.number;
            row.Cells["dealer"].Value = car.dealer;
            row.Cells["model"].Value = car.model;
            row.Cells["maxSpeed"].Value = car.maxSpeed;
            row.Cells["minFuelConsumption"].Value = car.minFuelConsumption;
            row.Cells["maxFuelConsumption"].Value = car.maxFuelConsumption;
            row.Cells["class"].Value = car.carClass;
        }

        // Метод, устанавливающий дефолтное состояние вкладки "Добавить" 
        private void SetAddSectionDefaultState()
        {
            // Установление выпадающих списков в состояние пустого выбора
            dealerSelect.SelectedIndex = -1;
            modelSelect.SelectedIndex = -1;

            // Отключение выпадающего списка моделей и кнопки добавления
            modelSelect.Enabled = false;
            addButton.Enabled = false;

            // Очистка поля ввода гос. номера и сообщения об ошибке
            numberInput.Text = "";
            errorMessage.Text = "";
        }

        // Метод, выводящий ошибку
        private void ShowError(string message)
        {
            errorMessage.Text = message;
        }

        // Метод, вызывающийся при изменении поля ввода максимальной скорости
        private void speedInput_TextChanged(object sender, EventArgs e)
        {
            // Конструкция "try-catch" необходима для обработки ошибок приведения строки (значения поля ввода) в тип float 
            try
            {
                // Очистка таблицы отфильтрованных автомобилей
                filteredCarsTable.Rows.Clear();

                // Получение значения из поля ввода
                float maxSpeed = float.Parse(speedInput.Text);

                // Список отфильтрованных автомобилей
                List<PassengerCar> filteredCars = new List<PassengerCar>();

                // Поиск подходящий под фильтр автомобилей и добавление найденных в список
                foreach(PassengerCar car in cars)
                {
                    if(car.maxSpeed <= maxSpeed)
                    {
                        filteredCars.Add(car);
                    }
                }

                // Вывод каждого отфильтрованного автомобиля в соответствующую таблицу
                foreach(PassengerCar car in filteredCars)
                {
                    ShowRow(filteredCarsTable, car);
                }
            } catch (Exception exception)
            {
                // Если вызвалась ошибка, вывод ее в консоль
                Console.WriteLine(exception);
            }
        }

        // Метод, вызывающийся при изменении вводимого значения гос. номера
        private void numberInput_TextChanged(object sender, EventArgs e)
        {
            // Очистка сообщения об ошибке
            errorMessage.Text = "";
        }

        // Метод, вызывающийся при выборе какого-либо из диллеров
        private void dealerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Разблокировать выпадающий список моделей
            modelSelect.Enabled = true;

            // Очистка списка моделей
            modelSelect.Items.Clear();

            // Установка выпадающего списка в состояние отсутствия выбора
            modelSelect.SelectedIndex = -1;
            modelSelect.Text = "";

            // Установка списка соответствующих диллеру моделей
            modelSelect.Items.AddRange(models[dealerSelect.SelectedItem.ToString()].ToArray());
        }

        // Метод, вызывающийся при выборе какой-либо из моделей
        private void modelSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Включение кнопки добавления
            addButton.Enabled = true;
        }

        // Метод, вызывающийся при нажатии кнопки добавления автомобиля
        private void addButton_Click(object sender, EventArgs e)
        {
            // Добавляемый автомобиль
            PassengerCar car = null;

            // Вынесение введенного гос. номера для удобства
            string number = numberInput.Text;

            // Установка значения автомобиля взависимости от введенного диллера, модеои и гос. номера
            switch (dealerSelect.Text)
            {
                // Если выбранный диллер - Kia
                case "Kia":
                    // Если выбранная модель - Picanto
                    if(modelSelect.Text == "Picanto")
                    {
                        // Если номер не указан
                        if (number == "")
                        {
                            // Инициализировать автомобиль с рандомным гос.номером
                            car = new KiaPicanto();
                        } else
                        {
                            // Инициализировать автомобиль с заданным гос.номером (корректным или нет, без разницы, т.к. если не корректен,
                            // то он будет равен null и обработан ниже
                            car = new KiaPicanto(number);
                        }
                    }
                    break;

                // Со всеми другими аналогично
                case "Chevrolet":
                    if (modelSelect.Text == "Aveo")
                    {
                        if (number == "")
                        {
                            car = new ChevroletAveo();
                        }
                        else
                        {
                            car = new ChevroletAveo(number);
                        }
                    }
                    break;

                case "Audi":
                    if (modelSelect.Text == "R8")
                    {
                        if (number == "")
                        {
                            car = new AudiR8();
                        }
                        else
                        {
                            car = new AudiR8(number);
                        }
                    }
                    break;

                case "Mercedes-Benz":
                    if (modelSelect.Text == "E-Class")
                    {
                        if (number == "")
                        {
                            car = new MercedesBenzEClass();
                        }
                        else
                        {
                            car = new MercedesBenzEClass(number);
                        }
                    }
                    break;

                case "Renault":
                    if (modelSelect.Text == "Kangoo")
                    {
                        if (number == "")
                        {
                            car = new RenaultKangoo();
                        }
                        else
                        {
                            car = new RenaultKangoo(number);
                        }
                    }
                    break;
                case "Toyota":
                    if (modelSelect.Text == "Camry")
                    {
                        if (number == "")
                        {
                            car = new ToyotaCamry();
                        }
                        else
                        {
                            car = new ToyotaCamry(number);
                        }
                    } else if (modelSelect.Text == "RAV4")
                    {
                        if (number == "")
                        {
                            car = new ToyotaRAV4();
                        }
                        else
                        {
                            car = new ToyotaRAV4(number);
                        }
                    }
                    break;

                case "Volkswagen":
                    if (modelSelect.Text == "Golf")
                    {
                        if (number == "")
                        {
                            car = new VolkswagenGolf();
                        }
                        else
                        {
                            car = new VolkswagenGolf(number);
                        }
                    }
                    else if (modelSelect.Text == "Phaeton")
                    {
                        if (number == "")
                        {
                            car = new VolkswagenPhaeton();
                        }
                        else
                        {
                            car = new VolkswagenPhaeton(number);
                        }
                    }
                    break;

                default:
                    break;
            }

            // Если автомобиль был инициализирован, но гос. номер указан некорректно
            if(car != null && car.number == null)
            {
                // Вывести сообщение об ошибке (вызывается обработчик - метод ShowError)
                Error?.Invoke("Введенный гос. номер имеет неверный формат");
            } else
            {
                // Добавление автомобиля в список и вывод в таблицу
                cars.Add(car);
                ShowRow(carsTable, car);
            }
        }
    }
}
