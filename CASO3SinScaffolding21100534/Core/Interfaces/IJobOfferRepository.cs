using CASO3SinScaffolding21100534.Core.Entities;

namespace CASO3SinScaffolding21100534.Core.Interfaces
{
    public interface IJobOfferRepository
    {
        Task<IEnumerable<JobOffer>> GetJobOffer();
    }
}