using System;
using System.Collections.Generic;
using ChunabAPI.Models;
using ChunabAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ChunabAPI.Controllers
{
    [Route("api/[controller]")]
    public class PartiesController : ControllerBase
    {
        private readonly IPartyRepository repository;

        public PartiesController(IPartyRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Party>> GeAllParties()
        {
            return Ok(repository.GetParties());
        }

        [HttpGet("{id}")]
        public ActionResult<Party> GetParty(Guid id)
        {

            return Ok(repository.GetParty(id));

        }

        [HttpDelete("{id}")]
        public ActionResult<Party> DeleteParty(Guid id)
        {

            repository.DeleteParty(id);
            return Ok("Delete party successfully !!");

        }
        [HttpPost]
        public ActionResult<Party> CreateParty([FromBody] Party partyFromBody)
        {
            var party = new Party
            {
                Id = Guid.NewGuid(),
                Name = partyFromBody.Name,
                Logo = partyFromBody.Logo,
                Description = partyFromBody.Description,
                Vote = partyFromBody.Vote

            };

            if (!ModelState.IsValid)
            {
                throw new Exception("Invalid input");
            }

            repository.CreateParty(party);
            return Ok(party);

        }

        [HttpPut("{id}")]
        public ActionResult<Party> EditParty(Guid id, [FromBody] Party partyBody)
        {
            var party = new Party
            {
                Id = id,
                Name = partyBody.Name,
                Logo = partyBody.Logo,
                Description = partyBody.Description,
                Vote = partyBody.Vote
            };
            repository.EditParty(party, id);
            return Ok(partyBody);

        }


    }
}
