using BlogApp.DTO.Interfaces;

namespace BlogApp.DTO.DTOs.CategoryDtos
{
    public class CategoryListDto:IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
