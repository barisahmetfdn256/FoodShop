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
    public interface IShopDal : IEntityRepository<Shop>
    {
        List<ShopDetailDto> GetShopDetail(Expression<Func<Shop, bool>> filter = null);
    }
}
