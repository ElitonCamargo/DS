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
        public static ListaDeContas ListaDeContas = new ListaDeContas();
        private void CastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Cadastrar cadastrar = new Forms.Cadastrar();
            cadastrar.MdiParent = this;
            cadastrar.Show();
        }

        private void ListarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Listar listar = new Forms.Listar();
            listar.MdiParent = this;
            listar.Show();
        }
    }
}
