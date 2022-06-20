using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class Auto
    {

        [Column("AutoId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "AutoId is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]

        public bool Disponibile { get; set; }
        
        public ICollection<NomeAuto> Nomeauto { get; set; }
    }
}
