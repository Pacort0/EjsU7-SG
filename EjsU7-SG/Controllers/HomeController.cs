﻿using AspNetCore;
using EjsU7_SG.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjsU7_SG.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var fechaActual = DateTime.Now;
            var message = "Buenos días";

            if (fechaActual.Hour >= 14)
            {
                message = "Buenas tardes";
            } else if (fechaActual.Hour >= 21)
            {
                message = "Buenas noches";
            }

            List<clsPersona> listaPersonas = new()
            {
                persona,
                new clsPersona() {Id = 2, Nombre = "Juan", Apellidos = "Martínez"},
                new clsPersona() {Id = 3, Nombre = "Pepe", Apellidos = "Correa"},
                new clsPersona() {Id = 4, Nombre = "María", Apellidos = "Ronaldo"},
                new clsPersona() {Id = 5, Nombre = "Amapola", Apellidos = "Rakitic"},
                new clsPersona() {Id = 6, Nombre = "Rocío", Apellidos = "Duncal"},
                new clsPersona() {Id = 7, Nombre = "Pedro", Apellidos = " Rodríguez"},
            };

            ViewBag.listaPersonas = listaPersonas;
            ViewData["Message"] = message;
            ViewBag.fechaLarga = fechaActual.ToLongDateString();
            return View(persona);
        }

        private clsPersona persona = new clsPersona()
        {
            Id = 1,
            Nombre = "Francisco",
            Apellidos = "Rodríguez",
            Direccion = "Mi calle",
            FechaNac = new DateTime(2003, 04, 27),
            Tlfn = 654444089,
        };
    }

}