using Microsoft.AspNetCore.Mvc;

namespace TP_04_Paquetes_Turísticos_Droblas_Suken.Controllers;

public class EstudianteController : Controller
{
    public IActionResult Index()
    {
        
        return View();
    }
    public IActionResult SelectPaquete()
    {
        
        return View();
    }
    public IActionResult GuardarPaquete(int Destino, int Hotel, int Aereo, int Excursion)
    {
        
        return View();
    }
}
