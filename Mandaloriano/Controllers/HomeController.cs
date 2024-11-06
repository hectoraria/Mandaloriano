using BL;
using Mandaloriano.Models;
using Mandaloriano.VM;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mandaloriano.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            MostrarMisiones viewm = new MostrarMisiones();

            viewm.listadoMisiones=ClsListadoBL.listadoMisionesBL();


            return View(viewm);
        }

        [HttpPost]
        public IActionResult Index(int id)
        {
            MostrarMisiones viewm = new MostrarMisiones();
            viewm.listadoMisiones = ClsListadoBL.listadoMisionesBL();
            viewm.misionSelecionada=ClsListadoBL.SelecionarMisionBL(id);

            return View(viewm);
        }

        
    }
}
