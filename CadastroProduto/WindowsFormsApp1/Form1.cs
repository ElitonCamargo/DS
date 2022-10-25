using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Produto> listaProdutos = new List<Produto>();

        public void carregarLista()
        {
            dtListaDeProdutos.Rows.Clear();
            foreach (Produto p in listaProdutos)
            {
                dtListaDeProdutos.Rows.Add(p.codigo, p.nome, p.valor.ToString("C"));
            }
        }

        
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.codigo = Convert.ToInt32(txtCodigo.Text);
            produto.nome = txtNome.Text;
            produto.valor = Convert.ToDouble(txtValor.Text);

            bool existe = false;
            foreach (Produto p in listaProdutos){
                if (p.codigo == produto.codigo){
                    existe = true;
                }
            }
            if (!existe){
                listaProdutos.Add(produto);
                carregarLista();
                MessageBox.Show("Produto adicionado com sucesso!!!");
            }
            else {
                MessageBox.Show("Produto já existe!!!");
            }

            
        }
    }
}
