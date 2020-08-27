namespace Veiculo
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        #region atributos

        private Veiculo carro;
        private int abasteceu=0;
        private decimal custolt;

        #endregion

        #region construtor

        public Form1()
        {
            InitializeComponent();
            carro = new Veiculo("77-93-UV", 40.00m, 5.80m, 157235.00m, 40.00m);
            //é um carro usado com 157.000 percorridos
            Stand();
        }

        #endregion

        #region outros métodos

        private void Stand()
        {
            tbMatricula.Text = carro.Matricula;
            udLtsaoscem.Value = carro.Ltsaoscem;
            udCapacidade.Value = carro.Capacidade;
            pbDeposito.Value = 100; //%

            udAbastecer.Maximum= carro.Capacidade;
            //tranca o depósito quando atesta

            udLtsaoscem.Enabled = false;
            udCapacidade.Enabled = false;
            //depois de o carro sair do stand são constantes

            udContakm.Enabled = false;
            udQuilometragem.Enabled = false;
            //desbloqueia qd o condutor rodar a chave
        }

        private void btChave_Click(object sender, EventArgs e)
        {
            udContakm.Enabled = true;
            udQuilometragem.Enabled = true;
            Viajar();
        }

        private void Viajar()
        {
            udContakm.Value = new Random().Next(0,100);
            if (udContakm.Value * (carro.Ltsaoscem / 100) > carro.Deposito)
            {
                udContakm.Value =0;
                return;
            }//se n tiver gasolina suficiente, n viaja
            carro.Andakm = udContakm.Value;
            custolt = 1.62m;
            carro.Atualizar(carro.Andakm);
            //somou à quilometragem e reduziu ao depósito
            udQuilometragem.Value = carro.Quilometragem;
            pbDeposito.Value = Convert.ToInt16(carro.Deposito * 100 / carro.Capacidade);
            udGastou.Value = carro.Qtcustou(custolt, carro.Andakm);
            udCustokm.Value = carro.QtcustouKm(custolt, carro.Andakm);
            udQuilometragem.Enabled = false;
            udContakm.Enabled = false;
            //estacionou, desligou a chave...
            carro.Andakm = 0;
            udAbastecer.Enabled = true;
            udAbastecer.Value = 0;
            //...e já pode ir abastecer
            if (carro.IsReserva())
            {
                lblReserva.BackColor = Color.Red;
            }//convém, se acender a luz vermelha
        }

        private void udAbastecer_ValueChanged(object sender, EventArgs e)
        {
            if (udAbastecer.Value < 0)
            {
                MessageBox.Show("Introduza a quantidade de combustível");
                return;
            }//validação evita input de valores negativos na numeric up_down

            if (udAbastecer.Value < abasteceu)
                return;
            //validação impede q se esvazie o depósito

            if (carro.Cheio()) //abastece e verifica se pode continuar
            {
                pbDeposito.Value = 100;
                udAbastecer.Enabled = false;
            }
            else
            {   //abasteceu mais 1 litro de gasolina
                //antes de continuar(ou não) mostra o abastecimento
                pbDeposito.Value = Convert.ToInt16(carro.Deposito * 100 / carro.Capacidade);
                abasteceu++;
                if (!carro.IsReserva())
                    lblReserva.BackColor = Color.White;
            }
        }

        #endregion
    }
}
