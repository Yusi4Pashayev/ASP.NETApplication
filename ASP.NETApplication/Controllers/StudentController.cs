using ASP.NETApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETApplication.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<Student>()
            {new Student()
                {
                    Id = 1,
                    Name = "Irfan",
                    LastName = "Last",
                    Age = 22
                },
                new Student()
                {
                    Id = 2,
                    Name = "Elvin",
                    LastName = "Last",
                    Age = 23
                },
                new Student()
                {
                    Id = 3,
                    Name = "Şahlar",
                    LastName = "Last",
                    Age = 21
                },
                new Student()
                {
                    Id = 4,
                    Name = "Əli",
                    LastName = "Last",
                    Age = 24
                },
            };

            return View(students);
        }
        public IActionResult Details(int? id=1)
        {

            var students = new List<Student>()
            {new Student()
                {
                    Id = 1,
                    Name = "Irfan",
                    LastName = "Last",
                    Age = 22
                },
                new Student()
                {
                    Id = 2,
                    Name = "Elvin",
                    LastName = "Last",
                    Age = 23
                },
                new Student()
                {
                    Id = 3,
                    Name = "Şahlar",
                    LastName = "Last",
                    Age = 21
                },
                new Student()
                {
                    Id = 4,
                    Name = "Əli",
                    LastName = "Last",
                    Age = 24
                },
            };

            foreach(var student in students)
            {
                if(student.Id == id)
                    return View(student);
            }

            return View();
        }
    }
}
