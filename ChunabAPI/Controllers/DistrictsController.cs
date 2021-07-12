using ChunabAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChunabAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<District>> GetDistricts()
        {
            var id = Guid.NewGuid();
            var districts = new List<District>() { new District { Id = id, Name = "Rolpa", Description = "Rolpa is ", Photo = "photos0", Voters = "234242342" }, new District { Id = id, Name = "Rolpa", Description = "Rolpa is ", Photo = "photos0", Voters = "234242342" }, new District { Id = id, Name = "Rolpa", Description = "Rolpa is ", Photo = "photos0", Voters = "234242342" } };
            return Ok(districts);
        }

        [HttpGet("{id}")]
        public ActionResult<District> GetDistrict(Guid id)
        {
            var districts = new List<District>() { new District { Id = id, Name = "Rolpa", Description = "Rolpa is ", Photo = "photos0", Voters = "234242342" }, new District { Id = id, Name = "Rolpa", Description = "Rolpa is ", Photo = "photos0", Voters = "234242342" }, new District { Id = id, Name = "Rolpa", Description = "Rolpa is ", Photo = "photos0", Voters = "234242342" } };
            var district = districts.Find(x => x.Id == id);
            return Ok(district);
        }

        [HttpDelete("{id}")]
        public ActionResult<District> DeleteDistrict(Guid id)
        {
            var districts = new List<District>() { new District { Id = id, Name = "Rolpa", Description = "Rolpa is ", Photo = "photos0", Voters = "234242342" }, new District { Id = id, Name = "Rolpa", Description = "Rolpa is ", Photo = "photos0", Voters = "234242342" }, new District { Id = id, Name = "Rolpa", Description = "Rolpa is ", Photo = "photos0", Voters = "234242342" } };
            var district = districts.Find(x => x.Id == id);
            var delteDistrict = districts.Remove(district);
            return Ok(delteDistrict);
        }

        [HttpDelete("{id}")]
        public ActionResult<District> DeleteDistrict(Guid id, District districtFromBody)
        {
            var districts = new List<District>() { new District { Id = id, Name = "Rolpa", Description = "Rolpa is ", Photo = "photos0", Voters = "234242342" }, new District { Id = id, Name = "Rolpa", Description = "Rolpa is ", Photo = "photos0", Voters = "234242342" }, new District { Id = id, Name = "Rolpa", Description = "Rolpa is ", Photo = "photos0", Voters = "234242342" } };
            var district = districts.Find(x => x.Id == id);

                district.Name  = districtFromBody.Name,
                district.Photo = districtFromBody.Photo;
                district.Voters = districtFromBody.Voters;
                district.Description = districtFromBody.Description;

            return Ok(districtFromBody);
        }
    }

}