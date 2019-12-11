using System;
using System.Collections.Generic;
using System.Text;
using Jysan.DAL.Abstractions;

namespace Jysan.DAL.Entities
{
    public class LegalEntity : Contragent
    {
        public string Name { get; set; }
        public virtual List<Individual> Individuals { get; set; }

        public LegalEntity() : base()
        {
           
        }

    }
}
