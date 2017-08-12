using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OrphanangeSystem1.Models
{
    public class OrphanageDbContext:DbContext
    {
        public OrphanageDbContext():base("connString")
        {

        }
        public DbSet<Orphan> Orphans { get; set; }
        public DbSet<Donator> Donators { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<AdoptorRequest> AdoptorRequests { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Admin> Admins { get; set; }


    }
}