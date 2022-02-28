using System.Collections.Generic;

namespace Models
{
    public class PollingUnit : BaseEntity
    {
        public string Unit_No { get; set; }

        public IList<Voter> Voters { get; set; }
    }
}


