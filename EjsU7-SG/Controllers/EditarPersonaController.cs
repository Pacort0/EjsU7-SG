using Microsoft.AspNetCore.Mvc;
using EjsU7_SG.Models.Entidades;
using EjsU7_SG.Models.DAL;

namespace EjsU7_SG.Controllers
{
    public class EditarPersonaController : Controller
    {
        /// <summary>
        /// Action result para la vista EditarPersona
        /// En ella se crean dos tablas, una de departamentos y otra de usuarios
        /// Ambas tablas se pasan a la vista mediante ViewBag
        /// Post: Siempre devuelve algo
        /// </summary>
        /// <returns>Devuelve la vista EditarPersona</returns>
        public IActionResult EditarPersona()
        {

            List<clsDepartamento> listaDepartamentos = new() { 
                new clsDepartamento { IdDepartamento = 1, NombreDepartamento = "Finanzas" },
                new clsDepartamento { IdDepartamento = 2, NombreDepartamento = "Dirección" },
                new clsDepartamento { IdDepartamento = 3, NombreDepartamento = "Recursos Humanos" },
                new clsDepartamento { IdDepartamento = 4, NombreDepartamento = "Producción" },
            };
            return View(clsListadoPersonas.listadoPersonas());
        }
    }
}
