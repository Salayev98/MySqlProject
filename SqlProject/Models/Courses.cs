using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlProject.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string TeacherPhoto { get; set; }
        public string TeacherName { get; set; }
        public string Visitors { get; set; }
        public string Likes { get; set; }
    }
}
