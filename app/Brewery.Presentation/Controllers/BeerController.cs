using Brewery.BusinessLogic.Contracts;
using Brewery.BusinessLogic.Managers;
using Brewery.Commons;
using Brewery.Domain;
using Brewery.Presentation.MapperProfiles;
using Brewery.Presentation.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Brewery.Presentation.Controllers
{
    public class BeerController : ApiController
    {
        private IBeerManager _beerManager;
        private BeerMapperProfile _beerMapperProfile;

        public BeerController()
        {
            _beerManager = new BeerManager();
            _beerMapperProfile = new BeerMapperProfile();
        }
        
        [HttpGet]
        [Route("api/piva")]
        public List<BeerViewmodel> GetBeers(int page)
        {
            //Page 1 is the minimum
            return _beerMapperProfile.MapRange(
                _beerManager.GetAll()
                    .Skip((page - 1) * Constants.BeersPerPage)
                    .Take(Constants.BeersPerPage)
                    .ToList());
        }

        [HttpGet]
        [Route("api/piva/{id}")]
        public BeerViewmodel GetBeerById(int id)
        {
            return _beerMapperProfile.Map(_beerManager.GetById(id));
        }

        [HttpPost]
        [Route("api/piva")]
        public int InsertBeer([FromBody]BeerViewmodel beer)
        {
            return _beerManager.Create(_beerMapperProfile.ReverseMap(beer));
        }

        [HttpPut]
        [Route("api/piva/{id}")]
        public int UpdateBeer([FromBody]BeerViewmodel beer)
        {
            return _beerManager.Update(_beerMapperProfile.ReverseMap(beer));
        }

        [HttpDelete]
        [Route("api/piva/{id}")]
        public int DeleteBeer(int id)
        {
            _beerManager.Delete(id);

            return 200;//200 OK - Change if needed (crash or something else).
        }

        [HttpGet]
        [Route("api/pivare/{id_pivare}/piva")]
        public List<BeerViewmodel> GetBeerByBreweryId(int id_pivare)
        {
            return _beerMapperProfile.MapRange(_beerManager.GetByBreweryId(id_pivare).ToList());
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing)
                _beerManager.Dispose();
        }
    }
}
