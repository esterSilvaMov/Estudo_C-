using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytbank_ADM.Funcionarios
{
    public class Funcionario
    {
        /*01  - Funcionario 
         * 02 - diretor 
         * 03 - desing 
         * n - 
    
        */
       // private int _tipo;
        /*Metodo Construtor */
    
        

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public double Salario { get; set; }



        public double getBonificacao()
        {
                return Salario * 0.1;
        }
    }
}