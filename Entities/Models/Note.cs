using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Note
    {
        [Column("NotaId")]
        public int Id { get; set; }

        public string Annotazione { get; set; }

        [ForeignKey(nameof(Prenotazioni))]
        public int PrenotazioniId { get; set; }
        public Prenotazioni Prenotazioni { get; set; }


    }
}
