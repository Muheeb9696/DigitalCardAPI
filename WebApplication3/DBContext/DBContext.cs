
using DigitalCard.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DigitalCard.DBContext
{
    public class DapperDBContext : IDapperDbConnection
    {
        private readonly IConfiguration _configuration;
        public readonly string _connectionString;

        public DapperDBContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }
        //public DapperDBContext(DbContextOptions<DapperDBContext> options) : base(options)
        //{
        //}

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);

        }
    }
}
