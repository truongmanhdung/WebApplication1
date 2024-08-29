using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;
namespace HelloWorld.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // tham số trong hàm tương tự request param https://localhost:7165/Demo/test?name=Le%20Van%20Hai&age=29&score=9.9
        public IActionResult Test(String name, int age, double score)
        {
            //truyen du lieu cho view
            /**
             * cach 1: dung bộ nhớ chia sẻ như ViewBag, ViewData, AppData
             * cách 2: dùng model
            **/

            ViewBag.Name = name;
            ViewBag.Age = age;
            ViewBag.Score = score;
            User user = new User(1, "Lê Văn Hai", 29, "hailv@gmail.com");
            return View(user);
        }
        public IActionResult TestActionNameDifferentViewName()
        {
            return View("NameDifferent");
        }

        public IActionResult GetUser()
        {
            return View("PostUser");
        }

        [HttpPost]
        public IActionResult GetUser(User user)
        {
            return View("GetUser", user);
        }
    }
}
