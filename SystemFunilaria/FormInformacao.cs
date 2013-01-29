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
    public partial class FormInformacao : Form
    {
        public NumericUpDown num = new NumericUpDown();
        public string inform;
        public FormInformacao(string informacao)
        {
            InitializeComponent();
            inform = informacao;
        }

        private void FormInformacao_Load(object sender, EventArgs e)
        {
            //
            //
            label1.Text = inform;
            if(label1.Text == "Salvo!")
            {
                pictureBox1.Image = SystemFunilaria.Properties.Resources.correto;
                label1.Size = new Size(73, 22);
            }
            else if(label1.Text == "Removido!")
            {
                pictureBox1.Image = SystemFunilaria.Properties.Resources._104;
                label1.Size = new Size(121, 22);
            }
            apresentar();
        }

        public void apresentar()
        {
            num.Value = 1;
            int segundos = System.Convert.ToInt32(num.Value);
            timerInformacao.Stop();
            timerInformacao.Interval = (int)segundos * 1000;
            timerInformacao.Tick += new EventHandler(timerEvent);
            timerInformacao.Start();
        }

        private void timerEvent(Object sender, EventArgs e)
        {
            timerInformacao.Stop();
            this.Close();
        }
    }
}
