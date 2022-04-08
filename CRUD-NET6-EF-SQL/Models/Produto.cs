﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_NET6_EF_SQL.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }


        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

    }
}
