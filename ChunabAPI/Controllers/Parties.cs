using ChunabAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChunabAPI.Controllers
{
    [Route("api/[controller]")]
    public class Parties : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<Party>> GeAllParties()
        {
            Guid id = Guid.NewGuid();
            var parties = new List<Party>() { new Party { Id = id,Name = "एमाले", Logo="एमाले", Vote = "345345", Description= "नेपाल कम्युनिष्ट पार्टी (एकीकृत माक्र्सवादी–लेनिनवादी)को. विधान २०४९. (​नवौं राष्ट्रिय महाधिवेशन, २०७१ को संशोधन सहित)" }, new Party { Id = id, Name = "एमाले", Logo = "एमाले", Vote = "345345", Description = "नेपाल कम्युनिष्ट पार्टी (एकीकृत माक्र्सवादी–लेनिनवादी)को. विधान २०४९. (​नवौं राष्ट्रिय महाधिवेशन, २०७१ को संशोधन सहित)" }, new Party { Id = id, Name = "एमाले", Logo = "एमाले", Vote = "345345", Description = "नेपाल कम्युनिष्ट पार्टी (एकीकृत माक्र्सवादी–लेनिनवादी)को. विधान २०४९. (​नवौं राष्ट्रिय महाधिवेशन, २०७१ को संशोधन सहित)" } };
            return Ok(parties);
        }

        [HttpGet("{id}")]
        public ActionResult<Party> GetParty(Guid id)
        {
            var parties = new List<Party>() { new Party { Id = id, Name = "एमाले", Logo = "एमाले", Vote = "345345", Description = "नेपाल कम्युनिष्ट पार्टी (एकीकृत माक्र्सवादी–लेनिनवादी)को. विधान २०४९. (​नवौं राष्ट्रिय महाधिवेशन, २०७१ को संशोधन सहित)" }, new Party { Id = id, Name = "एमाले", Logo = "एमाले", Vote = "345345", Description = "नेपाल कम्युनिष्ट पार्टी (एकीकृत माक्र्सवादी–लेनिनवादी)को. विधान २०४९. (​नवौं राष्ट्रिय महाधिवेशन, २०७१ को संशोधन सहित)" }, new Party { Id = id, Name = "एमाले", Logo = "एमाले", Vote = "345345", Description = "नेपाल कम्युनिष्ट पार्टी (एकीकृत माक्र्सवादी–लेनिनवादी)को. विधान २०४९. (​नवौं राष्ट्रिय महाधिवेशन, २०७१ को संशोधन सहित)" } };
            var party = parties.Where(x=>x.Id == id).FirstOrDefault();
            return Ok(party);

        }

        [HttpDelete("{id}")]
        public ActionResult<Party> DeleteParty(Guid id)
        {
            var parties = new List<Party>() { new Party { Id = id, Name = "एमाले", Logo = "एमाले", Vote = "345345", Description = "नेपाल कम्युनिष्ट पार्टी (एकीकृत माक्र्सवादी–लेनिनवादी)को. विधान २०४९. (​नवौं राष्ट्रिय महाधिवेशन, २०७१ को संशोधन सहित)" }, new Party { Id = id, Name = "एमाले", Logo = "एमाले", Vote = "345345", Description = "नेपाल कम्युनिष्ट पार्टी (एकीकृत माक्र्सवादी–लेनिनवादी)को. विधान २०४९. (​नवौं राष्ट्रिय महाधिवेशन, २०७१ को संशोधन सहित)" }, new Party { Id = id, Name = "एमाले", Logo = "एमाले", Vote = "345345", Description = "नेपाल कम्युनिष्ट पार्टी (एकीकृत माक्र्सवादी–लेनिनवादी)को. विधान २०४९. (​नवौं राष्ट्रिय महाधिवेशन, २०७१ को संशोधन सहित)" } };
            var party = parties.Where(x => x.Id == id).FirstOrDefault();
            var remmovedParty = parties.Remove(party);
            return Ok(remmovedParty);

        }
          [HttpPut("{id}")]
        public ActionResult<Party> EditParty(Guid id, Party partyBody)
        {
            var parties = new List<Party>() { new Party { Id = id, Name = "एमाले", Logo = "एमाले", Vote = "345345", Description = "नेपाल कम्युनिष्ट पार्टी (एकीकृत माक्र्सवादी–लेनिनवादी)को. विधान २०४९. (​नवौं राष्ट्रिय महाधिवेशन, २०७१ को संशोधन सहित)" }, new Party { Id = id, Name = "एमाले", Logo = "एमाले", Vote = "345345", Description = "नेपाल कम्युनिष्ट पार्टी (एकीकृत माक्र्सवादी–लेनिनवादी)को. विधान २०४९. (​नवौं राष्ट्रिय महाधिवेशन, २०७१ को संशोधन सहित)" }, new Party { Id = id, Name = "एमाले", Logo = "एमाले", Vote = "345345", Description = "नेपाल कम्युनिष्ट पार्टी (एकीकृत माक्र्सवादी–लेनिनवादी)को. विधान २०४९. (​नवौं राष्ट्रिय महाधिवेशन, २०७१ को संशोधन सहित)" } };
            var party = parties.Where(x => x.Id == id).FirstOrDefault();
            party.Name = partyBody.Name;
            party.Description = partyBody.Description;
            party.Logo = partyBody.Logo;

            return Ok(new Party
            {
             Name = partyBody.Name,
               Description = partyBody.Description,
               Logo = partyBody.Logo
            });

        }


    }
}
