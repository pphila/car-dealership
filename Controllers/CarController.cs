using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;

namespace Dealership.Controllers
{
  public class CarController : Controller
  {

    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult NewCar()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(string makeModel, int price, int miles)
    {
      Car myCar = new Car(makeModel, price, miles);
      return RedirectToAction("Index");
    }

    [HttpGet("/cars/{id}")]
    public ActionResult Show(int id)
    {
      Car foundCar = Car.Find(id);
      return View(foundCar);
    }
  }
}