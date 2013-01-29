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
    public partial class Lista_Funcionarios : Form
    {
        public Funcoes FuncoesCor = new Funcoes();
        public Lista_Funcionarios()
        {
            InitializeComponent();
        }

        private void txt_CpfCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        /*private void txt_CpfCodigo_Enter(object sender, EventArgs e)
        {
            FuncoesCor.changeTextBoxFocusIn(sender);
        }

        private void txt_CpfCodigo_Leave(object sender, EventArgs e)
        {
            FuncoesCor.changeTextBoxFocusOut(sender);
        }*/

        private void bt_Remover_Click(object sender, EventArgs e)
        {
            FuncoesCor.apresentaDeletar();
        }

        private void txt_CpfCodigo_Enter(object sender, EventArgs e)
        {
            FuncoesCor.changeTextBoxFocusIn(sender);
            if (txt_CpfCodigo.Text == "CPF/Código")
                txt_CpfCodigo.Text = "";
        }

        private void txt_CpfCodigo_Leave(object sender, EventArgs e)
        {
            FuncoesCor.changeTextBoxFocusOut(sender);
            if (txt_CpfCodigo.Text == "")
                txt_CpfCodigo.Text = "CPF/Código";
        }

        private void txt_NomeApelido_Enter(object sender, EventArgs e)
        {
            FuncoesCor.changeTextBoxFocusIn(sender);
            if (txt_NomeApelido.Text == "Nome/Apelido")
                txt_NomeApelido.Text = "";
        }

        private void txt_NomeApelido_Leave(object sender, EventArgs e)
        {
            FuncoesCor.changeTextBoxFocusOut(sender);
            if (txt_NomeApelido.Text == "")
                txt_NomeApelido.Text = "Nome/Apelido";
        }
    }
}
