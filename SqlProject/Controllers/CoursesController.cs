using Microsoft.AspNetCore.Mvc;
using SqlProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlProject.Controllers
{
    public class CoursesController : Controller
    {
        private DataContext _datas;
        public CoursesController(DataContext datas)
        {
            _datas = datas;
        }
        public IActionResult Index()
        {
           
            return View(_datas.Courses.ToList());
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}
