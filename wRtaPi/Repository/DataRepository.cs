using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wRtaPi.Models;

namespace wRtaPi.Repository
{
    public class DataRepository
    {
        private readonly IMongoCollection<WResource> _resourceModel;
        public DataRepository(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("ResourceDb"));
            var database = client.GetDatabase("WResourceDb");
            _resourceModel = database.GetCollection<WResource>("WResource");
        }

        public List<WResource> Get()
        {
            return _resourceModel.Find(x => true).ToList();
        }

        public WResource Get(long id)
        {
            return _resourceModel.Find<WResource>(res => res.Id == id).FirstOrDefault();
        }

        public WResource Create(WResource resource)
        {
            _resourceModel.InsertOne(resource);
            return resource;
        }

        public void Update(WResource resource)
        {
            _resourceModel.ReplaceOne(res => res.Id == resource.Id, resource);
        }

        public void Remove(WResource resource)
        {
            _resourceModel.DeleteOne(res => res.Id == resource.Id);
        }

        public void Remove(long id)
        {
            _resourceModel.DeleteOne(res => res.Id == id);
        }
    }
}
