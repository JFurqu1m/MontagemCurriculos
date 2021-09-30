using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MontagemCurriculo.Models
{
    public class ExperienciaProfissional
    {
        public int ExperienciaProfissionalId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(50, ErrorMessage = "Use menos caracteres")]
        public string NomeEmpresa { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(50, ErrorMessage = "Use menos caracteres")]
        public string Cargo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(1920,2021, ErrorMessage = "Ano Inválido")]
        public int AnoInicio { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(1920, 2021, ErrorMessage = "Ano Inválido")]
        public int AnoFim { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(50, ErrorMessage = "Use menos caracteres")]
        [DataType(DataType.MultilineText)]
        public string DescricaoAtividades { get; set; }
        public int CurriculoId { get; set; }
        public Curriculo Curriculo { get; set; }
    }
}
