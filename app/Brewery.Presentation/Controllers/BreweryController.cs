using Brewery.BusinessLogic.Contracts;
using Brewery.BusinessLogic.Managers;
using Brewery.Presentation.MapperProfiles;
using Brewery.Presentation.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Brewery.Presentation.Controllers
{
    public class BreweryController : ApiController
    {
        private IBreweryManager _breweryManager;
        private BreweryMapperProfile _breweryMapperProfile;

        public BreweryController()
        {
            _breweryManager = new BreweryManager();
            _breweryMapperProfile = new BreweryMapperProfile();
        }

        [HttpGet]
        [Route("api/pivare")]
        public List<BreweryViewmodel> GetBreweries()
        {
            return _breweryMapperProfile.MapRange(_breweryManager.GetAll().ToList());
        }

        [HttpGet]
        [Route("api/pivare/{id}")]
        public BreweryViewmodel GetBreweryById(int id)
        {
            return _breweryMapperProfile.Map(_breweryManager.GetById(id));
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing)
                _breweryManager.Dispose();
        }
    }
}
