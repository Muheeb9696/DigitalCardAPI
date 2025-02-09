using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace ServiceTier.Infrastructure.Context
{
    public class DBContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        private readonly string _cmsConnectionString;
        public DBContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }
        public IDbConnection CreateConnection()
            => new SqlConnection(_connectionString);
        public IConfiguration GetAppSettingKeyValue() => _configuration;
        
    }
    public class DBContext_ClientKey
    {
        private readonly IConfiguration _configuration;
        private readonly string _decryptkey, _encryptKey;



        public DBContext_ClientKey(IConfiguration configuration)
        {
            _configuration = configuration;
            _decryptkey = _configuration.GetSection("Key")["DecryptKey"].ToString();// ("Key");
            _encryptKey = _configuration.GetSection("Key")["EncryptKey"].ToString();
        }
        public string DecryptKey() => _decryptkey;
        public string EncryptKey() => _encryptKey;

    }
    
    public class DBContext_Email
    {
        private readonly IConfiguration _configuration;
        private readonly string _SMTPSERVER;
        private readonly string _EMAIL_SUBJECT_ENVIRONMENT;
        public DBContext_Email(IConfiguration configuration)
        {
            _configuration = configuration;
            _SMTPSERVER = _configuration.GetSection("Email")["SMTPSERVER"].ToString();
            _EMAIL_SUBJECT_ENVIRONMENT = _configuration.GetSection("Email")["EMAIL_SUBJECT_ENVIRONMENT"].ToString();
        }
    }

    //public class JobDBContext
    //{
    //    private readonly string _connectionString;
    //    private readonly string _cmsConnectionString;
    //    public JobDBContext()
    //    {
    //        _connectionString = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["SqlConnection"];
    //        _cmsConnectionString = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["CMSConnectionString"];
    //    }
    //    public IDbConnection CreateConnection()
    //       => new SqlConnection(_connectionString);
    //    public IDbConnection CreateCMSConnection()
    //        => new SqlConnection(_cmsConnectionString);
    //}
}
