using DataAccess.Cocrete.EntityFramework;
using DataAccsees.Abstract;
using Entities.Concrate;
using Entities.Concrate.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsees.Concrate.EntityFramework
{
    public class EfFoodDal : EfEntityRepositoryBase<Food, JestFoodContext> , IFoodDal  
    {
         public List<FoodDetailDto> GetFoodDetail(Expression<Func<Food, bool>> filter = null)
        {
            using (JestFoodContext context = new JestFoodContext())
            {
                var result = from fo in filter is null ? context.Foods : context.Foods.Where(filter)
                            
                             join c in context.Categories
                             on fo.CategoryId equals c.Id   
                             select new FoodDetailDto
                             {
                                 Id = fo.Id,
                                 CategoryName = c.Name,
                                 Name = fo.Name,
                                 Shop = fo.Shop,
                                 Price = fo.UnitPrice
                             };
                return result.ToList();
                  
            };
        }
    }
}
