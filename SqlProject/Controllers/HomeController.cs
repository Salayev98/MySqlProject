using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SqlProject.Models;
using SqlProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SqlProject.Controllers
{
    public class HomeController : Controller
    {

        private DataContext _datas;
        public HomeController(DataContext datas)
        {
            _datas = datas;
        }
        public IActionResult Index()
        {
            List<Courses> courses = _datas.Courses.ToList();
            List<Counters> counters = _datas.Counters.ToList();
            List<Features> features = _datas.Features.ToList();
            List<Trainers> trainers = _datas.Trainers.ToList();
            
            List<WhyUs> whyUses = _datas.WhyUs.ToList();
            HomeViewModel homeVM = new HomeViewModel
            {
                Counters = counters,
                Courses = courses,
                Features=features,
                Trainers=trainers,
                WhyUs=whyUses
                
            };

            return View(homeVM);
        }
        public IActionResult About()
        {
            return View(_datas.Counters.ToList());
        }
        public IActionResult Events()
        {
            return View(_datas.Events.ToList());
        }
        public IActionResult Pricing()
        {
            return View(_datas.Payment.ToList());
        }

    }
}
