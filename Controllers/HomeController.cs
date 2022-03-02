﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LanchesMAC.Models;

namespace LanchesMAC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        TempData["Nome"] = "Dolsan";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
