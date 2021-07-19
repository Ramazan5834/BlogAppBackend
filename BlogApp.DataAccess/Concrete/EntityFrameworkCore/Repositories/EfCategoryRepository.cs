using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.DataAccess.Concrete.EntityFrameworkCore.Context;
using BlogApp.DataAccess.Interfaces;
using BlogApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryDal
    {
        private readonly BlogAppContext _context;
        public EfCategoryRepository(BlogAppContext context) : base(context)
        {
            _context = context;
        }
        public async Task<List<Category>> GetAllWithCategoryBlogsAsync()
        {
            return await _context.Categories.OrderByDescending(I => I.Id).Include(I => I.CategoryBlogs).ToListAsync();
        }
    }
}
