using DigitalCard.Model;

namespace DigitalCard.IReporsitory
{
    public interface INevigation
    {
        Task<IEnumerable<Nevigation>> GetAllNevigationAsync();
    }
}
