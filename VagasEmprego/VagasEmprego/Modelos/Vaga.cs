using System;
using System.Collections.Generic;
using System.Text;

namespace VagasEmprego.Modelos
{
    public class Vaga
    {
        public string nomeVaga { get; set; }
        public short Quantidade { get; set; }
        public string Cidade { get; set; }
        public double Salario { get; set; }
        public string Descricao { get; set; }
        public string TipoContratacao { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

    }
}
