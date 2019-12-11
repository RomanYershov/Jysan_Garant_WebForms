using System;
using System.Collections.Generic;
using System.Text;
using Jysan.DAL.Abstractions;

namespace Jysan.DAL.Entities
{
    public class Individual : Contragent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }

       public Individual(): base() { }
    }
}
