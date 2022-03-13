using Core.Utilities.Results;
using Entities.Concrate.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IResult Add(Category category);
        IResult Update(Category category);
        IResult Delete(Category category);
        IResult Delete2(int catid);
        IDataResult<List<CategoryDetailDto>> GetAll();
    }

}
