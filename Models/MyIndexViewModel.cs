using System.Collections.Generic;
using travelproject.Models.Classes;


namespace travelproject.Models
{
    public class MyIndexViewModel
    {
        public List<MyBlog> AllBlogs { get; set; }
        public List<MyBlog> LastThreeBlogs { get; set; }
         public List<MyBlog> LastSixBlogs { get; set; }
    }
}
