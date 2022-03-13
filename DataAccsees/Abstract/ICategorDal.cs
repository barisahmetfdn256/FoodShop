using Core.DataAccess;
using Entities.Concrate.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsees.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        List<CategoryDetailDto> GetCategoryDetail(Expression<Func<Category, bool>> filter = null);
    }
}
