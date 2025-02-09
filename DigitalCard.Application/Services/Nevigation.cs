using DigitalCard.Infrastructure.Repository;

namespace DigitalCard.Application.Services
{
    public class Nevigation : Inevigation
    {
        private InevigationRepository _nevigationRepo;
        public Nevigation(InevigationRepository nevigationRepo)
        {
            _nevigationRepo= nevigationRepo;
        }
        public async Task<IEnumerable<Domain.Entities.Nevigation>> GetAllNevigationAsync()
        {
            return await _nevigationRepo.GetAllNevigationAsync();
        }
    }
}
