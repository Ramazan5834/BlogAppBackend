using System.Collections.Generic;
using System.Threading.Tasks;
using BlogApp.Entities.Concrete;

namespace BlogApp.DataAccess.Interfaces
{
    public interface ICategoryDal:IGenericDal<Category>
    {
        Task<List<Category>> GetAllWithCategoryBlogsAsync();

    }
}
