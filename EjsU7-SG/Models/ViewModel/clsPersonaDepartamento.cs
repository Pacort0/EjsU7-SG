using EjsU7_SG.Models.DAL;
using EjsU7_SG.Models.Entidades;

namespace EjsU7_SG.Models.ViewModel
{
    public class clsPersonaDepartamento:clsPersona
    {
        #region propiedades
        public List<clsDepartamento> ListaDepartamentos
        {
            get;
        }
        #endregion
        #region constructores
        public clsPersonaDepartamento()
        {
            ListaDepartamentos = clsListadoDepartamentos.listadoDepartamentos();
            Nombre = "Ivan";
            Apellidos = "Rakitic";
        }
        #endregion

    }
}
