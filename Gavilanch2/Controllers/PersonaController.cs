using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gavilanch2.Models;

namespace Gavilanch2.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Listar()
        {
            var model = new PersonaModel();

            using (var db = new dbTestEntities())
            {
                model.ObjetoPersona = db.Persona.FirstOrDefault();
            }
            

            return View(model);
        }
    }
}