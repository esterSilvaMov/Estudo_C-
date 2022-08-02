using bytbank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytbank._2.Utilitarios
{
    internal class GerenciadorDeBonificacao
    {
        public double totalBonificacao { get; set; }

        public void Registrar (Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.getBonificacao();
        }

        public double getBonificacao()
        {
            return this.totalBonificacao;
        }


    }
}
