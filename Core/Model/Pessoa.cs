using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.Model
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Favor preencher o campo Nome, pois o mesmo é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Favor preencher o campo CPF, pois o mesmo é obrigatório.")]
        public string CPF {get;set;}

        [Required(ErrorMessage = "Favor preencher o campo Telefone, pois o mesmo é obrigatório.")]
        public string Telefone { get; set; }


        public virtual ICollection<Adotante> Adotante { get; set; }


        public bool IsValid
        {
            get { return Validator.TryValidateObject(this, new ValidationContext(this, null, null), null, true); }
        }

        public bool Update(Pessoa pessoa)
        {
            if (this.Id == pessoa.Id)
            {
                this.Nome = pessoa.Nome;
                this.CPF = pessoa.CPF;
                this.Telefone = pessoa.Telefone;

                return true;
            }
            return false;


        }


    }
}
