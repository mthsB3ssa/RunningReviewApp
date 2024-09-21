using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace RunningReviewApp.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }
        public ICollection<Running> Runs { get; set; } // Relacionamento com corridas, 1 usuário pode ter n corridas, 1:n

    }
}
