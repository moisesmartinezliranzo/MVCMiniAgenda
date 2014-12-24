using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMiniAgenda.Models;

namespace MVCMiniAgenda.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        //Muestas todod los usuarios de la base de datos
        public ActionResult Index()
        {
            AgendaContext miAgendaContext = new AgendaContext();
            return View(miAgendaContext.LosUsuarios.ToList());
        }

        public ActionResult Detalles(int id)
        {
            AgendaContext miAgendaContext = new AgendaContext();
            Usuarios miUsuario =  miAgendaContext.LosUsuarios.Single(u => u.Id == id);
            return View(miUsuario);
        }

        
        public ActionResult Editar(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgendaContext miAgendaContext = new AgendaContext();
            Usuarios miUsuario = miAgendaContext.LosUsuarios.Find(id);
            
            if (miUsuario == null)
            {
                return HttpNotFound();
            }
            return View(miUsuario);
            
        }

        [HttpPost]
        public ActionResult Editar(int id)
        {
            return View();
        }

    }
}
