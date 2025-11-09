using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TroppoAtividade.Entities
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public double Valor { get; protected set; }
        public double ValorImposto { get; protected set; }
        public double Total { get; protected set; }

        public virtual void PagarImposto(double v)
        {
            // Imposto base para Pessoa Física
            // Alterado para a Pessoa Jurídica
            this.Valor = v;
            this.ValorImposto = this.Valor * 10 / 100;
            this.Total = this.Valor + this.ValorImposto;
        }
    }
}
