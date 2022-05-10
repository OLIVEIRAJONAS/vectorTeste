using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VectorTest.API.Models
{
    public class EmailsDatabaseSettings : IDatabaseSettings
    {
        public string EmailsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string UsersCollectionName { get; set; }
    }


    public interface IDatabaseSettings
    {
        string EmailsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string UsersCollectionName { get; set; }
    }
}
