using Brewery.BusinessLogic.Contracts;
using Brewery.BusinessLogic.Managers;
using Brewery.Presentation.MapperProfiles;
using Brewery.Presentation.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Brewery.Presentation.Controllers
{
    public class BeerTypeController : ApiController
    {
        private IBeerTypeManager _beerTypeManager;
        private BeerTypeMapperProfile _beerTypeMapperProfile;

        public BeerTypeController()
        {
            _beerTypeManager = new BeerTypeManager();
            _beerTypeMapperProfile = new BeerTypeMapperProfile();
        }

        [HttpGet]
        [Route("api/vrste_piva")]
        public List<BeerTypeViewmodel> GetBeers()
        {
            return _beerTypeMapperProfile.MapRange(_beerTypeManager.GetAll().ToList());
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing)
                _beerTypeManager.Dispose();
        }
    }
}
