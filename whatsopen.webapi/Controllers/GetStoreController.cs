using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using whatsopen.webapi.Models;

namespace whatsopen.webapi.Controllers
{
    public class GetStoreController : ApiController
    {

        private readonly IStoreRepository storeRepository;

		// If you are using Dependency Injection, you can delete the following constructor
        public GetStoreController() : this(new StoreRepository())
        {
        }

        public GetStoreController(IStoreRepository storeRepository)
        {
			this.storeRepository = storeRepository;
        }
        // GET api/values
        public List<Store> Get()
        {
            return storeRepository.All.ToList();
        }

        // GET api/values/5
        public Store  Get(int id)
        {
            return storeRepository.Find(id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}