using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                var query = from c in context.Cars
                            join b in context.Brands on c.BrandId equals b.Id
                            join cl in context.Colors on c.ColorId equals cl.Id
                            select new CarDetailDto
                            {
                                CarId = c.Id,
                                CarName = c.Description,
                                BrandName = b.BrandName,
                                ColorName = cl.ColorName,
                                DailyPrice = c.DailyPrice,
                                
                            };
                return query.ToList();
            }
        }
    }
}
