using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entities.Models
{
    public class Auto
    {
        /* public int AutoId { get; set; }

         public string AutoName { get; set; }

         public string Targa { get; set; }
        */
        [Column("AutoId")]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Cognome { get; set; }

        public ICollection<Prenotazioni> prenotazioni { get; set; }
    }
}
