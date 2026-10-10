using System;

namespace VehicleTask
{
    public class VehicleRegistration
    {
        public string NumberSign;
        public int RegNumb;
        public string RegName;

        public string GetFullInfo()
        {
            return $"{NumberSign} {RegNumb} | {RegName}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            VehicleRegistration car = new VehicleRegistration();

            car.NumberSign = "А775AA";
            car.RegNumb = 77;
            car.RegName = "Москва";

            Console.WriteLine("Информация об автомобиле:");
            Console.WriteLine(car.GetFullInfo());

            car.NumberSign = "E777KX";
            car.RegNumb = 69;
            car.RegName = "Тверь";

            Console.WriteLine("Информация об автомобиле:");
            Console.WriteLine(car.GetFullInfo()); 

            car.NumberSign = "О001ОО";
            car.RegNumb = 178;
            car.RegName = "Санкт-Петербург";

            Console.WriteLine("Информация об автомобиле:");
            Console.WriteLine(car.GetFullInfo());
        }
    }
}