/*criação de class*/
using bytebank.Titular;

namespace bytebank
{
    public class ContaCorrente
    {   /* com a palavra reservada */
       
        public Cliente Titular
        {

            get;/*Propriedade alto inclementada */
            set;

        }
        private string conta;
        public string Conta
        {
            get { return conta; }
            set
            {
                if (value == null)
                {
                    return;
                }
                else
                {
                    conta = value;
                }
            }
        }

        public int _numero_agencia;
        public int Numero_agencia
        {

            get { return _numero_agencia; }
            set
            {
                if (_numero_agencia <= 0)
                {

                }
                else
                {
                    _numero_agencia = value;
                }
            }
        }
        public string nome_agencia { get; set; }

        public double saldo;
      


        /* definir comportamento desta class*/
        public bool Sacar (double valor) /* O metodo bool retorna o valor */
        { /* comparação */
            if (saldo < valor)
            {
                return false;
            } 
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }
        public void  Depositar (double valor) /* O metodo void não  retorna o valor */
        {
            saldo = saldo + valor;
        }

        /*Atribuindo mais um comportamento */
        public bool Transferir (double valor , ContaCorrente destino) /* recebendo 2 parametreo */
        {
            if(saldo < valor)
            {
                return false;
            }
            if(valor > 0)
            {
                return false ;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true ;
            }
      
        }
        /**/
        //public void SetSaldo(double valor  )
        //  {
        //      if(valor < 0)
        //      {
        //          return;
        //      }
        //      else
        //      {
        //          saldo = valor;
        //      }
        //  }/*Colocar valor */
        //  public double GetSaldo()
        //  {
        //      return saldo;   
        //  }/*Retorna valor*/

        /*Para facilitar a manipulação do saldo  vai ser criado uma propriedade */
        public double Saldo
        {
            get
            {
                return saldo; /* Eçle vai me retorna o campo que estou trabalhando */
            }
            set
            {
               if(value < 0)
                {
                    return;
                }
                else
                {
                    Saldo = value;
                }

            }
        }
           
        public ContaCorrente ( int numero_agencia , string conta )
        {
            Numero_agencia = numero_agencia;
            Conta = conta;
            TotalDeContasCriada += 1;
        }

        public int TotalDeContasCriada { get; set; }

    }

}
