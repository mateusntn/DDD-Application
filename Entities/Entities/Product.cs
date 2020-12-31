using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    public class Product : Base
    {
        [Display(Name = "Preço")]
        [Column("Preco", TypeName = "decimal")]
        public decimal Preco { get; set; }

        [Display(Name = "Ativo")]
        public bool Ativo { get; set; }


        [Display(Name = "Observação")]
        public string Observacao { get; set; }


    }
}
