using ChunabAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChunabAPI.Repository
{
    public interface IPartyRepository
    {
     public Task<IEnumerable<Party>> GetParties(); 
     public Task<Party> GetParty(Guid id); 
     public void CreateParty(Party party);
     public void EditParty(Party party, Guid id);
     public void DeleteParty(Guid id);
    }
}