﻿using ChunabAPI.Models;
using ChunabAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

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
            var parties = new List<Party>() { new Party { Id = id, Name = "एमाले", Logo = "एमाले", Vote = "345345", Description = "नेपाल कम्युनिष्ट पार्टी (एकीकृत माक्र्सवादी–लेनिनवादी)को. विधान २०४९. (​नवौं राष्ट्रिय महाधिवेशन, २०७१ को संशोधन सहित)" }, new Party { Id = id, Name = "एमाले", Logo = "एमाले", Vote = "345345", Description = "नेपाल कम्युनिष्ट पार्टी (एकीकृत माक्र्सवादी–लेनिनवादी)को. विधान २०४९. (​नवौं राष्ट्रिय महाधिवेशन, २०७१ को संशोधन सहित)" }, new Party { Id = id, Name = "एमाले", Logo = "एमाले", Vote = "345345", Description = "नेपाल कम्युनिष्ट पार्टी (एकीकृत माक्र्सवादी–लेनिनवादी)को. विधान २०४९. (​नवौं राष्ट्रिय महाधिवेशन, २०७१ को संशोधन सहित)" } };
            var party = parties.Where(x => x.Id == id).FirstOrDefault();
            return Ok(party);

        }

        [HttpDelete("{id}")]
        public ActionResult<Party> DeleteParty(Guid id)
        {
           if(id==null){
               return BadRequest();
           }
            repository.DeleteParty(id);
            return Ok("Delete party successfully !!");

        }
             [HttpPost]
            public ActionResult<Party> CreateParty([FromBody] Party partyFromBody)
            {
                var party = new Party{
                    Id = Guid.NewGuid(),
                    Name = partyFromBody.Name,
                    Logo = partyFromBody.Logo,
                    Description = partyFromBody.Description,
                    Vote = partyFromBody.Vote

                };

                if(!ModelState.IsValid){
                throw new Exception("Invalid input");
                }

                repository.CreateParty(party);
                return Ok(party);

            }

        [HttpPut("{id}")]
        public ActionResult<Party> EditParty(Guid id, Party partyBody)
        {
            if(id == null){
                return BadRequest();
            }
            repository.EditParty(partyBody,id);
            return Ok(partyBody);

        }


    }
}
