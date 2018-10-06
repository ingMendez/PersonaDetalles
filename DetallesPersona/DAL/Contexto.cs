using System.Data.Entity;
using DetallesPersona.Entidades;

namespace DetallesPersona.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> Personas { get; set; }

        public Contexto() : base("ConStr")
        {

        }


    }
}
