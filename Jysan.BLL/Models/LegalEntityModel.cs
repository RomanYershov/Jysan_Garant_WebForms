
using System.Collections.Generic;
using Jysan.BLL.Abstractions;

namespace Jysan.BLL.Models
{
    public class LegalEntityModel : ModelBase
    {
        public string Name { get; set; }
        public List<IndividualModel> IndividualModels { get; set; }     
    }
}
