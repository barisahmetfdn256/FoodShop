using Business.Abstract;
using Entities.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : Controller
    {
        private IShopService _shopService;

        public ShopController(IShopService shopService)
        {
            _shopService = shopService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _shopService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add(Shop shop)
        {
            var result = _shopService.Add(shop);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(int shopid)
        {
            var result = _shopService.Delete(shopid);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);

        }
    }
}
