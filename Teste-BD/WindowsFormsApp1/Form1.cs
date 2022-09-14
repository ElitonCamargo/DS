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
               

        private void carregarDataGrig()
        {
            dataGridView1.Rows.Clear();
            Filme f = new Filme();
            List<Filme> listFilme = f.consultaTodos();
            foreach (Filme filme in listFilme)
            {
                dataGridView1.Rows.Add(
                    filme.nome,
                    filme.ano,
                    filme.avaliacao,
                    filme.like ? "👍" : "❌",
                    filme.comentario);
            }
        }
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int ano = Convert.ToInt32(txtAno.Text);
            int avaliacao = Convert.ToInt32(cbAvaliacao.Text);
            bool like = chckLike.Checked;
            string comentario = txtComentario.Text;
            Filme filme = new Filme(nome,ano,avaliacao,like,comentario);

            if (filme.cadastrar())
            {
                MessageBox.Show("Filme cadastrado com sucesso!!!");
                carregarDataGrig();
            }

        }

        Conexao cx;
        private void Form1_Load(object sender, EventArgs e)
        {
            cx = new Conexao("localhost", "loja", "root");
            if (cx.testarConexao())
            {
                MessageBox.Show("Conectado ao banco");
                carregarDataGrig();
            }
            else
            {
                MessageBox.Show($"Erro{ cx.getMsgErro() }");
            }
        }
    }
}
