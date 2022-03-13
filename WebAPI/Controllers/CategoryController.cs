
using Business.Abstract;
using Entities.Concrate.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _categoryService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);

        }
        [HttpPost("add")]
        public IActionResult Add(Category category)
        {
            var result = _categoryService.Add(category);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);

        }

        [HttpPost("delete")]
        public IActionResult Delete(int id)
        {
            var result = _categoryService.Delete2(id);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);

        }
        [HttpPost("update")]
        public IActionResult Update(Category category)
        {
            var result = _categoryService.Update(category);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);

        }
    }
}
