using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace UmbracoCMS.Controllers
{
    public class ContactController : Umbraco.Web.Mvc.SurfaceController
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
    }
}