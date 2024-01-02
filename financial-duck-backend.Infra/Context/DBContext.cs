using MongoDB.Driver;
namespace financial_duck_backend.Infra.Context;
public sealed class DBContext
{
    public readonly IMongoCollection<object> _randomCollection;
    public DBContext()
    {
        var mongoClient = new MongoClient("mongodb://localhost:27017");
        var mongoDatabase = mongoClient.GetDatabase("financial-duck");

        _randomCollection = mongoDatabase.GetCollection<object>("categories");
    }
}
