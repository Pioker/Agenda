using Microsoft.AspNetCore.Mvc;
using WebUi.Models; 

namespace WebUi.Controllers;

public class ContatoControllers : Controller
{
    public IActionResult Create()
    {
        return View();
    }
        
    }
    [HttpPost]
    public IActionResult Create( contato contato)
    {
        return Results.Ok("", contato);
    }
        
    }

    