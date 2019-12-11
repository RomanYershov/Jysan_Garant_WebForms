using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jysan.BLL.Abstractions;

namespace Jysan.BLL.Models
{
    [Serializable]
    public class IndividualModel : ModelBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }  
    }
}
