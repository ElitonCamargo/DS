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
    public partial class Listar : Form
    {
        public Listar()
        {
            InitializeComponent();
        }

        private void Listar_Load(object sender, EventArgs e)
        {
            atualizarDataGrid();
        }               
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = dataGridView1.Rows[e.RowIndex];
            txtNumero.Text = linha.Cells[0].Value.ToString();
        }
        public void atualizarDataGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (Conta conta in Form1.ListaDeContas.contas)
            {
                dataGridView1.Rows.Add(conta.numero, conta.saldo.ToString("C"));
            }
        }
        private void BtnDepositar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            double valor = Convert.ToDouble(txtValor.Text);
            Conta c = Form1.ListaDeContas.buscarPorNumero(numero);
            if (c.depositar(valor))
            {
                MessageBox.Show("Operação realizada com sucesso!!!");
                atualizarDataGrid();
            }
            else
            {
                MessageBox.Show(c.msgErro);
            }
        }

        private void BtnSacar_Click(object sender, EventArgs e)
        {

            int numero = Convert.ToInt32(txtNumero.Text);
            double valor = Convert.ToDouble(txtValor.Text);
            Conta c = Form1.ListaDeContas.buscarPorNumero(numero);
            if (c.sacar(valor))
            {
                MessageBox.Show("Operação realizada com sucesso!!!");
                atualizarDataGrid();
            }
            else
            {
                MessageBox.Show(c.msgErro);
            }
        }

        private void BtnTransferi_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            double valor = Convert.ToDouble(txtValor.Text);
            Transferir t = new Transferir(numero, valor, this);
            t.Show();
        }
    }
}
