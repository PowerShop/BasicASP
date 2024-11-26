using Microsoft.AspNetCore.Mvc;

namespace BasicASP.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            //return View();
            return Content("คะแนนสอบวิชาคอมพิวเตอร์");
        }

        public IActionResult Detail()
        {
            //return Detail();
            return Content("รายละเอียดคะแนนสอบวิขาคอมพิวเตอร์");
        }

        public IActionResult ShowScore(int id)
        {
            //return ShowScore();
            return Content($"คะแนนสอบวิขาคอมพิวเตอร์ รหัส {id}");
        }

        public IActionResult Error()
        {
            // return Error();
            return Content("Error");
        }
    }
}
