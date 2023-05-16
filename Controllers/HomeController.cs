using Microsoft.AspNetCore.Mvc;

namespace TP_04_Paquetes_Turísticos_Droblas_Suken.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Paquetes = ortWorld.Paquetes;
        return View();
    }
    public IActionResult SelectPaquete()
    {
        cargarListas();
        return View();
    }
    public IActionResult GuardarPaquete(int Destino, int Hotel, int Aereo, int Excursion)
    {
        if (Destino > 0 && Hotel > 0 && Aereo > 0 && Excursion > 0)
        {

            Paquete paq = new Paquete(ortWorld.ListaHoteles[Hotel-1], ortWorld.ListaAereos[Aereo-1], ortWorld.ListaExcursiones[Excursion-1]);
            ortWorld.ingresarPaquete(ortWorld.ListaDestinos[Destino-1], paq);
            ViewBag.Paquetes = ortWorld.Paquetes;
            return View("Index");
        }
        else
        {
           cargarListas();
            return View("SelectPaquete");
        }

    }
    public void cargarListas()
    {
        ViewBag.ListaDestinos = ortWorld.ListaDestinos;
        ViewBag.ListaAereos = ortWorld.ListaAereos;
        ViewBag.ListaHoteles = ortWorld.ListaHoteles;
        ViewBag.ListaExcursiones = ortWorld.ListaExcursiones;
    }
}

