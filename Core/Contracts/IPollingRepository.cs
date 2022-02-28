using Models;

namespace Core.Contracts
{
    public interface IPollingRepository : IAsyncRepository<Polling>, IRepository<Polling>
    {
    }
}
