using System.Collections.Generic;

namespace Models
{
    public class Party : BaseEntity
    {
        public string Name { get; set; }

        public int Votes { get; set; }

        public IList<Candidate> Candidates { get; set; }

        public Party(string id): base(id)
        {
                
        }

        public Party()
        {

        }
    }
}


