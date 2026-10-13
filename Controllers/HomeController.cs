using Microsoft.AspNetCore.Mvc;
using portfolio.Models;

namespace portfolio.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var projects = ProjectData.GetAll();
        return View(projects);
    }
}
