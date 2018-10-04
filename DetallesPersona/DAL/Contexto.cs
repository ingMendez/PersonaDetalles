using System.Data.Entity;
using DetallesPersona.Entidades;

namespace DetallesPersona.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Persona> Personas { get; set; }

        public Contexto() : base("ConStr")
        {

        }


    }
}
