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
    public class IndividualService : IIndividualService
    {
        private readonly ApplicationDbContext _dbContext = new ApplicationDbContext();

      
        public IEnumerable<IndividualModel> Get()
        {
            var individuals = _dbContext.Individuals.Select(x => new IndividualModel
            {
                Iin = x.Iin,
                LastName = x.LastName,
                FirstName = x.FirstName,
                Id = x.Id
            });
            return individuals;
        }

        public IndividualModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(IndividualModel model)
        {
            var individual = new Individual
            {
                Iin = model.Iin,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Patronymic = model.Patronymic
            };
            _dbContext.Individuals.Add(individual);
            _dbContext.SaveChanges();
        }

        public void Remove(int id)
        {
            var individual = _dbContext.Individuals.Find(id);
            _dbContext.Individuals.Remove(individual ?? throw new InvalidOperationException());
            _dbContext.SaveChanges();
        }

        public void Edit(int id, IndividualModel model)
        {
            throw new NotImplementedException();
        }

    }
}
