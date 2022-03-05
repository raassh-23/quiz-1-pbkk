using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcQuiz1Pbkk.Controllers;

public class Q1Controller : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Profile() {
        return View();
    }

    public IActionResult Company() {
        return View();
    }

    public IActionResult Product() {
        return View();
    }

    public IActionResult Collaboration() {
        return View();
    }
}
