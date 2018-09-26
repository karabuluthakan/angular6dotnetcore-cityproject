using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityProject.API.Data;
using CityProject.API.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityProject.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Cities")]
    public class CitiesController : Controller
    {
        private IAppRepository _appRepository;

        public CitiesController(IAppRepository appRepository)
        {
            _appRepository = appRepository;
        }

        public ActionResult GetCities()
        {
            var cities = _appRepository.GetCities()
                .Select(c=>new CityForListDto
                {
                    Description = c.Description , Name = c.Name, Id = c.Id, PhotoUrl = c.Photos.FirstOrDefault(p=>p.IsMain==true).Url
                }).ToList();
            return Ok(cities);
        }
    }
}