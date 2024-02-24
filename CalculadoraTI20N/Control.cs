using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI20N
{
    class Control
    {
        //Criei uma conexao com a classe Model
        Model mod;

        public Control()
        {
            mod = new Model();//Chamando o construtor da classe Model
        }

        public String Menu()
        {
            string msg = "### Menu ###\n\n" +
                          "0. Sair\n"       +
                          "1. Somar\n"      +
                          "2. Subtrair\n"   +
                          "3. Multiplicar\n"+
                          "4. Dividir\n"    +
                          "Escolha uma das opçoes acima:";
            return msg;

        }//fim do Menu

        public void Operacao()
        {
            int opcao;
            do
            {
                Console.WriteLine(Menu());//Mostrar as opçoes na tela
                 opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Coletar();//Chamando o método para coleta
                        Console.WriteLine("A soma dos valores digitados é : " + mod.Somar());
                        break;
                    case 2:
                        Coletar();
                        Console.WriteLine("a Subtração dos números digitados é: " + mod.Subtrair());
                        break;
                    case 3:
                        Coletar();
                        Console.WriteLine("a Multiplicação dos números digitados é: " + mod.Multiplicar());
                        break;
                    case 4:
                        Coletar();
                        if (mod.Dividir() == -1)
                        {
                            Console.WriteLine("Impossivel dividir por zero!!");
                        }
                        else
                        {
                            Console.WriteLine("a Divisão dos números digitados é: " + mod.Dividir());
                        }
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção válida");
                        break;
                }//Fim do switch
            } while (opcao != 0);
        }//Fim da Operacao

        public void Coletar()
        {
            //Coletando o primeiro número
            Console.WriteLine("Informe o primeiro número: ");
            mod.ConsultarNum1 = Convert.ToDouble(Console.ReadLine());

            //Coletando o segundo número
            Console.WriteLine("Informe o segundo número: ");
            mod.ConsultarNum2 = Convert.ToDouble(Console.ReadLine());
        }//Fim do método coletar


    }//Fim da Classe
}//Fim do Projeto
