namespace EjsU7_SG.Models.DAL;
using EjsU7_SG.Models.Entidades;
public static class clsListadoPersonas
{
    public static List<clsPersona> listadoPersonas() {

        List<clsPersona> listaPersonas = new List<clsPersona>()
        {
            new clsPersona() {Id = 1, Nombre = "Francisco",Apellidos = "Rodríguez"},
            new clsPersona() {Id = 2, Nombre = "Juan", Apellidos = "Martínez"},
            new clsPersona() {Id = 3, Nombre = "Pepe", Apellidos = "Correa"},
            new clsPersona() {Id = 4, Nombre = "María", Apellidos = "Ronaldo"},
            new clsPersona() {Id = 5, Nombre = "Amapola", Apellidos = "Rakitic"},
            new clsPersona() {Id = 6, Nombre = "Rocío", Apellidos = "Duncal"},
            new clsPersona() {Id = 7, Nombre = "Pedro", Apellidos = " Rodríguez"},
        };

        return listaPersonas; 
    }
}
