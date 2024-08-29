using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Models;

namespace MyWebApp.Controllers
{
    public class StudentController : Controller
    {
        private List<Student> listStudents = new List<Student>();
        public StudentController()
        {
            listStudents = new List<Student>()
            {
               new Student() { Id = 101, Name = "Manh Dung", Branch = Branch.IT,
                   Gender = Gender.Male, IsRegular=true,
                   Address = "C23213", Email = "nam@g.com" },
               new Student() { Id = 102, Name = "Minh Tú", Branch = Branch.BE,
                   Gender = Gender.Female, IsRegular=true,
                   Address = "B21393219", Email = "tu@g.com" },
               new Student() { Id = 103, Name = "Hoàng Phong", Branch = Branch.CE,
                   Gender = Gender.Male, IsRegular=false,
                   Address = "B23312", Email = "phong@g.com" },
               new Student() { Id = 104, Name = "Xuân Mai", Branch = Branch.EE,
                   Gender = Gender.Female, IsRegular = false,
                   Address = "H91238321", Email = "mai@g.com" }
            };
        }
        public IActionResult Index()
        {
            return View(listStudents);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            ViewBag.AllBranches = new List<SelectListItem>()
    {
        new SelectListItem { Text = "IT", Value = "1" },
        new SelectListItem { Text = "BE", Value = "2" },
        new SelectListItem { Text = "CE", Value = "3" },
        new SelectListItem { Text = "EE", Value = "4" }
    };
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student s)
        {
            s.Id = listStudents.Last<Student>().Id + 1;
            listStudents.Add(s);
            return View("Index", listStudents);
        }



    }
}
