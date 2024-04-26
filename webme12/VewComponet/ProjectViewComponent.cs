using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Project = webme12.Models.Project;

namespace webme12.VewComponet
{
    public class ProjectViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project> { 
            
                new Project(1,"پروژه درخواست تاکسی","پروژه تاکسی برای سفرهای درون شهری","snap","project-1.jpg"),

                new Project(2,"پروزه درخواست غذا","سفارش غذا درون شهری","zodfood","project-2.jpg"),

                new Project(3,"پروژه درخواست نوشابه","پروژه سفارش نوشیدنی های گازدار","drink","project-3.jpg"),

                new Project(4,"پروژه درخواست ماشین","پروژه درخواست ماشین کرایه ای","car","project-4.jpg"),

            };

            return View("_Projects",projects);
        }
    }
}
