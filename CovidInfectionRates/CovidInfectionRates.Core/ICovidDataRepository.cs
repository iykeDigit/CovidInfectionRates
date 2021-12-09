using CovidInfectionRates.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidInfectionRates.Core
{
    public interface ICovidDataRepository
    {
        Task<CovidData> GetCovidData();
    }
}
