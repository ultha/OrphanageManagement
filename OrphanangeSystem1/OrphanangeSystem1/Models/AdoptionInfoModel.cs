using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrphanangeSystem1.Models
{
    public class AdoptionInfo
    {
        public int Id { get; set; }
        public AdoptorRequest AdoptorRequest { get; set; }
        public int AdoptorRequestId { get; set; }
        public Orphan Orphan { get; set; }
        public int OrphanId { get; set; }
        public Supervisor Supervisor { get; set; }
        public int SupervisorId { get; set; }
    }
}