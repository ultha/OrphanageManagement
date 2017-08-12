using OrphanangeSystem1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrphanangeSystem1.Repository
{
    public interface IDonatorRepository
    {
        List<Donator> GetAll();
        int Insert(Donator donator);

    }
    public class DonatorRepository : IDonatorRepository
    {
        private OrphanageDbContext db = new OrphanageDbContext();
        public List<Donator> GetAll()
        {
            return db.Donators.ToList();
        }

        public int Insert(Donator donator)
        {
            db.Donators.Add(donator);
            return db.SaveChanges();
        }
    }
}