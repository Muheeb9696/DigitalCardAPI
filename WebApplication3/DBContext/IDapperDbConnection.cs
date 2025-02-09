using System.Data;

namespace DigitalCard.Interfaces
{
   
        public interface IDapperDbConnection
    {
            public IDbConnection CreateConnection();
        }

    
}
