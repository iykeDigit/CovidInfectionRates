using CovidInfectionRates.Model;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CovidInfectionRates.Core
{
    
    public class CovidDataRepository : ICovidDataRepository
    {


        public async Task<CovidData> GetCovidData()
        {
            //CovidData covidInfectionRates = new List<CovidData>();
            CovidData covidInfectionRates = new CovidData();
            List<States> covidStatesData = new List<States>();

            string url = "https://covidnigeria.herokuapp.com/api";
            using (var client = new HttpClient())
            {

                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();


                    var x = JsonConvert.DeserializeObject<Datas>(result);
                    covidInfectionRates.TotalActiveCases = x.Data.TotalActiveCases;
                    covidInfectionRates.TotalConfirmedCases = x.Data.TotalConfirmedCases;
                    covidInfectionRates.totalSamplesTested = x.Data.totalSamplesTested;
                    covidInfectionRates.Death = x.Data.Death;
                    covidInfectionRates.Discharged = x.Data.Discharged;
                    
                    foreach(var data in x.Data.States) 
                    {
                        covidStatesData.Add(data);
                    }

                    covidStatesData= covidStatesData.OrderBy(x => x.State).ToList();
                    covidInfectionRates.States = covidStatesData;
                }

                return covidInfectionRates;

            }
         }
    }

    
}
