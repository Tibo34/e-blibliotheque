using e_bibliotheque.Models;
using System.Collections.Generic;
using System.Web.Mvc;


namespace e_bibliotheque.Controllers
{
    public class HomeController : Controller
    {
         // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        
    }
}