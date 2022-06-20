using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using System.Text;

namespace Entities.Models
{
    public class Storico
    {
        [Column("IdStorico")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Data Prenotazioni passate is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
        public string DataPrenotazione { get; set; }
        [Required(ErrorMessage = "Km percorsi is a required field.")]
        public int KmPercorsi { get; set; }
        [Required(ErrorMessage = "Annotazioni is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the Position is 20 characters.")]
        public string Annotazioni { get; set; }
        [ForeignKey(nameof(Auto))]
        public Guid AutoId { get; set; }
        public Auto Auto { get; set; }
    }
}
