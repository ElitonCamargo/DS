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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool validarMatricula(string in_matricular, out int out_matricula)
        {
            if (int.TryParse(in_matricular, out int n))
                if (int.Parse(in_matricular) > 0)
                {
                    out_matricula = int.Parse(in_matricular);
                    return true;
                }
            out_matricula = 0;
            return false;
        }


        private bool validarNome(string nome, out string out_nome)
        {
            if (nome.Length > 3)
            {
                out_nome = nome;
                return true;
            }
            out_nome = "";
            return false;
        }

        private bool validarSalario(string salario, out double out_salario)
        {
            if (double.TryParse(salario, out double n))
            {
                if (n > 0)
                {
                    out_salario = n;
                    return true;
                }
            }
            out_salario = 0;
            return false;
        }

        private bool validarTempoTrab(string tempo, out int out_tempo)
        {
            if (int.TryParse(tempo, out int n))
            {
                if (n > -1)
                {
                    out_tempo = n;
                    return true;
                }
                
            }
            out_tempo = 0;
            return false;
        }
        List<Funcionario> listFunc = new List<Funcionario>();
        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            bool validarCadastro = true;
            if (!validarMatricula(txtMatricula.Text, out funcionario.matricula))
            {
                erroProviderCadastro.SetError(txtMatricula, "Matrícula inválida");
                txtMatricula.Focus();
                validarCadastro = false;
            }
            if (!validarNome(txtNome.Text, out funcionario.nome))
            {
                erroProviderCadastro.SetError(txtNome, "Nome é obrigatório");
                txtNome.Focus();
                validarCadastro = false;
            }
            if (cbCargo.SelectedIndex == -1)
            {
                erroProviderCadastro.SetError(cbCargo, "Escolha o cargo do funcionário");
                validarCadastro = false;
            }
            else
            {
                funcionario.codigoCargo = cbCargo.SelectedIndex;
            }
            if (!validarSalario(txtSalario.Text, out funcionario.salario))
            {
                erroProviderCadastro.SetError(txtSalario, "Salário inválido");
                txtSalario.Focus();
                validarCadastro = false;
            }
            if (!validarTempoTrab(txtTempoTrab.Text, out funcionario.tempotrab))
            {
                erroProviderCadastro.SetError(txtTempoTrab, "Tempo de trabalho inválido");
                txtTempoTrab.Focus();
                validarCadastro = false;
            }

            if (validarCadastro)
            {
                funcionario.calcReajusteSalarial();
                listFunc.Add(funcionario);
                txtMatricula.Clear();
                txtNome.Clear();
                txtSalario.Clear();
                txtTempoTrab.Clear();
                cbCargo.SelectedIndex = -1;
                MessageBox.Show("Funcionário cadastrado com sucesso!!!");
            }

        }

        private void TxtMatricula_TextChanged(object sender, EventArgs e)
        {
            erroProviderCadastro.Clear();
        }

        private void CbCargo_MouseClick(object sender, MouseEventArgs e)
        {
            erroProviderCadastro.Clear();
        }

        private void BtnListarFunc_Click(object sender, EventArgs e)
        {
            ListaDeFuncionario listaDeFuncionario = new ListaDeFuncionario(listFunc);
            listaDeFuncionario.Show();
        }
    }
}
