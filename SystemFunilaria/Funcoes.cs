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
    public class Funcoes
    {
        //Função mudança de cor na Entrada TEXTBOX
        public void changeTextBoxFocusIn(object txtBox)
        {
            // faz o cast do tipo object para o tipo TextBox
            TextBox t = txtBox as TextBox;
            t.BackColor = SystemColors.Info;
        }

        //Função mudança de cor na Saída TEXTBOX
        public void changeTextBoxFocusOut(object txtBox)
        {
            // faz o cast do tipo object para o tipo TextBox
            TextBox t = txtBox as TextBox;
            t.BackColor = Color.White;
        }

        //Função mudança de cor na Entrada MaskedTextBox
        public void changeMaskedTextBoxFocusIn(object masktxt)
        {
            // faz o cast do tipo object para o tipo MaskedTextBox
            MaskedTextBox m = masktxt as MaskedTextBox;
            m.BackColor = SystemColors.Info;
        }

        //Função mudança de cor na Saída MaskedTextBox
        public void changeMaskedTextBoxFocusIOut(object masktxt)
        {
            // faz o cast do tipo object para o tipo MaskedTextBox
            MaskedTextBox m = masktxt as MaskedTextBox;
            m.BackColor = Color.White;
        }

        //Método de apresentação do formInformacao com a mensagem salvar
        public void apresentaSalvo()
        {
            FormInformacao abrir = new FormInformacao("Salvo!");
            abrir.Show();
        }

        //Método de apresentação do formInformacao com a mensagem salvar
        public void apresentaDeletar()
        {
            FormInformacao abrir = new FormInformacao("Removido!");
            abrir.Show();
        }
    }
}
