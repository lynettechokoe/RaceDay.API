using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;

namespace RaceDay.MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApiService _apiService;

        public AccountController(ApiService apiService)
        {
            _apiService = apiService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            // Create the payload for the API
            var payload = new { Email = email, Password = password };
            var content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");

            // Call your Part 2 API
            var response = await _apiService.Client.PostAsync("/api/Auth/login", content);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var data = JsonDocument.Parse(json).RootElement;

                // Save the JWT token and Role in the browser session
                HttpContext.Session.SetString("JwtToken", data.GetProperty("token").GetString() ?? "");
                HttpContext.Session.SetString("UserRole", data.GetProperty("role").GetString() ?? "");

                // Redirect based on role
                if (data.GetProperty("role").GetString() == "Organiser")
                {
                    return RedirectToAction("Index", "Organiser");
                }
                else
                {
                    return RedirectToAction("Index", "Participant");
                }
            }

            ViewBag.Error = "Invalid email or password.";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}