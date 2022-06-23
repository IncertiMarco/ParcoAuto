using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entities.Models
{
    public class Auto
    {     
        [Column("AutoId")]
        public int Id { get; set; }

        public string Targa { get; set; }

        public SpecificheAuto specificheAuto { get; set; }
        public ICollection<Prenotazioni> Prenotazioni { get; set; }
    }
}
