using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

//AddCarTest(carManager);
var result = carManager.GetAll();
foreach(var car in result)
{
    Console.WriteLine(car.Id + " " + car.ModelYear);
}  

static void AddCarTest(CarManager carManager)
{
    carManager.AddCar(new Car { Id = 1, BrandId = 1, ColorId = 2, Description = "Fiat Doblo", DailyPrice = 300, ModelYear = 2011 });
}