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
            var party = context.Parties.SingleOrDefault(party => party.Id == id);
            context.Parties.Remove(party);
            context.SaveChanges();
        }

        public void EditParty(Party party, Guid id)
        {
            try
            {
                var partyInDb = context.Parties.Find(id);
                partyInDb.Id = id;
                partyInDb.Name = party.Name;
                partyInDb.Description = party.Description;
                partyInDb.Logo = party.Logo;
                partyInDb.Vote = party.Vote;

                if (partyInDb is null)
                {
                    throw new Exception("Not found");
                }

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
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