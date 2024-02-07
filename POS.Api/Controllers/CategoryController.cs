using Microsoft.AspNetCore.Mvc;
using POS.Application.Dtos.Request;
using POS.Application.Interfaces;
using POS.Infrastructure.Commons.Bases.Request;

namespace POS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly icategoryApplication _categoryApplication;

        public CategoryController(icategoryApplication categoryApplication)
        {
            _categoryApplication = categoryApplication;
        }
        [HttpPost]
        public async Task<IActionResult> ListCategories([FromBody] BaseFilterRequest filter)
        {
            var response = await _categoryApplication.ListCategories(filter);//accede  a category  despues 
            // a lisCategory  y despues la informaciión encontrada se almacena en filter   y se guarda en   response 
            return Ok(response);
        }

        [HttpGet("Select")]
        // 
        public async Task<IActionResult> ListSelectCategories()
        {
            var response = await _categoryApplication.ListSelecCategories();
            return Ok(response);
        }
        [HttpGet("{categoryId:int}")]
        public async Task<IActionResult> CategoruByid(int categoryId)
        {
            var response = await _categoryApplication.CatgeroyById(categoryId);
            return Ok(response);
        }
        [HttpGet("Register")]
        public async Task<IActionResult> RegisterCategory([FromBody] CategoryRequestDto resquestDto)
        {
            var response = await _categoryApplication.RegisterCategory(resquestDto);
            return Ok(response);
        }
        [HttpPut("Edit/{categoryId:int}")]
        public async Task<IActionResult> EditCatecogry(int categoryId, [FromBody] CategoryRequestDto requestDto)
        {
            var response = await _categoryApplication.EditCategory(categoryId, requestDto);
            return Ok(response);
        }
        [HttpPut("Remove/{categoryId:int}")]
        public async Task<IActionResult> RemoveCategory(int categoryId)
        {
            var response = await _categoryApplication.RemoveCategory(categoryId);
            return Ok(response);
        }
    }
}
