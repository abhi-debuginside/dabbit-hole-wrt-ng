using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using wRtaPi.Models;
using wRtaPi.Services;

namespace wRtaPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceController : ControllerBase
    {

        private ResourceService _resourceService;
        public ResourceController(ResourceService resourceService)
        {
            _resourceService = resourceService;
        }

        // GET: api/ResourceApi
        [HttpGet]
        public IEnumerable<WResource> Get()
        {
          return  _resourceService.GetAll();
        }

        // GET: api/ResourceApi/5
        [HttpGet("{id}", Name = "Get")]
        public WResource Get(string id)
        {
          return  _resourceService.GetById(id);
        }

        // POST: api/ResourceApi
        [HttpPost]
        public IActionResult Post(WResource res)
        {
            try
            {
                if (string.IsNullOrEmpty(res.Id))
                {
                    _resourceService.Create(res); 
                }
                else
                {
                    _resourceService.Update(res);
                }
            }
            catch (Exception ex)
            {
                return this.BadRequest();
            }
            return this.Ok();
        }

        // PUT: api/ResourceApi/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
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
