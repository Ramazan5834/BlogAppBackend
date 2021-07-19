using System.Collections.Generic;
using System.Threading.Tasks;
using BlogApp.Entities.Concrete;

namespace BlogApp.DataAccess.Interfaces
{
    public interface ICommentDal:IGenericDal<Comment>
    {
        Task<List<Comment>> GetAllWithSubCommentsAsync(int blogId, int? parentId);
    }
}
