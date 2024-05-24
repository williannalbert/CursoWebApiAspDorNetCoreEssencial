using VirtualShop.Web.Models;

namespace VirtualShop.Web.Services.Contracts;

public interface ICategoryService
{
    Task<IEnumerable<CategoryViewModel>> GetAllCategories(string token);
}
