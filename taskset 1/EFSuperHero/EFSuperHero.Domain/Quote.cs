using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFSuperHero.Domain
{
    public class Quote
    {
        public int Id { get; set; }
        public String Text { get; set; }
        public QuoteStyle? Quality { get; set; }

        [ForeignKey("SuperHero")]
        public int SuperHeroRefId { get; set; }
        public SuperHero SuperHero { get; set; }    
    }
}
