using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFSuperHero.Domain
{
    public class RealIdentity
    {
        public int Id { get; set; }
        public string RealName { get; set; }

        [ForeignKey("SuperHero")]
        public int SuperHeroRefId { get; set; }
        public SuperHero SuperHero { get; set; }
    }
}
