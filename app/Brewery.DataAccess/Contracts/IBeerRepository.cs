using Brewery.Domain;
using System;
using System.Collections.Generic;

namespace Brewery.DataAccess.Contracts
{
    public interface IBeerRepository : IDisposable
    {
        /// <summary>
        /// Inserts the provided Beer object into database.
        /// </summary>
        /// <param name="beer">Beer object that needs to be inserted.</param>
        /// <returns>Id of the inserted Beer object.</returns>
        int Create(Beer beer);

        /// <summary>
        /// Returns all Beer objects inside the database.
        /// </summary>
        /// <returns>IEnumerable of all beer objects inside the database.</returns>
        IEnumerable<Beer> GetAll();
        /// <summary>
        /// Gets the Beer object by it's id.
        /// </summary>
        /// <param name="id">Id of the wanted beer.</param>
        /// <returns>Beer object if found, null if not.</returns>
        Beer GetById(int id);
        /// <summary>
        /// Gets all the Beer objects that match the provided beer name.
        /// </summary>
        /// <param name="name">Name of the wanted beer.</param>
        /// <returns>IEnumerable of all beer objects which name contains the provided name.</returns>
        IEnumerable<Beer> GetByName(string name);
        /// <summary>
        /// Gets all the Beer objects that match the provided alcohol percentage.
        /// </summary>
        /// <param name="alcoholPercentage">Alcohol percentage of the wanted beer.</param>
        /// <returns>IEnumerable of all beer objects that match the provided alcohol percentage.</returns>
        IEnumerable<Beer> GetByAlcoholPercentage(double alcoholPercentage);
        /// <summary>
        /// Gets all the Beer objects that match the provided ibu quotient.
        /// </summary>
        /// <param name="ibu">IBU quotient of the wanted beer.</param>
        /// <returns>IEnumerable of all beer objects that match the provided ibu quotient.</returns>
        IEnumerable<Beer> GetByIBU(double ibu);
        /// <summary>
        /// Gets all the beers that belong to the provided beer type.
        /// </summary>
        /// <param name="beerTypeId">Id of the wanted beer type.</param>
        /// <returns>IEnumerable of all beer objects inside the wanted beer type.</returns>
        IEnumerable<Beer> GetByBeerTypeId(int beerTypeId);
        /// <summary>
        /// Gets all the Beer objects that match the provided available quantity.
        /// </summary>
        /// <param name="quantity">Available quantity of the wanted beer.</param>
        /// <returns>IEnumerable of all beer objects that match the provided quantity value.</returns>
        IEnumerable<Beer> GetByQuantity(int quantity);
        /// <summary>
        /// Gets all the beers that belong to the provided brewery.
        /// </summary>
        /// <param name="breweryId">Id of the wanted brewery.</param>
        /// <returns>IEnumerable of all beer objects that belong to the provided brewery.</returns>
        IEnumerable<Beer> GetByBreweryId(int breweryId);
        /// <summary>
        /// Gets the Beer object that matches the provided filter parameters.
        /// </summary>
        /// <param name="name">Name filter for the wanted beer.</param>
        /// <param name="alcoholPercentage">Alcohol percentage filter for the wanted beer.</param>
        /// <param name="ibu">IBU quotient filter for the wanted beer.</param>
        /// <param name="beerTypeId">Beer type of the wanted beers.</param>
        /// <param name="quantity">Quantity of the wanted beers.</param>
        /// <param name="breweryId">Brewery id of the wanted beers.</param>
        /// <returns>IEnumerable of all Beer objects that match the criteria.</returns>
        IEnumerable<Beer> FindByFilters(string name,
            double? alcoholPercentage = null,
            double? ibu = null,
            int? beerTypeId = null,
            int? quantity = null,
            int? breweryId = null);

        /// <summary>
        /// Updates all fields of the provided Beer object.
        /// </summary>
        /// <param name="beer">Beer object that needs to be updated.</param>
        /// <returns>Id of the updated Beer object.</returns>
        int Update(Beer beer);

        /// <summary>
        /// Finds the beer by provided id and removes it from the database.
        /// </summary>
        /// <param name="id">Id of the beer that needs to be removed.</param>
        void Delete(int id);
    }
}
