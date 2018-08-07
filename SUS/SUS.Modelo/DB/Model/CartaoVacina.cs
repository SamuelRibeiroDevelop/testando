using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUS.Modelo.DB.Model
{
    public class CartaoVacina
    {

        public virtual int IdCartao { get; set; }

        public virtual DateTime DtCartao { get; set; }

        public virtual Usuario Usuario { get; set; }
    }

    public class CartaoMap : ClassMapping<CartaoVacina>
    {
        public CartaoMap()
        {
            Id(x => x.IdCartao, m => m.Generator(Generators.Identity));

            Property(x => x.DtCartao);

            OneToOne(x => x.Usuario, m =>
            {
                m.PropertyReference(typeof(Usuario).GetProperty("Usuario"));
                m.Lazy(LazyRelation.NoLazy);
                m.Cascade(Cascade.Persist);
            });
        }
    }
}
