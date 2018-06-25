﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.Model
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Login")]
        [Required(ErrorMessage = "Digite seu E-mail", AllowEmptyStrings = false)]
        public string NomeUsuario { get; set; }
        [Required(ErrorMessage = "Digite sua Senha", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Senha { get; set; }

        public bool IsValid
        {
            get { return Validator.TryValidateObject(this, new ValidationContext(this, null, null), null, true); }
        }

        public bool Update(Usuario usuario)
        {
            if (this.Id == usuario.Id)
            {
                this.NomeUsuario = usuario.NomeUsuario;
                this.Senha = usuario.Senha;

                return true;
            }
            return false;


        }

    }
}