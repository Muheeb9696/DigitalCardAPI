using Dapper;
using DigitalCard.Domain.Entities;
using DigitalCard.Infrastructure;
using ServiceTier.Infrastructure.Context;
using System.Data;

namespace DigitalCard.Infrastructure.Repository
{
    public class NevigationRepository : InevigationRepository
    {
        private readonly DBContext _context;
        public NevigationRepository(DBContext dapperDbConnection)
        {
            _context = dapperDbConnection;
        }
        public async Task<IEnumerable<Nevigation>> GetAllNevigationAsync()
        {
            using (IDbConnection db = _context.CreateConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("NavId", null);
                return await db.QueryAsync<Nevigation>("getTopNevigation", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
