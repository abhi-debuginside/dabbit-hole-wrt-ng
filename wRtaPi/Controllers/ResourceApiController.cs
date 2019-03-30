using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using wRtaPi.Models;
using wRtaPi.Services;

namespace wRtaPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceApiController : ControllerBase
    {

        private ResourceService _resourceService;
        public ResourceApiController(ResourceService resourceService)
        {
            _resourceService = resourceService;
        }

        // GET: api/ResourceApi
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var data = _resourceService.GetAll().Select(x => JsonConvert.SerializeObject(x));
            return data;
        }

        // GET: api/ResourceApi/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(long id)
        {
            var data = JsonConvert.SerializeObject(_resourceService.GetById(id));
            return data;
        }

        // POST: api/ResourceApi
        [HttpPost]
        public void Post([FromBody] WResource res)
        {
            _resourceService.Update(res);
        }

        // PUT: api/ResourceApi/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
           
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _resourceService.Remove(id);
        }

        [HttpGet("dummy")]
        public void AddDummy()
        {
            try
            {
                _resourceService.Dummy();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
