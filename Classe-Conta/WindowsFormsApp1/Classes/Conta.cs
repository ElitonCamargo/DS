using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Conta
    {
        public int numero;
        public double saldo;

        public string msgErro;

        public bool depositar(double valor)
        {
            if (valor > 0)
            {
                this.saldo += valor;
                return true;
            }
            this.msgErro = $"{valor.ToString("C")} não é um valor válido";
            return false;
        }

        public bool sacar(double valor)
        {
            if (valor > 0)
            {
                if (valor <= this.saldo)
                {
                    this.saldo -= valor;
                    return true;
                }
                this.msgErro = "Saldo insuficiente";
                return false;
            }
            this.msgErro = $"{valor.ToString("C")} não é um valor válido";
            return false;
        }

        public bool transferir(double valor, Conta destino)
        {
            if (this.sacar(valor))
            {
                return destino.depositar(valor);
            }
            return false;
        }
    }
}
