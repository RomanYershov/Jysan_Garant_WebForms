using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jysan.BLL.Models;

namespace Jysan.BLL.Abstractions
{
    public interface ILegalEntityService : IService<LegalEntityModel>
    {
        IEnumerable<IndividualModel> GetContactsByLegalEntity(int id);

    }
}
