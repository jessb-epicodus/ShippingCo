using Microsoft.AspNetCore.Mvc;
using ShippingCo.Models;

namespace ShippingCo.Controllers {
  public class ParcelsController : Controller {
    [Route("/")]  // root directory path
    public ActionResult Index() { return View(); }
  }
}