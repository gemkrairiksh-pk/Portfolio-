using Microsoft.AspNetCore.Mvc;
using portfolio.Models;

namespace portfolio.Controllers;

public class ProjectController : Controller
{
    public IActionResult Detail(string slug)
    {
        var project = ProjectData.GetBySlug(slug);
        if (project == null) return NotFound();
        return View(project);
    }
}
