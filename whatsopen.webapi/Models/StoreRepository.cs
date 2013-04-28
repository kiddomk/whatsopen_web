using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace whatsopen.webapi.Models
{ 
    public class StoreRepository : IStoreRepository
    {
        whatsopenwebapiContext context = new whatsopenwebapiContext();

        public IQueryable<Store> All
        {
            get { return context.Stores; }
        }

        public IQueryable<Store> AllIncluding(params Expression<Func<Store, object>>[] includeProperties)
        {
            IQueryable<Store> query = context.Stores;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Store Find(int id)
        {
            return context.Stores.Find(id);
        }

        public void InsertOrUpdate(Store store)
        {
            if (store.Id == default(int)) {
                // New entity
                if (context.Stores.FirstOrDefault(n => n.VenueUrl == store.VenueUrl) == null)
                {
                    context.Stores.Add(store);
                }
            } else {
                // Existing entity
                context.Entry(store).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var store = context.Stores.Find(id);
            context.Stores.Remove(store);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public List<Store> GetClosest(double lat1, double lon1)
        {
            var storelist = (from store in All
                             select new {id = store.Id, lat2 = store.Latitude, lon2 = store.Longitude});

            var newStoreList = new List<Store>();
            foreach (var store in storelist)
            {
              var distance =  GetDistance(lat1, lon1, store.lat2, store.lon2);
                var newStore = new Store
                                   {
                                       Id = store.id,
                                       Distance = (decimal?) Convert.ToDouble(distance)
                                   };
                newStoreList.Add(newStore);
            }
            newStoreList = newStoreList.OrderBy(s => s.Distance).Take(10).ToList();
            List<int> storeIds = newStoreList.Select(s => s.Id).ToList();
            return All.Where(s => storeIds.Contains(s.Id)).ToList();

        }

        public void Dispose() 
        {
            context.Dispose();
        }

        public static double GetDistance(double Lat1,
                                  double Long1, double Lat2, double Long2)
        {
            /*
                The Haversine formula according to Dr. Math.
                http://mathforum.org/library/drmath/view/51879.html
                
                dlon = lon2 - lon1
                dlat = lat2 - lat1
                a = (sin(dlat/2))^2 + cos(lat1) * cos(lat2) * (sin(dlon/2))^2
                c = 2 * atan2(sqrt(a), sqrt(1-a)) 
                d = R * c
                
                Where
                    * dlon is the change in longitude
                    * dlat is the change in latitude
                    * c is the great circle distance in Radians.
                    * R is the radius of a spherical Earth.
                    * The locations of the two points in 
                        spherical coordinates (longitude and 
                        latitude) are lon1,lat1 and lon2, lat2.
            */
            double dDistance = Double.MinValue;
            double dLat1InRad = Lat1 * (Math.PI / 180.0);
            double dLong1InRad = Long1 * (Math.PI / 180.0);
            double dLat2InRad = Lat2 * (Math.PI / 180.0);
            double dLong2InRad = Long2 * (Math.PI / 180.0);

            double dLongitude = dLong2InRad - dLong1InRad;
            double dLatitude = dLat2InRad - dLat1InRad;

            // Intermediate result a.
            double a = Math.Pow(Math.Sin(dLatitude / 2.0), 2.0) +
                       Math.Cos(dLat1InRad) * Math.Cos(dLat2InRad) *
                       Math.Pow(Math.Sin(dLongitude / 2.0), 2.0);

            // Intermediate result c (great circle distance in Radians).
            double c = 2.0 * Math.Asin(Math.Sqrt(a));

            // Distance.
            // const Double kEarthRadiusMiles = 3956.0;
            const Double kEarthRadiusKms = 6376.5;
            dDistance = kEarthRadiusKms * c;

            return dDistance;
        }
    }

    public interface IStoreRepository : IDisposable
    {
        IQueryable<Store> All { get; }
        IQueryable<Store> AllIncluding(params Expression<Func<Store, object>>[] includeProperties);
        Store Find(int id);
        void InsertOrUpdate(Store store);
        void Delete(int id);
        void Save();
        List<Store> GetClosest(double lat1, double lon1);
    }
}