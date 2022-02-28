using Models.Enums;
using System.Collections.Generic;

namespace Models
{
    public class Election : BaseEntity
    {
        public ElectionType Type { get; set; }

        public string Location { get; set; }

        public Candidate Winner { get; set; }

        public IList<Candidate> Contenders { get; set; }

        public Election()
        {

        }
        public Election(string id): base(id)
        {

        }

    }
}


