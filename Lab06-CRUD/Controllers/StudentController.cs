using Microsoft.AspNetCore.Mvc;
using LabMVC.Models;

namespace LabMVC.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> students = new();
        private static int nextId = 1;

        public IActionResult Index()
        {
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student s)
        {
            s.Id = nextId++;
            students.Add(s);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var s = students.FirstOrDefault(x => x.Id == id);
            if (s == null) return NotFound();
            return View(s);
        }

        [HttpPost]
        public IActionResult Edit(Student s)
        {
            var old = students.FirstOrDefault(
                x => x.Id == s.Id);

            if (old == null) return NotFound();

            old.Name = s.Name;
            old.Address = s.Address;
            old.Email = s.Email;

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var s = students.FirstOrDefault(x => x.Id == id);
            if (s != null) students.Remove(s);

            return RedirectToAction("Index");
        }
    }
}