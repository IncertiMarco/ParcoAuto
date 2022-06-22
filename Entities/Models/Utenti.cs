using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class Utenti
    {
        /*
         public int UtentiId { get; set; }

         public string Nome { get; set; }

         public string Cognome { get; set; }
        */
        [Column("UtentiId")]
        public Guid Id { get; set; }

        public string Targa { get; set; }

        public ICollection<Prenotazioni> Prenotazioni { get; set; }
    }
}
