using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ListaDeContas
    {
        public List<Conta> contas = new List<Conta>();
        public string msgErro;

        public bool addConta(Conta conta)
        {
            if (this.buscarPorNumero(conta.numero) == null)
            {
                this.contas.Add(conta);
                return true;
            }
            this.msgErro = "Conta já existe";
            return false;
        }

        public Conta buscarPorNumero(int numero)
        {
            foreach (Conta c in this.contas)
            {
                if (c.numero == numero)
                {
                    return c;
                }
            }
            return null;
        }
    }
}
