using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TroppoAtividade.Entities
{
    public class PessoaJuridica : Cliente
    {
        public string Cnpj { get; set; }
        public string Ie { get; set; }
        public override void PagarImposto(double v)
        {
            this.Valor = v;
            this.ValorImposto = this.Valor * 20 / 100;
            this.Total = this.Valor + this.ValorImposto;
        }
    }
}
