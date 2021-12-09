using CovidInfectionRates.Core;
using CovidInfectionRates.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidInfectionRates.Controllers
{
    public class CovidController : Controller
    {
        private readonly ICovidDataRepository _covidDataRepository;

        public CovidController(ICovidDataRepository covidDataRepository)
        {
            _covidDataRepository = covidDataRepository;
        }


        
        [HttpGet]
        public async Task<IActionResult> Index() 
        {
            var data = await _covidDataRepository.GetCovidData();
            

            if(data == null) 
            {
                ViewBag.Message = "An error occurred while retrieving the covid data";
            }
            ViewBag.Death = data.Death;
            ViewBag.Discharged = data.Discharged;
            ViewBag.TotalActiveCases = data.TotalActiveCases;
            ViewBag.TotalConfirmedCases = data.TotalConfirmedCases;
            ViewBag.TotalSamplesTested = data.totalSamplesTested;
            var statesData = data.States.ToList();

            return View(statesData);
        }




       


    }
}
