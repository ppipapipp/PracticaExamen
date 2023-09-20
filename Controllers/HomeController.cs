using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practica_pre_examen_pipa_2.Models;

namespace practica_pre_examen_pipa_2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }


    public IActionResult ListadoAlumnos()
    {
       List<Alumnos> _ListaDeAlumnos=BD.GetListadoAlumnos();
       ViewBag.ListaDeAlumnos=_ListaDeAlumnos;    
       return View();
    }

    public IActionResult DetalleAlumnos(string legajo)
    {
       List<Alumnos> _DetalleAlumno=BD.GetDetalleAlumno(legajo);
       ViewBag.DetalleAlumno=_DetalleAlumno;    
       
       List<Notas> _NotasAlumno =BD.GetNotasAlumno(legajo);
       ViewBag.NotasAlumno=_NotasAlumno;    
       return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
