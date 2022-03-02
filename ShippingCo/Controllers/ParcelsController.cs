using Microsoft.AspNetCore.Mvc;
using ShippingCo.Models;

namespace ShippingCo.Controllers {
  public class ParcelsController : Controller {
    [HttpGet("/parcels")]  // root directory path
    public ActionResult Index() { 
      HERE GOES SUMPIN  
      return View(); 
    }
    [HttpGet("/parcels/new")]
    public ActionResult Form() {
      return View();
    }
    [HttpPost("/parcels")]
    public ActionResult ShippingCost(int length, int width, int height, int weight) {
      Parcel newParcel = new Parcel(length, width, height, weight)
      return RedirectToAction("Index");
    }
    
  }
}
    
//     [HttpPost("/cars")]
//     public ActionResult Create(string makeModel, int year, int price, int miles)
//     {
//       Car car = new Car(makeModel, year, price, miles);
//       return RedirectToAction("Index");
//     }
// }

[Route("/")]
    public ActionResult Index()
    {
      Item starterItem = new Item("Add first item to To Do List");
      return View(starterItem);
    }

    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    //when form is completed where does it go? how is object instantiated
    //how to use that object in our parcels/index.cshtml