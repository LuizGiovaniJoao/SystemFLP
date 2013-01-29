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
    public partial class Cad_Veiculo : Form
    {
        public Funcoes FuncoesCor = new Funcoes();
        public Cad_Veiculo()
        {
            InitializeComponent();
        }

        private void bt_Pesquisar_Click(object sender, EventArgs e)
        {
            Lista_CLientes frm = new Lista_CLientes();
            frm.Show();
        }

        private void txt_Proprietario_Enter(object sender, EventArgs e)
        {
            FuncoesCor.changeTextBoxFocusIn(sender);
        }

        private void txt_Proprietario_Leave(object sender, EventArgs e)
        {
            FuncoesCor.changeTextBoxFocusOut(sender);
        }

        private void bt_Gravar_Click(object sender, EventArgs e)
        {
            FuncoesCor.apresentaSalvo();
        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            FuncoesCor.apresentaSalvo();
        }
    }
}
