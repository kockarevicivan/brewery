﻿using Brewery.Domain;
using System;
using System.Collections.Generic;

namespace Brewery.BusinessLogic.Contracts
{
    public interface IBeerTypeManager : IDisposable
    {
        /// <summary>
        /// Inserts the provided BeerType object into repository.
        /// </summary>
        /// <param name="beerType">BeerType object that needs to be inserted.</param>
        /// <returns>Id of the inserted BeerType object.</returns>
        int Create(BeerType beerType);

        /// <summary>
        /// Returns all BeerType objects inside the repository.
        /// </summary>
        /// <returns>IEnumerable of all BeerType objects inside the repository.</returns>
        IEnumerable<BeerType> GetAll();
        /// <summary>
        /// Gets the BeerType object by it's id.
        /// </summary>
        /// <param name="id">Id of the wanted beer type.</param>
        /// <returns>BeerType object if found, null if not.</returns>
        BeerType GetById(int id);

        /// <summary>
        /// Updates all fields of the provided BeerType object.
        /// </summary>
        /// <param name="beerType">BeerType object that needs to be updated.</param>
        /// <returns>Id of the updated BeerType object.</returns>
        int Update(BeerType beerType);

        /// <summary>
        /// Finds the beer type by provided id and removes it from the repository.
        /// </summary>
        /// <param name="id">Id of the beer type that needs to be removed.</param>
        void Delete(int id);
    }
}
