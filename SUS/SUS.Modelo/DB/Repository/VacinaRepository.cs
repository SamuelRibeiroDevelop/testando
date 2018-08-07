using NHibernate;
using SUS.Modelo.DB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUS.Modelo.DB.Repository
{
    public class VacinaRepository : RepositoryBase<Vacina>
    {
        public VacinaRepository(ISessionFactory sessionFactory) : base(sessionFactory) { }
    }
}
