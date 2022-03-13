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
    public class ShopManager : IShopService
    {
        IShopDal _shopDal;

        public ShopManager(IShopDal shopDal)
        {
            _shopDal = shopDal;
        }

        public IResult Add(Shop shop)
        {
          _shopDal.Add(shop);
            return new SuccessResult(Messages.ShopAdded); 
        }

        public IResult Delete(int shopId)
        {
            var idshop = _shopDal.Get(s=>s.Id ==shopId);
            _shopDal.Delete(idshop);
            return new SuccessResult(Messages.ShopDeleted);
        }

        public IDataResult<List<ShopDetailDto>> GetAll()
        {
            return new SuccessDataResult<List<ShopDetailDto>>(_shopDal.GetShopDetail(),Messages.ShoListed);
        }

        public IDataResult<List<Shop>> GetByCategoryId(int id)
        {
            return new SuccessDataResult<List<Shop>>(_shopDal.GetAll(s=>s.CategoryId ==id));
        }

        public IResult GetById(int id)
        {
            return new SuccessDataResult<Shop>(_shopDal.Get(s=>s.Id ==id));
        }

        public IResult Update(Shop shop)
        {
           _shopDal.Update(shop);
            return new SuccessResult(Messages.ShopUpdated);
        }
    }
}
