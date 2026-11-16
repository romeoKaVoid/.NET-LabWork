using Microsoft.AspNetCore.Mvc;

public class CookieController : Controller
{
    public IActionResult Save()
    {
        var options = new CookieOptions
        {
            Expires = DateTimeOffset.UtcNow.AddDays(5),
            HttpOnly = true,
            Secure = true,
            SameSite = SameSiteMode.Lax
        };

        Response.Cookies.Append(
            "UserName", "Krishna", options);

        return Content(
            "User information saved for 5 days.");
    }

    public IActionResult Read()
    {
        string name =
            Request.Cookies["UserName"] ?? "Not found";

        return Content("User: " + name);
    }

    public IActionResult Delete()
    {
        Response.Cookies.Delete("UserName");

        return Content("Cookie deleted.");
    }
}