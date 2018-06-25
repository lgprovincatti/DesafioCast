using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.Model
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }

        public int EspecieId { get; set; }

        [Required(ErrorMessage = "Favor preencher o campo Raça, pois o mesmo é obrigatório.")]
        public string Raca { get; set; }

        [Required(ErrorMessage = "Favor preencher o campo Nome, pois o mesmo é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Favor preencher o campo Idade pois o mesmo é obrigatório.")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Favor preencher o campo Sexo pois o mesmo é obrigatório.")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Favor preencher o campo Data de Entrada pois o mesmo é obrigatório.")]
        public string DataEntrada { get; set; }


        public virtual Especie Especie { get; set; }

        public virtual ICollection<Adotante> Adotante { get; set; }



        public bool IsValid
        {
            get { return Validator.TryValidateObject(this, new ValidationContext(this, null, null), null, true); }
        }

        public bool Update(Animal animal)
        {
            if (this.Id == animal.Id)
            {
                this.EspecieId = animal.EspecieId;
                this.Raca = animal.Raca;
                this.Nome = animal.Nome;
                this.Idade = animal.Idade;
                this.Sexo = animal.Sexo;
                this.DataEntrada = animal.DataEntrada;


                return true;
            }
            return false;


        }


    }




}
