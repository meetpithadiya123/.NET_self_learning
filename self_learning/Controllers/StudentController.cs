using Microsoft.AspNetCore.Mvc;
using StudentCourseRegistration.Models;

namespace StudentCourseRegistration.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> students = new List<Student>();

        private static int nextId = 1;

        // Display all students
        public IActionResult Index()
        {
            return View(students);
        }

        // Display registration form
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Receive form data
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                student.Id = nextId++;

                students.Add(student);

                return RedirectToAction("Index");
            }

            return View(student);
        }

        // Display individual student details
        public IActionResult Details(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
    }
}