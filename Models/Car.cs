using System;
using System.Collections.Generic;

namespace Dealership.Models 
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    public int Id { get; }
    private static List<Car> _instances = new List<Car>();

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Id = _instances.Count;
      _instances.Add(this);
    }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like" + sound;
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static Car Find(int searchId)
    {
      return _instances[searchId-0];
    }
  }
}