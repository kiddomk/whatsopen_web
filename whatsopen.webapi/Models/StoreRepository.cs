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

        public void Dispose() 
        {
            context.Dispose();
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
    }
}