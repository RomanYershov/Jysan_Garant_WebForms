using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jysan.BLL.Abstractions;
using Jysan.BLL.Models;
using Jysan.DAL.EF;
using Jysan.DAL.Entities;

namespace Jysan.BLL.Services
{
    public class LegalEntityService : ILegalEntityService
    {
        private readonly ApplicationDbContext _dbContext = new ApplicationDbContext();
        public IEnumerable<LegalEntityModel> Get()
        {
            throw new NotImplementedException();
        }

        public LegalEntityModel GetById(int id)
        {
            var entity = _dbContext.LegalEntities.Find(id);
            if (entity != null)
                return new LegalEntityModel
                {
                    Id = entity.Id,
                    Iin = entity.Iin,
                    Name = entity.Name,
                    IndividualModels = entity.Individuals.Select(x => new IndividualModel
                    {
                        Id = x.Id,
                        Iin = x.Iin,
                        FirstName = x.FirstName,
                        LastName = x.LastName
                    }).ToList()
                };
            return null;
        }

        public void Create(LegalEntityModel model)
        {
            var legal = new LegalEntity
            {
                Iin = model.Iin,
                Name = model.Name,
            };
            _dbContext.LegalEntities.Add(legal);
            _dbContext.SaveChanges();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id, LegalEntityModel model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IndividualModel> GetContactsByLegalEntity(int id)
        {
            var entity = _dbContext.LegalEntities.Find(id);
            var individuals = entity?.Individuals.Select(x => new IndividualModel
            {
                LastName = x.LastName,
                FirstName = x.FirstName,
                Patronymic = x.Patronymic,
                Iin = x.Iin
            });
            return individuals;
        }
    }
}
