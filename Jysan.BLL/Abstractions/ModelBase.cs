using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jysan.BLL.Abstractions
{
    [Serializable]
    public class ModelBase
    {
        public int Id { get; set; }
        public string Iin { get; set; } 
    }
}
