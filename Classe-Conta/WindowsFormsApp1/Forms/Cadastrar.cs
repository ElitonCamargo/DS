using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            conta.numero = Convert.ToInt32(txtNumero.Text);

            if (Form1.ListaDeContas.addConta(conta))
            {
                txtNumero.Clear();
                txtNumero.Focus();
            }
            else
            {
                MessageBox.Show(Form1.ListaDeContas.msgErro);
            }
        }
    }
}
