using CASO3SinScaffolding21100534.Core.Entities;
using CASO3SinScaffolding21100534.Core.Interfaces;
using CASO3SinScaffolding21100534.Data;
using Microsoft.EntityFrameworkCore;



namespace CASO3SinScaffolding21100534.Infrastructure.Repositories
{
    public class JobOfferRepository : IJobOfferRepository
    {
        private readonly Parcial20240221100534Context _context;

        public JobOfferRepository(Parcial20240221100534Context context)
        {
            _context = context;
        }


        public async Task<IEnumerable<JobOffer>> GetJobOffer()
        {
            return await _context.JobOffer.ToListAsync();
        }

        public async  Task Insert(JobOffer JobOffer)
        {
            await _context.JobOffer.AddAsync(JobOffer);
        }
    }




}
