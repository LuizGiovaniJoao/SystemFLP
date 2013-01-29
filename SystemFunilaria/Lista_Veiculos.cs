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
    public partial class Lista_Veiculos : Form
    {
        Funcoes FuncoesCs = new Funcoes();

        public Lista_Veiculos()
        {
            InitializeComponent();
        }

        private void Lista_Veiculos_Load(object sender, EventArgs e)
        {

        }

        private void bt_Adicionar_Click(object sender, EventArgs e)
        {
            Cad_Veiculo frm = new Cad_Veiculo();
            frm.Show();
        }

        private void bt_Remover_Click(object sender, EventArgs e)
        {
            FuncoesCs.apresentaDeletar();
        }
    }
}
