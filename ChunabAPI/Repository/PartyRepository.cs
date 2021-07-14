using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChunabAPI.Data;
using ChunabAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ChunabAPI.Repository
{
    public class PartyRepository : IPartyRepository
    {
        private readonly ApplicationDbContext context;
        public PartyRepository(ApplicationDbContext context)
        {
            this.context = context;

        }
        public void CreateParty(Party party)
        {
            context.Parties.Add(party);
            context.SaveChanges();
        }

        public void DeleteParty(Guid id)
        {
            var party = context.Parties.SingleOrDefault(party=>party.Id == id);
            context.Parties.Remove(party);
        }

        public void EditParty(Party party, Guid id)
        {
           var partyInDb = context.Parties.FindAsync(id);
          context.Update(party);
          context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Party>> GetParties()
        {
            return await context.Parties.ToListAsync();
        }

        public async Task<Party> GetParty(Guid id)
        {
          return await context.Parties.FindAsync(id);
        }
    }
}