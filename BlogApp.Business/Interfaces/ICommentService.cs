using System.Collections.Generic;
using System.Threading.Tasks;
using BlogApp.Entities.Concrete;

namespace BlogApp.Business.Interfaces
{
    public interface ICommentService:IGenericService<Comment>
    {
        Task<List<Comment>> GetAllWithSubCommentsAsync(int blogId, int? parentId);
    }
}
