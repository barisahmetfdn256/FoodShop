using Core.Utilities.Results;
using Entities.Concrate;
using Entities.Concrate.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFoodService
    {       
        IDataResult<List<FoodDetailDto>> GetAll();
        IDataResult<List<Food>> GetCategoryId(int id);
        IDataResult<List<Food>> GetByPrice(decimal min , decimal max);
        IResult Add(Food food);
        IResult Update(Food food);
        IResult Delete(Food food);
        IResult Delete2(int foodid);
    }
}
