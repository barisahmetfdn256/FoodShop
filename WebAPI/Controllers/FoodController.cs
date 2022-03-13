using Business.Abstract;
using Entities.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private IFoodService _foodService;

        public FoodController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _foodService.GetAll();
            if (result.Success==true)
            {
                return Ok(result) ;
            }
            return BadRequest(result.Message);
            
        }
        [HttpPost("add")]
        public IActionResult Add(Food food)
        {
            var result = _foodService.Add(food);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);

        }

        [HttpPost("delete")]
        public IActionResult Delete(int id)
        {
            var result = _foodService.Delete2(id);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);

        }
        [HttpPost("update")]
        public IActionResult Update(Food food)
        {
            var result = _foodService.Update(food);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);

        }
    }
}
