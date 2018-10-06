using DetallesPersona.DAL;
using DetallesPersona.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DetallesPersona.BLL
{
    public class PersonaBLL
    {
        
        public static bool Guardar(Personas personas)
        {
            bool paso = false;

            Contexto contexto = new Contexto();

            try
            {
                if (contexto.Personas.Add(personas) != null)
                {
                    paso = contexto.SaveChanges() >0;
                    //paso = true;
                }
                
            }
            catch (Exception)
            { throw; }
            finally
            {
                contexto.Dispose();
            }
            return paso;


        }
        // Este es el metodo para modificar en la base de datos
        public static bool Modificar(Personas persona)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var Anterior = contexto.Personas.Find(persona.PersonaId);

                //  contexto.Entry(persona).State = System.Data.Entity.EntityState.Modified;
                foreach (var item in Anterior.Telefonos)
                {
                    if (!persona.Telefonos.Exists(d => d.Id == item.Id))
                    {
                        contexto.Entry(item).State = EntityState.Deleted;
                    }
                }
                contexto.Entry(persona).State = EntityState.Modified;
                paso = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            { throw; }
            finally
            { contexto.Dispose();}

            return paso;

        }

        //este  es el metodo para eliminar en la bse de datos
        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {

                //Personas persona = contexto.Personas.Find(id);
                //contexto.Personas.Remove(persona);

                var eliminar = contexto.Personas.Find(id);
                contexto.Entry(eliminar).State = System.Data.Entity.EntityState.Deleted;
                // anteriormente
                //if (contexto.SaveChanges() > 0)
                //{
                //    paso = true;
                //}
                // contexto.Dispose();
                paso = (contexto.SaveChanges() > 0);
                //contexto.Dispose();

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        /// <summary>
        ///  Este es el metodo para buscar en la bae de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Personas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Personas persona = new Personas();
            try
            {
                persona = contexto.Personas.Find(id);
                //  contexto.Dispose();
                persona.Telefonos.Count();

            }
            catch (Exception)
            { throw; }
            finally {contexto.Dispose(); }

            return persona;
        }


        /// <summary>
        /// Este es el metoo para listar o cosultar lo que tenemos en a base de datos
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static List<Personas> GetList(Expression<Func<Personas, bool>> expression)
        {
            List<Personas> Persona = new List<Personas>();
            Contexto contexto = new Contexto();
            try
            {
                Persona = contexto.Personas.Where(expression).ToList();
               // contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            finally { contexto.Dispose(); }
            return Persona;
        }



    }
}
