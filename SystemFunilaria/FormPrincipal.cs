using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemFunilaria
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ordem_de_Servico frm = new Ordem_de_Servico();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cad_Funcionario frm = new Cad_Funcionario();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lista_Funcionarios frm = new Lista_Funcionarios();
            frm.Show();
        }
    }
}
