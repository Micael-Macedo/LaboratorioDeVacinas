using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioDeVacinas.Models
{
    public class Vacina
    {
        public int VacinaId { get; set; }
        public String Nome { get; set; }
        public DateTime DataCraicao { get; set; }
        [ForeignKey("Virus")]
        public int? VirusFK { get; set; }
        public virtual Virus Virus{ get; set; }
    }
}