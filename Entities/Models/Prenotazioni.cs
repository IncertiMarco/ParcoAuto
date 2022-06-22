using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class Prenotazioni
    {

        /* public int Id { get; set; }
         public DateTime Data { get; set; }
         public int Kilometer { get; set; }


         public Utenti Utenti { get; set; }


         public Auto Auto { get; set; }
         */

        [Column("Prenotazioni")]
        public Guid Id { get; set; }

        public DateTime DataPrenotazione { get; set; }

        public int Chilometri { get; set; }


        [ForeignKey(nameof(Auto))]
        public Guid AutoId { get; set; }
        public Auto Auto { get; set; }

        [ForeignKey(nameof(Utenti))]
        public Guid UtentiId { get; set; }
        public Utenti Utenti { get; set; }
    }
}
