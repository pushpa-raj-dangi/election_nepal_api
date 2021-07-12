using ChunabAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChunabAPI.Controllers
{
    [Route("api/[controller]")]
    public class CandidatesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Candidate>> GetCandidates()
        {
            var id = Guid.NewGuid();
            List<Candidate> candidates = new List<Candidate>() { new Candidate { Id = id, Address = "Kathmandu", Description = "Description", Name = "Lila Giri" } };
            return Ok(candidates);
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Candidate>> GetCandidate(Guid id)
        {
          
            List<Candidate> candidates = new List<Candidate>() { new Candidate { Id = id, Address = "Kathmandu", Description = "Description", Name = "Lila Giri" } };
            var candidate = candidates.Where(x=>x.Id == id);
            return Ok(candidate);
        }

        [HttpDelete("{id}")]
        public ActionResult<Candidate> DeleteCandidate(Guid id)
        {

            List<Candidate> candidates = new List<Candidate>() { new Candidate { Id = id, Address = "Kathmandu", Description = "Description", Name = "Lila Giri" } };
            var candidate = candidates.Where(x => x.Id == id).FirstOrDefault();
            var deleteCandidate = candidates.Remove(candidate);
            return Ok(deleteCandidate);
        }

        [HttpPut("{id}")]
        public ActionResult<Candidate> EditCandidate(Guid id, Candidate candidateFromBody)
        {

            List<Candidate> candidates = new List<Candidate>() { new Candidate { Id = id, Address = "Kathmandu", Description = "Description", Name = "Lila Giri" } };
            var candidate = candidates.Where(x => x.Id == id).FirstOrDefault();
            candidate.Name = candidateFromBody.Name;
            candidate.Description  = candidateFromBody.Description;
            candidate.Address = candidateFromBody.Address;
            return Ok(candidateFromBody);
        }


    }
}
