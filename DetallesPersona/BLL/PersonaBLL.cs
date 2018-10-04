using DetallesPersona.DAL;
using DetallesPersona.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DetallesPersona.BLL
{
    public class PersonaBLL
    {
        public static object contexto { get; private set; }

        public static bool Guardar(Persona personas)
        {
            bool paso = false;

            Contexto contexto = new Contexto();

            try
            {
                if (contexto.Personas.Add(personas) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;


        }
        public static bool Modificar(Persona personas)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(personas).State = System.Data.Entity.EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;

        }

        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                Persona persona = contexto.Personas.Find(id);
                contexto.Personas.Remove(persona);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;

            }
            return paso;
        }

        public static Persona Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Persona persona = new Persona();
            try
            {
                persona = contexto.Personas.Find(id);
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }
            return persona;
        }



        public static List<Persona> GetList(Expression<Func<Persona, bool>> expression)
        {
            List<Persona> Persona = new List<Persona>();
            Contexto contexto = new Contexto();
            try
            {
                Persona = contexto.Personas.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return Persona;
        }



    }
}
