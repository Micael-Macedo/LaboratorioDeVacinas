using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LaboratorioDeVacinas.Models;

namespace LaboratorioDeVacinas.Models
{
    public class LaboratorioVacinasContext : DbContext
    {
        public LaboratorioVacinasContext(DbContextOptions<LaboratorioVacinasContext> options) : base(options) { }
        public DbSet<LaboratorioDeVacinas.Models.Vacina>? Vacina { get; set; }
        public DbSet<LaboratorioDeVacinas.Models.Virus>? Virus { get; set; }
        
    }
}