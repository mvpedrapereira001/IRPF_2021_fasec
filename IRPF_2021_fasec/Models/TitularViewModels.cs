using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IRPF_2021_fasec.Models
{

    public class Titular 
    {
         
        [Key]
        [Display(Name = "CPF Titular")]
        public string Cpf_Titular { get; set; }

        public string Nome_titular { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        public string ID_USUARIO { get; set; }

        
    }  
  }

   
 