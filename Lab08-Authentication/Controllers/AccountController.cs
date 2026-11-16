using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

public class AccountController : Controller
{
    [HttpGet]
    public IActionResult Login()
    {
        return Content("Send a POST request with username and password.");
    }

    [HttpPost]
    public async Task<IActionResult> Login(
        string username, string password)
    {
        string role = "";

        if (username == "admin" && password == "admin123")
        {
            role = "Admin";
        }
        else if (username == "user" && password == "user123")
        {
            role = "User";
        }
        else
        {
            return Unauthorized("Invalid credentials.");
        }

        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, username),
            new Claim(ClaimTypes.Role, role)
        };

        var identity = new ClaimsIdentity(
            claims,
            CookieAuthenticationDefaults.AuthenticationScheme);

        await HttpContext.SignInAsync(
            CookieAuthenticationDefaults.AuthenticationScheme,
            new ClaimsPrincipal(identity));

        return Content(
            "Student: Krishna Aryal\n" +
            "Login Successful!\n" +
            "Username: " + username + "\n" +
            "Assigned Role: " + role);
    }

    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync(
            CookieAuthenticationDefaults.AuthenticationScheme);

        return Content("Logout Successful.");
    }
}