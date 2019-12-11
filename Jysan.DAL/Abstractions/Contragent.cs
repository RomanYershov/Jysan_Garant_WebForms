using System;
using System.Collections.Generic;
using System.Text;

namespace Jysan.DAL.Abstractions
{
    public class Contragent : Entity        
    {
        public string Iin { get; set; }
        public DateTime CreationDate { get; set; }
        public Contragent() => CreationDate = DateTime.Now;
    }
}
