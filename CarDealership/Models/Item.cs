using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    // public string Description { get; set; }
    private static List<Car> _instances = new List<Car> {};
    public string MakeModel {get; set;} 
    public int Price {get; set;}
    public int Miles {get; set;}
    public string Message {get; set;}
    // _instances.Add(this);

    // public Car (string description)
    // {
    //   Description = description;
    //   _instances.Add(this);
    // }

    public Car(string makeModel, int price, int miles, string message)
    {
        MakeModel = makeModel;
        Price = price;
        Miles = miles;
        Message = message;
        _instances.Add(this);
    }

    public bool WorthBuying(int maxPrice, int maxMileage)
    {
        return (Price < maxPrice && Miles < maxMileage);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}