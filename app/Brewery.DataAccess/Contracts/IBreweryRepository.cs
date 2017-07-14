using System;
using System.Collections.Generic;

namespace Brewery.DataAccess.Contracts
{
    public interface IBreweryRepository : IDisposable
    {
        /// <summary>
        /// Inserts the provided Brewery object into database.
        /// </summary>
        /// <param name="brewery">Brewery object that needs to be inserted.</param>
        /// <returns>Id of the inserted Brewery object.</returns>
        int Create(Domain.Brewery brewery);

        /// <summary>
        /// Returns all Brewery objects inside the database.
        /// </summary>
        /// <returns>IEnumerable of all Brewery objects inside the database.</returns>
        IEnumerable<Domain.Brewery> GetAll();
        /// <summary>
        /// Gets the Brewery object by it's id.
        /// </summary>
        /// <param name="id">Id of the wanted brewery.</param>
        /// <returns>Brewery object if found, null if not.</returns>
        Domain.Brewery GetById(int id);
        /// <summary>
        /// Gets all the Brewery objects that match the provided name.
        /// </summary>
        /// <param name="name">Name of the wanted brewery.</param>
        /// <returns>Beer object if found, null if not.</returns>
        IEnumerable<Domain.Brewery> GetByName(string name);
        /// <summary>
        /// Gets all the Brewery objects that match the provided pin.
        /// </summary>
        /// <param name="pin">PIN of the wanted brewery.</param>
        /// <returns>Beer object if found, null if not.</returns>
        IEnumerable<Domain.Brewery> GetByPIN(string pin);
        /// <summary>
        /// Gets all the Brewery objects that match the provided state.
        /// </summary>
        /// <param name="state">State of the wanted brewery.</param>
        /// <returns>Beer object if found, null if not.</returns>
        IEnumerable<Domain.Brewery> GetByState(string state);
        /// <summary>
        /// Gets the Brewery object that matches the provided filter parameters.
        /// </summary>
        /// <param name="name">Name filter for the wanted brewery.</param>
        /// <param name="pin">PIN filter for the wanted brewery.</param>
        /// <param name="state">State filter for the wanted brewery.</param>
        /// <returns>IEnumerable of all Brewery objects that match the criteria.</returns>
        IEnumerable<Domain.Brewery> FindByFilters(string name, string pin, string state);

        /// <summary>
        /// Updates all fields of the provided Brewery object.
        /// </summary>
        /// <param name="brewery">Brewery object that needs to be updated.</param>
        /// <returns>Id of the updated Brewery object.</returns>
        int Update(Domain.Brewery brewery);

        /// <summary>
        /// Finds the brewery by provided id and removes it from the database.
        /// </summary>
        /// <param name="id">Id of the brewery that needs to be removed.</param>
        void Delete(int id);
    }
}
