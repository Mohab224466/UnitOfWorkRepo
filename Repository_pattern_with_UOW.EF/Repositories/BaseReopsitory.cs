using Repository_pattern_with_UOW.core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_pattern_with_UOW.EF.Repositories
{

    public class BaseReopsitory<T> : IBaseRepository<T> where T : class
    {
        protected ApplicationDBContext _dbContext;
        public BaseReopsitory(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }
    }
}
