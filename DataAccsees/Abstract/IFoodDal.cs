using Core.DataAccess;
using Entities.Concrate;
using Entities.Concrate.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsees.Abstract
{
   public interface  IFoodDal:IEntityRepository<Food>
    {
        List<FoodDetailDto> GetFoodDetail(Expression<Func<Food, bool>> filter = null);
    }
}

