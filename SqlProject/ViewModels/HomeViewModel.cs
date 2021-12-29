using SqlProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlProject.ViewModels
{
    public class HomeViewModel
    {
        public List<Counters> Counters;
        public List<Courses> Courses;
        public List<Features> Features;
        public List<Trainers> Trainers;
        public List<WhyUs> WhyUs;
    }
}
