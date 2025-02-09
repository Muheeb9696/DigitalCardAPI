
using Entities=DigitalCard.Domain.Entities;

namespace DigitalCard.Application.Services
{
    public interface Inevigation
    {
        Task<IEnumerable<Entities.Nevigation>> GetAllNevigationAsync();
    }
}
