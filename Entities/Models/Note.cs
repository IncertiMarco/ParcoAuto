using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Note
    {
        [Column("NotaId")]
        public Guid Id { get; set; }

        public string Annotazione { get; set; }

        [ForeignKey(nameof(Prenotazioni))]
        public Guid PrenotazioniId { get; set; }
        public Prenotazioni Prenotazioni { get; set; }

        public ICollection<Prenotazioni> Prenotazionis { get; set; }

    }
}
