using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI20N
{
    internal class Model
    {
        //Área de variaveis
        private double num1;
        private double num2;

        //Metodo Construtor = Instancia as variáveis
        public Model()
        {
            ConsultarNum1 = 0;
            num2 = 0;
        }//fim do Construtor


        //Metodo GET e SET
        public double ConsultarNum1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public double ConsultarNum2
        {
            get { return num2; }
            set { num2 = value; }
        }
        //Fim do GET e SET

        public double Somar()
        {
            double soma = ConsultarNum1 + ConsultarNum2;
            return soma;

        }//Fim do Somar

        public double Subtrair()
        {
            return ConsultarNum1 - ConsultarNum2;
        }

        public double Multiplicar()
        {
            return ConsultarNum1 * ConsultarNum2;
        }

        public double Dividir()
        {
            if (ConsultarNum2 <= 0)
            {
                return -1;
            }
            else
            {
                return ConsultarNum1 / ConsultarNum2;
            }
        }//Fim da classe
    }//fim da classe
}//fim do projeto
