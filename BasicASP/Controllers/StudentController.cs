using Microsoft.AspNetCore.Mvc;

namespace BasicASP.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //return Content("คะแนนสอบวิชาคอมพิวเตอร์");
        }

        public IActionResult Create()
        {
            return View();
            //return Content("รายละเอียดคะแนนสอบวิชาคอมพิวเตอร์");
        }
    }
}