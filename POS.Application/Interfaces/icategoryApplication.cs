using POS.Application.Commons;
using POS.Application.Dtos.Request;
using POS.Application.Dtos.Response;
using POS.Infrastructure.Commons.Bases.Request;
using POS.Infrastructure.Commons.Bases.Response;

namespace POS.Application.Interfaces
{
    public interface icategoryApplication
    {
        Task<BaseResponse<BaseEntityResponse<CategoryResponseDto>>> ListCategories(BaseFilterRequest filters);
        Task<BaseResponse<IEnumerable<CategorySelectResponseDto>>> ListSelecCategories();
        Task<BaseResponse<CategoryResponseDto>> CatgeroyById(int categoryId);
        Task<BaseResponse<bool>> RegisterCategory(CategoryRequestDto requestDto);
        Task<BaseResponse<bool>> EditCategory(int categoryId, CategoryRequestDto requestDto);
        Task<BaseResponse<bool>> RemoveCategory(int category);
        
    }
}
    