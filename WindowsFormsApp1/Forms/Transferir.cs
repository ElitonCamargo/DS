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
    public partial class Transferir : Form
    {
        public Transferir(int numero, double valor, Listar f)
        {
            InitializeComponent();
            this.numero = numero;
            this.valor = valor;
            this.f = f;
        }
        Listar f;
        int numero;
        double valor;

        private void Transferir_Load(object sender, EventArgs e)
        {
            txtNumero.Text = numero.ToString();
            textBox1.Text = valor.ToString();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            double valor = Convert.ToDouble(textBox1.Text);
            Conta c = Form1.ListaDeContas.buscarPorNumero(numero);
            Conta d = Form1.ListaDeContas.buscarPorNumero(Convert.ToInt32(textBox2.Text));
            if (c.transferir(valor, d))
            {
                MessageBox.Show("Operação realizada com sucesso!!!");
                this.f.atualizarDataGrid();
            }
            else
            {
                MessageBox.Show(c.msgErro);
            }
        }
    }
}
