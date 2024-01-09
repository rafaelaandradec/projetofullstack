using System.ComponentModel.DataAnnotations;
using WebAPI_Estudo.Enums;

namespace WebAPI_Estudo.Models
{
    public class FuncionarioModel
    {
        [Key]
        public int id { get; set; }
        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public DepartamentoEnum Departamento { get; set; }
        public bool Ativo { get; set; }
        public TurnoEnum Turno { get; set; }
        public DateTime DataDeCriacao { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime DataDeAlteracao { get; set; } = DateTime.Now.ToLocalTime();

    }
}
