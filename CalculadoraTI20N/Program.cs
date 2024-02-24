using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI20N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Control controle = new Control();
            controle.Operacao();//Chamou o método principal



            Console.ReadLine();//Ler dados - manter a tela aberta(neste caso)
        }//Fim do método
    }//Fim da classe
}//Fim do projeto