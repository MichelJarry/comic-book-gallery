using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        //ActionResult is almos always used as a return type for action methods
        //(hit f12 or Alt f12 for interface information)
        public ActionResult Detail()
        {
            return View();
        }
    }
}
