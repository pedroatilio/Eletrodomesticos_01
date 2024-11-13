using Eletrodomesticos_01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eletrodomesticos_01.Controllers
{
    public class ListaEletrodomesticoController : Controller
    {
        public IActionResult Index()
        {
            List<Eletrodomestico> eletrodomesticos = new List<Eletrodomestico>
            {
                new Geladeira {Marca = "Eletrolux", Modelo = "Frost Free", ConsumoEnergetico = 5, CapacidadeLitros = 410, TemFreezer = true },
                new Televisao {Marca = "TCL", Modelo = "C655", ConsumoEnergetico = 10, EhSmart = true, TamanhoTela = 50 },
                new Televisao {Marca = "Philips", Modelo = "7019", ConsumoEnergetico = 15, EhSmart = true, TamanhoTela = 50 }

            };

            return View(eletrodomesticos);
        }
    }
}
