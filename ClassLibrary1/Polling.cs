using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Polling: BaseEntity
    {
        public string Unit_No { get; }
        [RegularExpression(@"^[A-Z]{3}$")]

        public IList<Voter> Voters { get; set; }

        public string PollingUnitCode { get; set; }

        public string LocalGovernment { get; set; }

        public Polling(string LGA)
        {
            LocalGovernment = LGA;
            Unit_No = $"{LGA}-{Guid.NewGuid().ToString().Replace("-", "").Substring(0, 6)}";
            PollingUnitCode = Unit_No.Substring(0, 7);
        }

        public Polling(string LGA, string unitNO, string id): base(id)
        {
            LocalGovernment = LGA;
            Unit_No = unitNO;
        }
    }
}
