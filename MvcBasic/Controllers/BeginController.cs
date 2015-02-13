using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBasic.Models;

namespace MvcBasic.Controllers
{
    public class BeginController : Controller
    {
        private MvcBasicContext db = new MvcBasicContext();

        public ActionResult List()
        {
            return View(db.Members);
        }

        // GET: Begin
        public ActionResult Index()
        {
            return Content("こんにちは、世界！");
        }
        public ActionResult Show()
        {
            ViewBag.Message = "hello world!";
            return View();
        }
    }
}