﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC5.Models
{
    public class OS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }


        public int clienteID { get; set; }
        public virtual Cliente cliente { get; set; }
        public virtual string Nomecliente { get { return cliente.nome; } }


        [Display(Name = "Aparelho: ")]
        [Required(ErrorMessage = "Campo nome é obrigatório")]
        [StringLength(35, ErrorMessage = "Tamanho tem que ser no máximo 35 caracteres")]
        public string aparelho { get; set; }

        [Display(Name = "Descrição do problema: ")]
        [Required(ErrorMessage = "O campo de descricao do problema é obrigatório")]
        [StringLength(300, ErrorMessage = "Campo não pode passar de 300 caracteres")]
        [MinLength(2, ErrorMessage = "Tem que ter no mínimo 2 caracteres")]
        public string descricao { get; set; }

        [Display(Name = "Valor:")]
        [Required(ErrorMessage = "Informe o valor a ser cobrado pelo serviço")]
        public float valor { get; set; }

        //public virtual string nomeCliente { get { return Cliente.nome; } }



    }
}
