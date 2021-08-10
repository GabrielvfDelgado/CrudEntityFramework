using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudGabrielDelgado.Models
{
    public class Cliente
    {
        [Key]
        [Display(Name = "Id")]
        public int IdCli { get; set; }
        
        [Display(Name = "Nome")]
        public string NomeCli { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress]
        public string Emailcli { get; set; }

        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Display(Name = "Rua")]
        public string Rua { get; set; }

        [Display(Name = "Nº")]
        public int Numero { get; set; }
    }
}
