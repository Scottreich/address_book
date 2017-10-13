using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
      [Route("/pageOne")]
       public ActionResult Hello()
       {
         return View();
       }

    }
}
