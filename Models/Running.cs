using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace RunningReviewApp.Models
{
    public class Running
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }
        public float Distance { get; set; }
        public TimeSpan Time { get; set; }
        public TrainningType TrainningType { get; set; }
        public DateTime Date { get; set; }

        public int UserId { get; set; } // Chave estrangeira
        public User User { get; set; } // Relação de referência
        public float Pace => (float)Time.TotalMinutes / Distance;

    }

    public enum TrainningType
    {
        Tiro,
        Longo,
        Esteira,
        Regenerativo
    }
}
