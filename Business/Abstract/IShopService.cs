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
    public interface IShopService
    {
        IDataResult<List<ShopDetailDto>> GetAll();

        IDataResult<List<Shop>> GetByCategoryId(int id);

        IResult GetById(int id);

        IResult Add(Shop shop);

        IResult Delete(int shopId);   

        IResult Update(Shop shop);

    }
}
