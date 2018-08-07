using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUS.Modelo.DB.Model
{
    public class Usuario
    {
        public virtual int IdUsuario { get; set; }
        public virtual String NomeUsuario { get; set; }
        public virtual DateTime DataNascUsuario { get; set; }
        public virtual String CartaoSUSUsuario { get; set; }
        public virtual String SenhaUsuario { get; set; }

    }

    public class UsuarioMap : ClassMapping<Usuario>
    {
        public UsuarioMap()
        {
            Id(x => x.IdUsuario, m => m.Generator(Generators.Identity));

            Property(x => x.NomeUsuario);
            Property(x => x.DataNascUsuario);
            Property(x => x.CartaoSUSUsuario);
            Property(x => x.SenhaUsuario);

        }
    }
}
