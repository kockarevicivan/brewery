using Brewery.BusinessLogic.Contracts;
using System.Collections.Generic;
using Brewery.DataAccess.Contracts;
using Brewery.DataAccess.Repositories;

namespace Brewery.BusinessLogic.Managers
{
    public class BreweryManager : IBreweryManager
    {
        private IBreweryRepository _repository;

        public BreweryManager()
        {
            _repository = new BreweryRepository();
        }

        //<inheritdoc />
        public int Create(Domain.Brewery brewery)
        {
            return _repository.Create(brewery);
        }

        //<inheritdoc />
        public IEnumerable<Domain.Brewery> FindByFilters(string name, string pin, string state)
        {
            return _repository.FindByFilters(name, pin, state);
        }

        //<inheritdoc />
        public IEnumerable<Domain.Brewery> GetAll()
        {
            return _repository.GetAll();
        }

        //<inheritdoc />
        public Domain.Brewery GetById(int id)
        {
            return _repository.GetById(id);
        }

        //<inheritdoc />
        public IEnumerable<Domain.Brewery> GetByName(string name)
        {
            return _repository.GetByName(name);
        }

        //<inheritdoc />
        public IEnumerable<Domain.Brewery> GetByPIN(string pin)
        {
            return _repository.GetByPIN(pin);
        }

        //<inheritdoc />
        public IEnumerable<Domain.Brewery> GetByState(string state)
        {
            return _repository.GetByState(state);
        }

        //<inheritdoc />
        public int Update(Domain.Brewery brewery)
        {
            return _repository.Update(brewery);
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
