using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wRtaPi.Models;
using wRtaPi.Repository;

namespace wRtaPi.Services
{
    public class ResourceService
    {
        private DataRepository _dataRepository;
        public ResourceService(DataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public List<WResource> GetAll()
        {
            return _dataRepository.Get();
        }
        public WResource GetById(long id)
        {
            return _dataRepository.Get(id);
        }

        public WResource Create(WResource res)
        {
            _dataRepository.Create(res);
            return res;
        }

        public void Update(WResource res)
        {
            _dataRepository.Update(res);
        }

        public void Remove(WResource res)
        {
            _dataRepository.Remove(res);
        }

        public void Remove(long id)
        {
            _dataRepository.Remove(id);
        }

        internal void Dummy()
        {
            var res = new WResource()
            {
                Id = 1122,
                Description = "testdesc",
                Name = "test",
                Longitude = "123.22",
                Latitude = "222.32"
            };
            Create(res);
        }
    }
}
