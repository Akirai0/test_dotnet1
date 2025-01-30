using Microsoft.AspNetCore.Mvc;
using test_dotnet1.Data;
using test_dotnet1.Models;

namespace test_dotnet1.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDBContext _db;
        public StudentController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var s1 = new Student();
            var s2 = new Student();
            var s3 = new Student();
            s1.Id = 1;
            s1.Name = "Akirai";
            s1.Score = 0;

            s2.Id = 2;
            s2.Name = "Akiraie";
            s2.Score = 0;

            s3.Id = 3;
            s3.Name = "Miyabi";
            s3.Score = 0;

            List<Student> Allstudent = new List<Student>();
            Allstudent.Add(s1);
            Allstudent.Add(s2);
            Allstudent.Add(s3);
            return View(Allstudent);
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult ShowScore(int id)
        {
            return Content($"Score ID : {id}");
        }
    }
}
