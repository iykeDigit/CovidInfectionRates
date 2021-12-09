using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidInfectionRates.Model
{
    public class States
    {
        public string _Id { get; set; }
        public string State { get; set; }
        public int ConfirmedCases { get; set; }
        public int CasesOnAdmission { get; set; }
        public int Discharged { get; set; }
        public int Death { get; set; }
    }
}
