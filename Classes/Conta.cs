using System;

namespace DIO.bank
{
    public class Conta
    {
        //atributos
        private TipoConta Tipoconta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private string Nome { get; set; }
        
        //metodos
        public Conta(TipoConta tipoconta, double saldo, double credito, string nome)
        {
            this.Tipoconta = tipoconta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;

        }

        public bool Sacar(double valorSaque)
        {
            //validação de saldo suficiente
            if (this.Saldo - valorSaque < (this.Credito * -1))
            {
                Console.WriteLine("Saldo insuficiênte!");
                return false;
            }

            this.Saldo -= valorSaque;

            Console.WriteLine("Saldo atual da conta de  {0} é {1}", this.Nome, this.Saldo);

            return true;
            }

            public void Depositar(double valorDeposito)
            
            {
                this.Saldo += valorDeposito;

                {
                    Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);

                    }

            }

            public void Transferir(double valortransferencia, Conta contaDestino)

            {

                if(this.Sacar(valortransferencia)){  
                     contaDestino.Depositar(valortransferencia);
            }    
        }
        
        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta " + this.Tipoconta + " | ";
            retorno += "nome " + this.Nome + " | ";
            retorno += "Saldo " + this.Saldo  + " | ";
            retorno += "Credito " + this.Credito;
            return retorno;
        }
    }
}