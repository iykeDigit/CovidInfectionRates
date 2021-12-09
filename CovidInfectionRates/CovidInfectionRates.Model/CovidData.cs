using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidInfectionRates.Model
{
    public class CovidData
    {
        public string totalSamplesTested { get; set; }
        
        public string TotalConfirmedCases { get; set; }

        
        public string TotalActiveCases { get; set; }
        
        public string Discharged { get; set; }
        
        public string Death { get; set; }
        
        public ICollection<States> States { get; set; }
    }
}
