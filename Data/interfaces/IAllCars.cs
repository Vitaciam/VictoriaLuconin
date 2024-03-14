using VictoriaLuconin.Data.models;

namespace VictoriaLuconin.Data.interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> getFavCars { get;}

        Car getObjectCar(int carId);

    }
}
