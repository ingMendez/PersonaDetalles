using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DetallesPersona.Entidades
{
    public class TelefonosDetalles
    {
        [Key]
        public int  Id { get; set; }
        //public int PersonaId { get; set; }
        public string TipoTelefono { get; set; }
        public string Telefono { get; set; }

        public TelefonosDetalles()
        {
            Id = 0;
           // PersonaId = 0;
            TipoTelefono = string.Empty;
            Telefono = string.Empty;
        }
        public TelefonosDetalles(int id,int idPersona,string tipoTelefono,string telefono)
        {
            Id = id;
           // PersonaId =idPersona;
            TipoTelefono = tipoTelefono;
            Telefono = telefono;
            
        }
    }
}
