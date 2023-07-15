using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

var result = carManager.CarDetails();

if (result.Success)
{
    foreach (var car in result.Data)
    {
        Console.WriteLine(car.BrandName + " - " + car.CarName + " : " + car.DailyPrice + "TL");
    }
}

else
{
    Console.WriteLine(result.Message);
}



