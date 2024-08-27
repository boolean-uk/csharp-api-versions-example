using System.Runtime.CompilerServices;
using workshop.wwwcars7.Models;

namespace workshop.wwwcars7.Data
{
    public static class CarsCollection
    {
        private static List<Car> _cars = new List<Car>();

        public static void SetupCarCollection()
        {
            _cars.Add(new Car() { Id = 1, Make = "Mini", Model = "Clubman" });
            _cars.Add(new Car() { Id = 2, Make = "Volkswagen", Model = "Beetle" });
            _cars.Add(new Car() { Id = 3, Make = "Renault", Model = "Twizy" });
        }
        public static List<Car> GetCars()
        {
            return _cars;
        }

    }
}
