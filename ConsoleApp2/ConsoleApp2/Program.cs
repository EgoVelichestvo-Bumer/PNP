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
        }
    }
}