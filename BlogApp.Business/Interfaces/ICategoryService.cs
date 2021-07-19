using System.Collections.Generic;
using System.Threading.Tasks;
using BlogApp.Entities.Concrete;

namespace BlogApp.Business.Interfaces
{
    public interface ICategoryService:IGenericService<Category>
    {
        Task<List<Category>> GetAllSortedByIdAsync();
        Task<List<Category>> GetAllWithCategoryBlogsAsync();
    }
}
