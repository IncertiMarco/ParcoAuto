using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entities.Models
{
    public class SpecificheAuto
    {

        [Column("ModelloId")]
         public int Id { get; set; }

        public string Modello { get; set; }
        public string Marca { get; set; }

        [ForeignKey(nameof(Auto))]
        public int AutoId { get; set; }
        public Auto Auto { get; set; }


    }
}
