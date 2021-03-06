﻿

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CP.Api.Usuario.Models
{
    public class Usuarios
    {
        [Required]
        [StringLength(11, MinimumLength = 11)]

        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage ="CEP Inválido")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Cpf { get; set; }
        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Nome Inválido")]
        [StringLength(60, MinimumLength =3 )]
        public string Nome { get; set; }

        [StringLength(9, MinimumLength = 8)]
        public string Celular { get; set; }

        [StringLength(60, MinimumLength = 6)]
        public string Email { get; set; }


    }
}
