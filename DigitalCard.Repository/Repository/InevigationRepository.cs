using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalCard.Domain.Entities;
namespace DigitalCard.Infrastructure.Repository
{
    public interface InevigationRepository
    {
        Task<IEnumerable<Nevigation>> GetAllNevigationAsync();
    }
}
