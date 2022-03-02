using Microsoft.AspNetCore.Mvc;
using ShippingCo.Models;

namespace ShippingCo.Controllers {
  public class HomeController : Controller {
    [HttpGet("/")]
    public ActionResult Index() {
      return View();
    }
  }
}