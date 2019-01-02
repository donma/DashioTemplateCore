using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DashioTemplateCore.Pages
{
    public class blankModel : PageModel
    {
        public string Content { get; set; }
        public void OnGet()
        {
            DateTime zeroTime = new DateTime(1, 1, 1);

            DateTime a = new DateTime(2017, 12, 28);

            DateTime b = DateTime.Now;

            TimeSpan span = b - a;
            // Because we start at year 1 for the Gregorian
            // calendar, we must subtract a year here.
            int years = (zeroTime + span).Year - 1;
            Content = years.ToString();


            // 1, where my other algorithm resulted in 0.
            // Console.WriteLine("Yrs elapsed: " + years);
        }
    }
}