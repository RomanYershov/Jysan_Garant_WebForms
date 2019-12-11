using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jysan.BLL.Abstractions
{
    public interface IService<T> where T : ModelBase
    {
        IEnumerable<T> Get();
        T GetById(int id);
        void Create(T model);
        void Remove(int id);
        void Edit(int id, T model);
    }
}
