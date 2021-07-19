using BlogApp.Business.Concrete;
using BlogApp.Business.Interfaces;
using BlogApp.Business.Tools.FacadeTool;
using BlogApp.Business.Tools.JWTTool;
using BlogApp.Business.Tools.LogTool;
using BlogApp.Business.ValidationRules.FluentValidation;
using BlogApp.DataAccess.Concrete.EntityFrameworkCore.Context;
using BlogApp.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using BlogApp.DataAccess.Interfaces;
using BlogApp.DTO.DTOs.AppUserDtos;
using BlogApp.DTO.DTOs.CategoryBlogDtos;
using BlogApp.DTO.DTOs.CategoryDtos;
using BlogApp.DTO.DTOs.CommentDtos;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace BlogApp.Business.Containers.MicrosoftIoC
{
    public static class CustomIoCExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddDbContext<BlogAppContext>();

            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<IBlogService, BlogManager>();
            services.AddScoped<IBlogDal, EfBlogRepository>();

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryRepository>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserRepository>();

            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentRepository>();

            services.AddScoped<IJwtService, JwtManager>();
            services.AddScoped<ICustomLogger, NLogAdapter>();
            services.AddScoped<IFacade, Facade>();


            services.AddTransient<IValidator<AppUserLoginDto>, AppUserLoginValidator>();
            services.AddTransient<IValidator<CategoryAddDto>, CategoryAddValidator>();
            services.AddTransient<IValidator<CategoryBlogDto>, CategoryBlogValidator>();
            services.AddTransient<IValidator<CategoryUpdateDto>, CategoryUpdateValidator>();
            services.AddTransient<IValidator<CommentAddDto>, CommentAddValidator>();
        }
    }
}
