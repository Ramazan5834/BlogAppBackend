using System.Threading.Tasks;
using BlogApp.DTO.DTOs.AppUserDtos;
using BlogApp.Entities.Concrete;

namespace BlogApp.Business.Interfaces
{
    public interface IAppUserService:IGenericService<AppUser>
    {
        Task<AppUser> CheckUserAsync(AppUserLoginDto appUserLoginDto);
        Task<AppUser> FindByNameAsync(string userName);
    }
}
