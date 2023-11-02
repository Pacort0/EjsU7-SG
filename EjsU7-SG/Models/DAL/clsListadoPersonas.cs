namespace EjsU7_SG.Models.DAL;
using EjsU7_SG.Models.Entidades;
public static class clsListadoPersonas
{
    public static List<clsPersona> listadoPersonas() {

        List<clsPersona> listaPersonas = new List<clsPersona>()
        {
            new clsPersona() {Id = 1, Nombre = "Francisco",Apellidos = "Rodríguez",Direccion = "Mi calle",FechaNac = new DateTime(2003, 04, 27),Tlfn = 654444089},
            new clsPersona() {Id = 2, Nombre = "Juan", Apellidos = "Martínez", IdDepartamento = 1},
            new clsPersona() {Id = 3, Nombre = "Pepe", Apellidos = "Correa",IdDepartamento =  2},
            new clsPersona() {Id = 4, Nombre = "María", Apellidos = "Ronaldo",IdDepartamento =  2},
            new clsPersona() {Id = 5, Nombre = "Amapola", Apellidos = "Rakitic",IdDepartamento =  3},
            new clsPersona() {Id = 6, Nombre = "Rocío", Apellidos = "Duncal",IdDepartamento = 4},
            new clsPersona() {Id = 7, Nombre = "Pedro", Apellidos = " Rodríguez", IdDepartamento = 3},
        };

        return listaPersonas; 
    }
}
