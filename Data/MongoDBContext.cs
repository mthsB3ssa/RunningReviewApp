using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using RunningReviewApp.Models;

namespace RunningReviewApp.Data
{
    public class MongoDBContext
    {
        private readonly IMongoDatabase _database;

        // Construtor para inicializar a conexão
        public MongoDBContext(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("MongoDBSettings:ConnectionString"));
            _database = client.GetDatabase(config["MongoDBSettings:DatabaseName"]);
        }

        // Propriedades para acessar coleções
        public IMongoCollection<Running> Runnings => _database.GetCollection<Running>("Runnings");
        public IMongoCollection<User> Users => _database.GetCollection<User>("Users");
    }
}
