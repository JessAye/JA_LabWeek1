using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using JA_LabWeek1.Models;
using System.Linq;
using NuGet.Packaging;

namespace JA_LabWeek1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult SimpleTypes()
    {
        bool booleanValue = true;
        sbyte sbybeValue = -128;
        decimal decimalValue = 1.34m;
        float floatValue = 4.56f;
        uint unintValue = 32768;
        short shortValue = 32767;
        return Content($"My name is Jesse. My values: {booleanValue},{sbybeValue},{decimalValue},{floatValue},{shortValue}");

    }

    public IActionResult Toys()
    {
        Toy pokemonPlush = new Toy("Nintendo", 907687678, 16.2);
        Toy actionFigure = new Toy("Hasboro", 123123123, 12.4);
        List<Toy> toyArray = new List<Toy>{pokemonPlush, actionFigure};
        
        return View(toyArray);
    }
  
    [HttpPost] 
    public IActionResult StudentDetails()
    {
        Student test = new Student("test", LetterGrade.A);
        return View();
    }
    public IActionResult CreateStudent()
    {
       
        return View();
    }
    public IActionResult LambdaDemo() {
        Product[] products = new Product[]
{
    new Product {Id = 1, Name = "Handkerchief", Color = "Red", Price = 1.30m},
    new Product {Id = 2, Name = "Chair", Color = "Blue", Price = 2.45m},
    new Product {Id = 3, Name = "Towel", Color = "Pink", Price = 0.89m}
};
        //I couldn;t get Min() to work so I used this 
        var orderedArrayDesc = from p in products orderby p.Price descending select p;
        Product smallest = orderedArrayDesc.ToArray()[orderedArrayDesc.ToArray().Length-1];
        return View(smallest.Price);
    }
   
}