using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EarthlyRemediesClient.Models;

namespace EarthlyRemediesClient.Controllers
{
  public class RemediesController : Controller
  {
    public IActionResult Index()
    {
      var allRemedies = Remedy.GetRemedies();
      return View(allRemedies);
    }

    [HttpPost]
    public IActionResult Index(Remedy remedy)
    {
      Remedy.Post(remedy);
      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var remedy = Remedy.GetDetails(id);
      return View(remedy);
    }

    public IActionResult Edit(int id)
    {
      var remedy = Remedy.GetDetails(id);
      return View(remedy);
    }

    [HttpPost]
    public IActionResult Details(int id, Remedy remedy)
    {
      remedy.RemedyId = id;
      Remedy.Put(remedy);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      Remedy.Delete(id);
      return RedirectToAction("Index");
    }

    // [HttpGet("/IngredientSearch")]
    // public ActionResult IngredientSearch(string search)
    // {
    //   List<Remedy> model = _db.Remedies.ToList();
    //   Remedy match = new Remedy();
    //   List<Remedy> matches = new List<Remedy>{};

    //   if (!string.IsNullOrEmpty(search))
    //   {
    //     foreach(Remedy Remedy in model)
    //     {
    //       if (Remedy.Ingredients.ToLower().Contains(search))
    //       {
    //         matches.Add(Remedy);
    //       }
    //     } 
    //   }
    //   return View(matches);
    // }
  }
}
