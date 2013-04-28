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
            return storeRepository.All.Take(10).ToList();
        }

        // GET api/values/5
        public Store  Get(int id)
        {
            return storeRepository.Find(id);
        }

        // Get api/getstore/closest/geolocation
        [HttpGet]
        [ActionName("Closest")]
        public List<Store> Closest(string geolocation)
        {
            if(!string.IsNullOrEmpty(geolocation))
            {
                double lat1 = Convert.ToDouble(geolocation.Split(',')[0]);
                double lon1 = Convert.ToDouble(geolocation.Split(',')[1]);
                return storeRepository.GetClosest(lat1, lon1);
            }
            return null;

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