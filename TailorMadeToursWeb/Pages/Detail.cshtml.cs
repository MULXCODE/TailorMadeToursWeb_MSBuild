using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMadeTours.Models;

namespace FastFocusApp.Pages
{
    public class DatabindWithRouteParamModel : PageModel
    {
    public void OnGet(int id)
    {
      CurrentTourStop = TailorMadeTours.Models.TourSource.TourStops.ElementAt(id);

    }

    // use TempData property to pass data between pages
    // Properties marked with TempData
    // attribute with are stored in encrypted cookie
    // When the data is read from the cookie, it is deleted.
    [TempData]
    public string Message { get; set; }


    public bool ShouldShowMessage => !String.IsNullOrEmpty(Message);
   [BindProperty]
    public TourStop CurrentTourStop { get; set; }
  }
}