using Microsoft.AspNetCore.Mvc;
using TareasRecordManagementSystem.Models;
using System.Collections.Generic;
using System;
using TareasRecordManagementSystem.Data;

namespace TareasRecordManagementSystem.Controllers
{
    public class TareaController : Controller
    {
        TareaDAL NotasDataAccessLayer = new TareaDAL();
  
        public TareaController()
        {
            NotasDataAccessLayer = new TareaDAL();
        }

        // GET: Student
        public ActionResult Index()
        {
            IEnumerable<Tarea> students = NotasDataAccessLayer.ObtenerTareas();
            return View(students);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tarea notasE)
        {
            try
            {
                // TODO: Add insert logic here
                NotasDataAccessLayer.InsertarCalificacion(notasE);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        // POST: Student/Edit/5
        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            Tarea notas = NotasDataAccessLayer.ObtenerCalificacionesEdit(id);
            return View(notas);
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Tarea notas)
        {
            try
            {
                // TODO: Add update logic here
                NotasDataAccessLayer.ActualizarTarea(notas);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: Clientes/Delete/5
        // POST: Clientes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                NotasDataAccessLayer.EliminarCalificacion(id); // Supongo que el método se llama DeleteCliente y toma el ID del cliente como parámetro
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
