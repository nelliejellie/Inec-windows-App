using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Core.Contracts
{
    public interface IVoterRepository : IAsyncRepository<Voter>, IRepository<Voter>
    {
    }
}
