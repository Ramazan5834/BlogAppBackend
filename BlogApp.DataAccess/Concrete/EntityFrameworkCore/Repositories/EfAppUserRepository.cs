using BlogApp.DataAccess.Concrete.EntityFrameworkCore.Context;
using BlogApp.DataAccess.Interfaces;
using BlogApp.Entities.Concrete;

namespace BlogApp.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfAppUserRepository:EfGenericRepository<AppUser>,IAppUserDal
    {
        public EfAppUserRepository(BlogAppContext context) : base(context)
        {
        }
    }
}
