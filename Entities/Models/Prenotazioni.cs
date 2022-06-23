using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class Prenotazioni
    {

        [Column("PrenotazioniId")]
        public int Id { get; set; }

        public DateTime DataInizioPrenotazione { get; set; }

        public DateTime DataFinePrenotazione { get; set; }

        public int Chilometri { get; set; }

        public ICollection<Note> Note { get; set; }


        [ForeignKey(nameof(Auto))]
        public int AutoId { get; set; }
        public Auto Auto { get; set; }

        [ForeignKey(nameof(Utenti))]
        public int UtentiId { get; set; }
        public Utenti Utenti { get; set; }

    }
}
