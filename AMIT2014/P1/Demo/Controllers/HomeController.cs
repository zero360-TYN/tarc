using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo.Controllers;

// TODO
public class HomeController(DB db) : Controller
{
    // GET: Home/Index
    public IActionResult Index()
    {
        // TODO
        var m = db.Students.Include(s => s.Program);
        return View(m);
    }

    // GET: Home/Detail
    public IActionResult Detail(String? id)
    {
        var m = db.Students.Include(s => s.Program).FirstOrDefault(s=> s.Id == id);
        if(m == null)
        {
            return RedirectToAction("Index");
        }
        return View(m);

    }
}
