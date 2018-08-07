using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUS.Modelo.DB.Model
{
    public class Vacina
    {

        public virtual int IdVacina { get; set; }
        public virtual DateTime DtVacina { get; set; }
        public virtual String NomeVacina { get; set; }
        public virtual DateTime AnoValidadeVacina { get; set; }
        public virtual CartaoVacina Cartao { get; set; }
    }

    public class VacinaMap : ClassMapping<Vacina>
    {
        public VacinaMap()
        {
            Id(x => x.IdVacina, m => m.Generator(Generators.Identity));

            Property(x => x.DtVacina);
            Property(x => x.NomeVacina);
            Property(x => x.AnoValidadeVacina);

            ManyToOne(x => x.Cartao, m =>
            {
                m.Lazy(LazyRelation.NoLazy);
                m.Column("idCartaoVacina");
            });

        }
    }
}
