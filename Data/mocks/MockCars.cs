using VictoriaLuconin.Data.interfaces;
using VictoriaLuconin.Data.models;

namespace VictoriaLuconin.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly MockCars _cars = new MockCars();
        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>{
                new Car{ name = "Skoda", shortDesc = "Современный вид транспорта", longDesc= "", img="", price=100, isFavourite = true, available=20, categoryID=1 }
               
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
