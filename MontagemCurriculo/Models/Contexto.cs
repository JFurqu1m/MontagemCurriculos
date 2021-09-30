using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MontagemCurriculo.Models
{
    public class Contexto : DbContext 
    {
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }
    }
}
