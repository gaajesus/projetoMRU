using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRU
{
	public partial class frmMRU : Form
	{
		public frmMRU()
		{
			InitializeComponent();
		}
		private void limpaForm()
		{
			//limpar dados do controle e posicionar foco no Espaco Inical.
			txtEspacoInicial.Focus();
			txtEspacoInicial.Clear();
			txtTempo.Clear();
			txtVelocidade.Clear();
			//lblEspacoFinal.Text = "";
		}
		private void btnNovo_Click(object sender, EventArgs e)
		{
			//limpar dados do controle e posicionar foco no Espaco Inical.
			// limpaForm();
			foreach (Control item in this.Controls)
			{
				if (item is TextBox)
					item.Text = "";
			}
		}
		private double CalcularEspacoFinal(double espacoInicial, double velocidade, double tempo)
		{
			double espacoFinal = 0;
			espacoFinal = espacoInicial + velocidade * tempo;
			return espacoFinal;
		}
        private double CalcularEspacoInicial(double espacoFinal, double tempo, double velocidade)
        {
            double espacoInicial = 0;
            espacoInicial = espacoFinal - velocidade * tempo;
            return espacoInicial;
        }
        private double CalcularVelocidade(double espacoFinal, double espacoInicial, double tempo)
        {
            double velocidade = 0;
            velocidade = espacoFinal - espacoInicial / tempo;
            return velocidade;
        }
        private double CalcularTempo(double espacoFinal, double espacoInicial, double velocidade)
        {
            double tempo = 0;
            tempo = espacoFinal - espacoInicial/ velocidade;
            return tempo;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
		{
			 //ToString("C") - converte para moeda;
			//ToString("#0,##0.00);
			if (cbbOpcao.Text == "Espaço Final")
			{
				double espacoFinal = 0;

				espacoFinal = CalcularEspacoFinal(Convert.ToDouble(txtEspacoInicial.Text),
					Convert.ToDouble(txtVelocidade.Text), Convert.ToDouble(txtTempo.Text));
				txtResult.Text = espacoFinal.ToString("#,###0.00");
			}
			if (cbbOpcao.Text == "Espaço Inicial")
			{
				double inicial = 0;
                inicial = CalcularEspacoInicial(Convert.ToDouble(txtEspacoInicial.Text), 
                    Convert.ToDouble(txtVelocidade.Text), Convert.ToDouble(txtTempo.Text));
				txtResult.Text = inicial.ToString("#0,##0.00");
			}
			if (cbbOpcao.Text == "Velocidade")
			{
				double velocidade = 0;
                velocidade = CalcularVelocidade(Convert.ToDouble(txtEspacoInicial.Text),
                              Convert.ToDouble(txtVelocidade.Text),Convert.ToDouble(txtTempo.Text));
				txtResult.Text = velocidade.ToString("#0,##0.00");
			}
			if (cbbOpcao.Text == "Tempo")
			{
				double tempo = 0;
                tempo = CalcularTempo(Convert.ToDouble(txtEspacoInicial.Text),
                              Convert.ToDouble(txtVelocidade.Text),Convert.ToDouble(txtTempo.Text));
				txtResult.Text = tempo.ToString("#0,##0.00");
			}
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cbbOpcao_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbbOpcao.Text == "Velocidade")
			{
				lblEspacoInicial.Text = "Espaço Final (m):";
				lblVelocidade.Text = "Espaço Inicial (m):";
				lblTempo.Text = "Tempo (s):";

				lblResultado.Text = "Velocidade (m/s)";
				lblTitulo.Text = "Velocidade";
				
			}
			if (cbbOpcao.Text == "Tempo")
			{
				lblEspacoInicial.Text = "Espaço Final (m):";
				lblVelocidade.Text = "Espaço Inicial (m)";
				lblTempo.Text = "Velocidade (m/s)";

				lblResultado.Text = "Tempo (s)";
				lblTitulo.Text = "Tempo";
			}
			if (cbbOpcao.Text == "Espaço Inicial")
			{
				lblEspacoInicial.Text = "Espaço Final (m):";
				lblVelocidade.Text = "Velocidade(m/s):";
				lblTempo.Text = "Tempo (s):";

				lblResultado.Text = "Espaço Inicial (m)";
				lblTitulo.Text = "Espaço Inicial";
			}
			if (cbbOpcao.Text == "Espaço Final")
			{
				lblEspacoInicial.Text = "Espaço Inicial (m):";
				lblVelocidade.Text = "Velocidade(m/s):";
				lblTempo.Text = "Tempo (s):";

				lblResultado.Text = "Espaço Final (m):";
				lblTitulo.Text = "Espaço Final";
			}
		}

		private void frmMRU_FormClosing(object sender, FormClosingEventArgs e)
		{
			//Messagebox.show(Texto da msg, titulo, buton,icones)
			DialogResult resposta;
			resposta = MessageBox.Show("Deseja realmente sair, FDP?", "Cálculo do MRU", MessageBoxButtons.YesNo,
																		MessageBoxIcon.Question);

			if (resposta == DialogResult.No)
			{
				e.Cancel = true;
			}
		}
		private void rdoKm_CheckedChanged(object sender, EventArgs e)
		{
			lblMinicial.Text = "Km/h";
			lblMseg.Text = "Km/h";
			lblStempo.Text = "hora(s)";
			lblMfinal.Text = "Km/h";
		}

        private void rdoMetros_CheckedChanged(object sender, EventArgs e)
        {
            lblMinicial.Text = "metros";
            lblMseg.Text = "metros/segundo";
            lblStempo.Text = "segundos";
            lblMfinal.Text = "metros";
        }
    }
}
