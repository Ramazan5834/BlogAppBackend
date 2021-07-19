using System.Collections.Generic;
using BlogApp.Entities.Interfaces;

namespace BlogApp.Entities.Concrete
{   
    public class Category:ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<CategoryBlog> CategoryBlogs { get; set; }
    }
}
