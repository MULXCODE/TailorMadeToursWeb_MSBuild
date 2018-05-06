using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMadeTours.Models;

namespace FastFocusApp.Pages
{
  public class DetailModel : PageModel
  {
    public void OnGet(int stopNumber)
    {
      CurrentTourStop = TailorMadeTours.Models.TourSource.TourStops.Where(x => x.StopNumber == stopNumber).FirstOrDefault() as TourStop;

      // add a bug to the code
      // when tour is stop Lurie Garden
      var currentStopNumber = CurrentTourStop.StopNumber;
      if (CurrentTourStop.StopNumber== 6)
      {
        // set to the wrong stop
        CurrentTourStop = TailorMadeTours.Models.TourSource.TourStops.First() as TourStop;
      }
    }

 
    [BindProperty]
    public TourStop CurrentTourStop { get; set; }
  }
}