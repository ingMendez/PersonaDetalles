using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DetallesPersona.Entidades
{
    public class Personas
    {
      [Key]
      public int PersonaId { get; set; }
        public string Nombre  { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public string  Direccion { get; set; }
        public DateTime FechaNacimiento { get; set;}

        public virtual List<TelefonosDetalles> Telefonos { get; set; }

        public Personas()
        {
            PersonaId = 0;
            Nombre = string.Empty;
            Telefono = string.Empty;
            Cedula = string.Empty;
            Direccion = string.Empty;
            FechaNacimiento = DateTime.Now;
            Telefonos = new List<TelefonosDetalles>();

        }
        public Personas(int Personaid,string nombre,string telefono,string cedula,string direccion, DateTime fecha)
        {
            PersonaId = Personaid;
            Nombre = nombre;
            Telefono = telefono;
            Cedula = cedula;
            Direccion = direccion;
            FechaNacimiento = fecha;
        }
    

    }
}
