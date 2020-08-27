using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    public class Veiculo
    {
        //#region atributos

        //private string matricula;
        //private decimal quilometragem;
        //private decimal capacidade;
        //private decimal deposito;
        //private decimal ltsaoscem;
        //private decimal andakm;

        //#endregion

        #region propriedades
        //falta o "contador de viagens"
        public string Matricula { get; set; }
        public decimal Quilometragem { get; set; }
        public decimal Deposito { get; set; }
        public decimal Capacidade { get; set; }
        public decimal Ltsaoscem { get; set; }
        public decimal Andakm { get; set; }

        #endregion

        #region Construtores
        //o construtor por parâmetros pode ter muitos menos parâmetros do q os atributos
        //mas qd se instancia só se coloca os parâmetros entre parêntesis

        public Veiculo(string matric, decimal capac, decimal ltscem, decimal kmtotal, decimal gasolina)
        {
            Matricula = matric;
            Capacidade = capac;
            Ltsaoscem = ltscem;
            Quilometragem = kmtotal;
            Andakm = 0.0m;
            Deposito = gasolina;
        }//construtor por parâmetros


        #endregion

        #region Métodos

        public void Atualizar (decimal percorreukm)
        {
            Quilometragem += percorreukm;
            Deposito -= Math.Round(percorreukm * (Ltsaoscem / 100));
        }

        public bool IsReserva ()
        {
            bool isReserva = false;
            if (Deposito <= 10)
                isReserva = true;
            return isReserva;
        }

        public decimal Qtcustou (decimal precolt, decimal percorreukm)
        {
            decimal valortotal = percorreukm * (Ltsaoscem / 100) * precolt;
            return valortotal;
        }

        public decimal QtcustouKm (decimal precolt, decimal percorreukm)
        {
            decimal valorkm = (Ltsaoscem / 100) * precolt;
            return valorkm;
        }//o q gastou por cada Km q andou

        public bool Cheio ()//int gasolina
        {
            //Deposito += gasolina;
            Deposito += 1;
            //int litros = 0;
            //while((Deposito + litros <= Capacidade) && (litros<=gasolina))
            //{
            //    Deposito += litros;
            //    litros++;
            //}
            if (Deposito < Capacidade)
                return false;
            else
                return true;  
        }

        public decimal CalculaKm()
        {
            decimal qtdKm = (Deposito * 100) / Ltsaoscem;
            return qtdKm;
        }
        #endregion
    }
}
