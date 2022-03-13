using Business.Abstract;
using Business.Conctants;
using Core.Utilities.Results;
using DataAccsees.Abstract;
using Entities.Concrate;
using Entities.Concrate.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class FoodManager : IFoodService
    {
        IFoodDal _foodDal;

        public FoodManager(IFoodDal foodDal)
        {
            _foodDal = foodDal;
        }

        public IResult Add(Food food)
        {
            _foodDal.Add(food);
            return new SuccessResult(Messages.FoodAdded);
        }

        public IResult Delete(Food food)
        {
            _foodDal.Delete(food);
            return new SuccessResult(Messages.FoodDeleted);
        }

        public IResult Delete2(int foodid)
        {
            var idfood = _foodDal.Get(f=>f.Id==foodid);
            _foodDal.Delete(idfood);
            return new SuccessResult(Messages.FoodDeleted);

        }

        public IDataResult<List<Food>> GetAll()
        {
            return new SuccessDataResult<List<Food>>(_foodDal.GetAll(), Messages.FoodListed);
        }

        public IDataResult<List<Food>> GetByPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Food>>(_foodDal.GetAll(p => p.UnitPrice>= min && p.UnitPrice <= max));
        }

        public IDataResult<List<Food>> GetCategoryId(int id)
        {
            return new SuccessDataResult<List<Food>>(_foodDal.GetAll(f => f.CategoryId == id));
        }

        public IResult Update(Food food)
        {
            _foodDal.Update(food);
            return new SuccessResult(Messages.FoodUpdated);
        }

        IDataResult<List<FoodDetailDto>> IFoodService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
