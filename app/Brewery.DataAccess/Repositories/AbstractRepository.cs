using Brewery.Domain;
using System;

namespace Brewery.DataAccess.Repositories
{
    public abstract class AbstractRepository : IDisposable
    {
        protected BreweryDBEntities context;

        public AbstractRepository()
        {
            context = new BreweryDBEntities();
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
                context.Dispose();
        }
    }
}
