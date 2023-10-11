using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_TI18N
{
    class consultarFormulario
    {
        ModelExercicio exercicio;
        private int opcao;

        public consultarFormulario()
        {
            exercicio = new ModelExercicio();//conecta a classe model e a control
            ConsultarOpcao = -1;
        }//fim do metodo construtor


        public int ConsultarOpcao
        {
            get { return opcao; }
            set { opcao = value; }

        }//fim metodo

        public void Menu()
        {
            Console.WriteLine("\n\n ----Menu ---- \n\n" +
                               "0. Sair\n" +
                               "1. Exercicio 01\n" +
                               "2. Exercicio 02\n" +
                               "3. Exercicio 03\n" +
                               "4. Exercicio 04\n" +
                               "Escola uma das opções acima: ");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//menu
                               
                               
                               
        
        public void Operacao()
        {
            do
            {
                Menu();
                Console.Clear();
                switch (ConsultarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        double nota1;//Declarar fora
                        do
                        {
                            Console.WriteLine("Informe a primeira nota: ");
                            nota1 = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarNotas(nota1) == true)
                            {
                                Console.WriteLine("Informe uma nota entre 0 e 10");
                            }//fim
                        } while (exercicio.ValidarNotas(nota1) == true);

                        Console.WriteLine("Informe a segunda nota: ");
                        double nota2 = Convert.ToDouble(Console.ReadLine());
                        do
                        {

                            if (exercicio.ValidarNotas(nota2) == true)
                            {
                                Console.WriteLine("informe umta nota entre 0 e 10");
                            }//fim
                        } while (exercicio.ValidarNotas(nota2) == true);

                        //chamar metodo media 
                        Console.WriteLine("A média das duas notas é: " + exercicio.MediaDuasNotas(nota1, nota2));
                        break;
                   
                    case 2:
                        Console.WriteLine("Informe um número: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe outro número");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        //comparar
                        Console.WriteLine("O maior número é: " + exercicio.comparar(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        //mostrar o resultado
                        Console.WriteLine("O Antecessor é: " + exercicio.Antecessor(num));
                        break;

                    case 4:
                        double numA;
                        double numB;
                        do
                        {
                            Console.WriteLine("Informe a Base do retângulo: ");
                             numA = Convert.ToInt32(Console.ReadLine());
                            if (exercicio.AreaRetangulo(numA) == true)
                            {
                                Console.WriteLine("Informe um número Válido");
                            }//fim
                        } while (exercicio.AreaRetangulo(numA) == true);
                        
                       
                        do
                        {
                            Console.WriteLine("informe a Altura do retângulo: ");
                                numB = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.AreaRetangulo(numB) == true)
                            {
                                Console.WriteLine("informe um número válido");
                            }//fim
                        } while (exercicio.AreaRetangulo(numB) == true);



                    default:
                        Console.WriteLine("Opção escolhida não é válida");
                        break;
                }//fim do escolha
            } while (ConsultarOpcao != 0); //fim do while
        }

    }
}
