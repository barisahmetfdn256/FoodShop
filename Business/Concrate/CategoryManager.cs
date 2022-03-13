using Business.Abstract;
using Business.Conctants;
using Core.Utilities.Results;
using DataAccsees.Abstract;
using Entities.Concrate.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult(Messages.CatAdded);
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.CatDeleted);
        }

        public IResult Delete2(int catid)
        {
            var idcat = _categoryDal.Get(f => f.Id == catid);
            _categoryDal.Delete(idcat);
            return new SuccessResult(Messages.FoodDeleted);
        }

        public IDataResult<List<CategoryDetailDto>> GetAll()
        {
            return new SuccessDataResult<List<CategoryDetailDto>>(_categoryDal.GetCategoryDetail() , Messages.CatListed);

        }

        public IResult Update(Category category)
        {

            _categoryDal.Update(category);
            return new SuccessResult(Messages.CatDeleted);
        }
    }
}
