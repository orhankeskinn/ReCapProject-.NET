using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());


carManager.AddCar(new Car { Id=1, BrandId=1,ColorId=2, Description="Fiat Doblo", DailyPrice=300, ModelYear=2011});