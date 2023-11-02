namespace EjsU7_SG.Models.DAL;
using EjsU7_SG.Models.Entidades;

public static class clsListadoDeptPersonas
{
    public static List<clsPersona> listadoDeptPersonas()
    {
        List<clsPersona> deptPersonas = new List<clsPersona>()
        {
            new clsPersona() {Id = 1, Nombre = "Francisco",Apellidos = "Rodríguez", IdDepartamento=1},
            new clsPersona() {Id = 2, Nombre = "Juan", Apellidos = "Martínez", IdDepartamento=2},
            new clsPersona() {Id = 3, Nombre = "Pepe", Apellidos = "Correa", IdDepartamento = 3},
            new clsPersona() {Id = 4, Nombre = "María", Apellidos = "Ronaldo", IdDepartamento = 4},
            new clsPersona() {Id = 5, Nombre = "Amapola", Apellidos = "Rakitic", IdDepartamento = 3},
            new clsPersona() {Id = 6, Nombre = "Rocío", Apellidos = "Duncal", IdDepartamento = 2},
            new clsPersona() {Id = 7, Nombre = "Pedro", Apellidos = " Rodríguez", IdDepartamento = 1},
            new clsPersona() {Id = 8, Nombre = "Marta", Apellidos = "Flores", IdDepartamento = 4},
            new clsPersona() {Id = 9, Nombre = "Javier", Apellidos = "Guapo", IdDepartamento = 1},
            new clsPersona() {Id=10, Nombre = "Juanma", Apellidos = "Good Game", IdDepartamento = 2}
        };
        return deptPersonas;
    }
}