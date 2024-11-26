using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http; // Agregar este espacio de nombres
using TareasRecordManagementSystem.Data;
using TareasRecordManagementSystem.Models;
using System.Security.Cryptography;
using System.Data;

namespace TareasRecordManagementSystem.Models
{
    public class UsuarioController : Controller
    {
        UsuarioD usuarioDataAccessLayer = new UsuarioD();

        public UsuarioController()
        {
            usuarioDataAccessLayer = new UsuarioD();
        }
        public ActionResult PrincipalLogin(Usuario usuEnt)
        {
            if (usuEnt.Username != null && usuEnt.Clave != null)
            {
                HttpContext.Session.SetString("usuarioID", usuEnt.Username);
                HttpContext.Session.SetString("ClienteID", usuEnt.Clave);
            }

            return View();

        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Loout()
        {
            //HttpContext.Session.SetString("usuarioID", "");
            //HttpContext.Session.SetString("ClienteID", "");
            ViewBag.usuario = "";
            return View("PrincipalLogin");
        }
        public String ValidarLogin(String usuario, String clave)
        {
            String rpt = null;
            UsuarioD objAccess = new UsuarioD();
            Usuario entusuario = new Usuario();
            entusuario.Username = usuario;
            entusuario.Clave = clave;
            //entusuario.Username = usuario.Username;
            //entusuario.Clave = usuario.Clave;
            DataTable datosDeUsuario = objAccess.IniciarSesion(entusuario);
            //HttpContext.Session.SetString("usuarioID", "");
            //if (usuario != null && entusuario.Clave != null && datosDeUsuario.Rows.Count > 0)
            if (usuario != null && entusuario.Clave != null && datosDeUsuario != null)
            {
                //HttpContext.Session.SetString("usuarioID", datosDeUsuario);
                ViewBag.idUsuario = entusuario.Username;
                ViewData["idUsuario"] = entusuario.Username;
                
                return entusuario.Username;
                //return rpt;
            }
            else
            {
                return null;
            }
        }
    }
}
