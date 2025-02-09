using Dapper;
using DigitalCard.DBContext;
using DigitalCard.IReporsitory;
using DigitalCard.Model;
using System.Data;

namespace DigitalCard.Repository
{
    public class NevigationRepository : INevigation
    {
        private readonly DapperDBContext _context;
        public NevigationRepository(DapperDBContext dapperDbConnection)
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
