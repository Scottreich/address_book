using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
      [Route("/")]
       public ActionResult Index()
       {
         return View();
       }

      [Route("/Contact_Details")]
      public ActionResult ContactDetails()
      {
        return View();
      }

    }
}
