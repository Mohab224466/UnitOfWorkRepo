using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_pattern_with_UOW.core.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        T GetById(int id);  
    }
}
