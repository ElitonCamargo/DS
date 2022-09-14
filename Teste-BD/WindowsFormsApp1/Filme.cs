using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApp1
{
    class Filme
    {
        public int id;
        public string nome;
	    public int ano;
	    public int avaliacao;
	    public bool like;
	    public string comentario;

        private Conexao cx = new Conexao("localhost", "loja", "root");

        public Filme(string nome, int ano, int avaliacao, bool like, string comentario)
        {
            this.nome = nome;
            this.ano = ano;
            this.avaliacao = avaliacao;
            this.like = like;
            this.comentario = comentario;
        }

        public Filme()
        {
            
        }

        public Filme(int id, string nome, int ano, int avaliacao, bool like, string comentario)
        {
            this.id = id;
            this.nome = nome;
            this.ano = ano;
            this.avaliacao = avaliacao;
            this.like = like;
            this.comentario = comentario;
        }


        public bool cadastrar()
        {
            int like = this.like ? 1 : 0;
            string cmdSql = $"INSERT INTO filme(nome, ano, avaliacao, `like`, comentario) VALUES ('{this.nome}','{this.ano}','{this.avaliacao}','{like}','{this.comentario}')";
            if (cx.INSERT(cmdSql) > 0)
            {
                return true;
            }
            MessageBox.Show(cx.getMsgErro());
            return false;
        }

        public List<Filme> consultaTodos()
        {
            List<Filme> listaRetorno = new List<Filme>();
            string cmdSql = "SELECT * FROM filme";
            DataTable dados = cx.SELECT(cmdSql);
            if (dados != null)
            {
                foreach (DataRow linha in dados.Rows)
                {
                    bool l =  Convert.ToInt32(linha[4]) == 1 ? true : false;
                    listaRetorno.Add(
                        new Filme(
                           Convert.ToInt32(linha[0]),
                           linha[1].ToString(),
                           Convert.ToInt32(linha[2]),
                           Convert.ToInt32(linha[3]),
                           l,
                           linha[5].ToString()
                        )
                    );
                }
            }
            return listaRetorno;
        }
    }
}
