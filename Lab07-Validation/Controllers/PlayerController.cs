using Microsoft.AspNetCore.Mvc;
using LabMVC.Models;

namespace LabMVC.Controllers
{
    public class PlayerController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Player p)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message =
                    "Player information is valid.";
            }

            return View(p);
        }
    }
}