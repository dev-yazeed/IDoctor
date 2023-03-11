using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IDoctor.Models;

namespace IDoctor.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    { Doctor doc = new Doctor
        {
            Id = 1,
            DoctorName = "YazeedAlabdulltif",
            DoctorPhone = 0549339968,
            DoctorSpecialization = "EER",
            DoctorEmail = "Yazeedalabdulltif@gmail.com"
            };
            ViewData["Message"] = doc;
            return View();
    }

    public IActionResult Privacy()

    {
        return View();
        
    }
    public IActionResult Register()
    {
        
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}

