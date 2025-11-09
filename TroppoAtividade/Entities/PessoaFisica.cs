using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TroppoAtividade.Entities
{
    public class PessoaFisica : Cliente
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }
    }
}
