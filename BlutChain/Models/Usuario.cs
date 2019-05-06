﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlutChain.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [MaxLength(150, ErrorMessage = "O campo deve ter no máximo 150 caracteres!")]
        [Display(Name = "Nome")]
        public String NomeUsuario { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [MinLength(11, ErrorMessage = "O campo deve ter 11 caracteres!")]
        [MaxLength(11, ErrorMessage = "O campo deve ter 11 caracteres!")]
        [Display(Name = "CPF")]
        public String CPFUsuario { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public DateTime DataNascimentoUsuario { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public String SexoUsuario { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "E-mail inválido!")]
        public String EmailUsuario { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int PesoUsuario { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public TipoSanguineo TipoSanguineoUsuario { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public Endereco EnderecoUsuario { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [MinLength(8, ErrorMessage = "O campo deve ter no minimo 8 caracteres!")]
        [MaxLength(15, ErrorMessage = "O campo deve ter no máximo 15 caracteres!")]
        [Display(Name = "Telefone")]
        public Telefone TelefoneUsuario { get; set; }
    }
}