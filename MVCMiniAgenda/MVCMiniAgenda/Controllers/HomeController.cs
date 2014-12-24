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

    }
}
