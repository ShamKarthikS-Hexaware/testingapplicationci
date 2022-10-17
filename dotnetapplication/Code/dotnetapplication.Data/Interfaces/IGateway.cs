using MongoDB.Driver;

namespace dotnetapplication.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
