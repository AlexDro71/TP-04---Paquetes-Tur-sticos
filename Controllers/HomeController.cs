using Microsoft.AspNetCore.Mvc;

namespace TP_04_Paquetes_Turísticos_Droblas_Suken.Controllers;

public class EstudianteController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Paquetes = ortWorld.Paquetes;
        return View();
    }
    public IActionResult SelectPaquete()
    {
        ViewBag.ListaDestinos = ortWorld.ListaDestinos;
        ViewBag.ListaAereos = ortWorld.ListaAereos;
        ViewBag.ListaHoteles = ortWorld.ListaHoteles;
        ViewBag.ListaExcursiones = ortWorld.ListaExcursiones;
        return View();
    }
    public IActionResult GuardarPaquete(int Destino, int Hotel, int Aereo, int Excursion)
    {
        if (Destino > 0 && Hotel > 0 && Aereo > 0 && Excursion > 0)
        {
            Paquete paq = new Paquete(ortWorld.ListaHoteles[Hotel], ortWorld.ListaAereos[Aereo], ortWorld.ListaExcursiones[Excursion]);
            ortWorld.ingresarPaquete(ortWorld.ListaDestinos[Destino], paq);
            return View("index.cshtml");
        }
        else
        {
            return View("selectPaquete.cshtml");
        }
    }
}
