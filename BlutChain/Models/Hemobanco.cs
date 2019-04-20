﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlutChain.Models
{
    [Table("Hemobanco")]
    public class Hemobanco
    {
        [Key]
        public int IdHemobanco { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [MaxLength(150, ErrorMessage = "O campo deve ter no máximo 150 caracteres!")]
        [Display(Name = "Razão Social")]
        public String RazaoSocialHemobanco { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [MaxLength(150, ErrorMessage = "O campo deve ter no máximo 150 caracteres!")]
        [Display(Name = "Nome Fantasia")]
        public String NomeFantasiaHemobanco { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [MinLength(14, ErrorMessage = "O campo deve ter no minimo 14 caracteres!")]
        [MaxLength(14, ErrorMessage = "O campo deve ter no máximo 14 caracteres!")]
        [Display(Name = "CNPJ")]
        public String CNPJHemobanco { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "E-mail inválido!")]
        public String EmailHemobanco { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [MaxLength(200, ErrorMessage = "O campo deve ter no máximo 200 caracteres!")]
        [Display(Name = "Endereço")]
        public Endereco EnderecoHemobanco { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [MinLength(8, ErrorMessage = "O campo deve ter no minimo 8 caracteres!")]
        [MaxLength(15, ErrorMessage = "O campo deve ter no máximo 15 caracteres!")]
        [Display(Name = "Telefone")]
        public Telefone TelefoneHemobanco { get; set; }
    }
}