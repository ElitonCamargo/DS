using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProva
{
    public partial class ListaDeFuncionario : Form
    {
        List<Funcionario> listFunc;
        public ListaDeFuncionario(List<Funcionario> funcionarios)
        {
            this.listFunc = funcionarios;
            InitializeComponent();
        }

        private void ListaDeFuncionario_Load(object sender, EventArgs e)
        {
            carregarDataGridView();
        }

        private void carregarDataGridView()
        {
            string[] cargos = {
                "Auxiliar Administrativo",
                "Técnico de Hardware",
                "Encarregado",
                "Gerente",
                "Diretor"
            };
            dataGridView1.Rows.Clear();
            foreach (Funcionario f in listFunc)
            {
                dataGridView1.Rows.Add(
                    f.matricula,
                    f.nome,
                    cargos[f.codigoCargo],
                    f.salario.ToString("C"),
                    f.tempotrab,
                    f.reajuste.ToString("C"),
                    f.acrescimo.ToString("C"),
                    f.salarioReajutado.ToString("C")
                );
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            carregarDataGridView();
        }
    }
}
