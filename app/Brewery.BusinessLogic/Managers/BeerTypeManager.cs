using Brewery.BusinessLogic.Contracts;
using System.Collections.Generic;
using Brewery.Domain;
using Brewery.DataAccess.Contracts;
using Brewery.DataAccess.Repositories;

namespace Brewery.BusinessLogic.Managers
{
    public class BeerTypeManager : IBeerTypeManager
    {
        private IBeerTypeRepository _repository;

        public BeerTypeManager()
        {
            _repository = new BeerTypeRepository();
        }

        //<inheritdoc />
        public int Create(BeerType beerType)
        {
            return _repository.Create(beerType);
        }

        //<inheritdoc />
        public IEnumerable<BeerType> GetAll()
        {
            return _repository.GetAll();
        }

        //<inheritdoc />
        public BeerType GetById(int id)
        {
            return _repository.GetById(id);
        }

        //<inheritdoc />
        public int Update(BeerType beerType)
        {
            return _repository.Update(beerType);
        }

        //<inheritdoc />
        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
                _repository?.Dispose();
        }
    }
}
