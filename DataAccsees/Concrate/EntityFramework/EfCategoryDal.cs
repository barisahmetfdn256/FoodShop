using DataAccess.Cocrete.EntityFramework;
using DataAccsees.Abstract;
using Entities.Concrate.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsees.Concrate.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, JestFoodContext>, ICategoryDal
    {
        public List<CategoryDetailDto> GetCategoryDetail(Expression<Func<Category, bool>> filter = null)
        {
            using(JestFoodContext context = new JestFoodContext())
            {
                var result = from ca in filter is null ? context.Categories : context.Categories.Where(filter)
                             join c in context.Categories
                             on ca.Id equals c.Id
                             select new CategoryDetailDto
                             {
                                 Id = c.Id,
                                 CatgeoryName = c.Name
                             };
                return result.ToList();

            };
            
        }
    }
}
