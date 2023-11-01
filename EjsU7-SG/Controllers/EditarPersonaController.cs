using EjsU7_SG.Models.DAL;
using Microsoft.AspNetCore.Mvc;
using EjsU7_SG.Models.DAL;

namespace EjsU7_SG.Controllers
{
    public class EditarPersonaController : Controller
    {
        public IActionResult EditarPersona()
        {
            List<clsPersona> listaPersonas = new()
            {
                new clsPersona() {Id = 1, Nombre = "Francisco",Apellidos = "Rodríguez", IdDepartamento=3},
                new clsPersona() {Id = 2, Nombre = "Juan", Apellidos = "Martínez", IdDepartamento = 1},
                new clsPersona() {Id = 3, Nombre = "Pepe", Apellidos = "Correa",IdDepartamento =  2},
                new clsPersona() {Id = 4, Nombre = "María", Apellidos = "Ronaldo",IdDepartamento =  2},
                new clsPersona() {Id = 5, Nombre = "Amapola", Apellidos = "Rakitic",IdDepartamento =  3},
                new clsPersona() {Id = 6, Nombre = "Rocío", Apellidos = "Duncal",IdDepartamento = 4},
                new clsPersona() {Id = 7, Nombre = "Pedro", Apellidos = " Rodríguez", IdDepartamento = 3},
            };

            List<clsDepartamento> listaDepartamentos = new() { 
                new clsDepartamento { IdDepartamento = 1, NombreDepartamento = "Finanzas" },
                new clsDepartamento { IdDepartamento = 2, NombreDepartamento = "Dirección" },
                new clsDepartamento { IdDepartamento = 3, NombreDepartamento = "Recursos Humanos" },
                new clsDepartamento { IdDepartamento = 4, NombreDepartamento = "Producción" },
            };

            ViewBag.listaDepartamentos = listaDepartamentos;
            ViewBag.listaPersonas = listaPersonas;
            return View();
        }
    }
}
