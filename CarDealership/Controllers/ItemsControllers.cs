using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class ItemsController : Controller
  {

    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Car> allItems = Car.GetAll();
      return View(allItems);
    }

    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string makeModel, int price, int miles, string message)
    {
      Car myCar = new Car(makeModel, price, miles, message);
      myCar.MakeModel = makeModel;
      myCar.Price = price;
      myCar.Miles = miles;
      myCar.Message = message;

      return RedirectToAction("Index");
    }
  }
}