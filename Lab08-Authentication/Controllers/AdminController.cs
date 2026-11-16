using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    public IActionResult Index()
    {
        return Content(
            "Student: Krishna Aryal\n" +
            "Welcome to Admin Dashboard!\n" +
            "Access Granted.\n" +
            "Authorized Role: Admin");
    }
}