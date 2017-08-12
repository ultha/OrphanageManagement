using OrphanangeSystem1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrphanangeSystem1.Repository
{
    public interface IOrphanRepository
    {
        List<Orphan> GetAll();
        int Insert(Orphan orphan);
    }
    public class OrphanRepository : IOrphanRepository
    {
        private OrphanageDbContext db = new OrphanageDbContext();
        public List<Orphan> GetAll()
        {
            return db.Orphans.ToList();
        }

        public int Insert(Orphan orphan)
        {
            db.Orphans.Add(orphan);
            return db.SaveChanges();

        }
    }
}