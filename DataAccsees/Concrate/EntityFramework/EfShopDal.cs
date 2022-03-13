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
    public class EfShopDal : EfEntityRepositoryBase<Shop , JestFoodContext>,IShopDal
    {
        public List<ShopDetailDto> GetShopDetail(Expression<Func<Shop, bool>> filter = null)
        {
            using (JestFoodContext context = new JestFoodContext())
            {
                var result = from sho in filter is null ? context.Shops : context.Shops.Where(filter)
                             join ca in context.Categories
                             on sho.CategoryId equals ca.Id
                             select new ShopDetailDto
                             {
                                 CategoryName = ca.Name,
                                 Id = sho.Id,
                                 MaxDistance = sho.MaxDistance,
                                 Name = sho.Name,
                                 PriceRange = sho.PriceRange,
                                 Location = sho.Location
                             };
                return result.ToList();

            };

        }
    }
}
