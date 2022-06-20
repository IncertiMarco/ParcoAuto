using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class NomeAuto
    {
        [Column("NomeAuto")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "NomeAuto is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
        public string Name { get; set; }
       
        [Required(ErrorMessage = "Data is a required field.")]
        public string DataPrenotazione { get; set; }

        [Required(ErrorMessage = "Storico is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the Position is 20 characters.")]
        public string Storico { get; set; }

        [Required(ErrorMessage = "Annotazione is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the Position is 20 characters.")]
        public string Annotazioni { get; set; }


        [ForeignKey(nameof(Auto))]
        public Guid AutoId { get; set; }
        public Auto Auto { get; set; }


    }
}
