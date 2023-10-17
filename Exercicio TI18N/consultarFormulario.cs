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
                               "5. Exercicio 05\n" +
                               "6. Exercicio 06\n" +
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
                        double bas;
                        double alt;
                        do
                        {
                            Console.WriteLine("informe a base do retângulo: ");
                            bas = Convert.ToDouble(Console.ReadLine());
                            if (bas < 0)
                            {
                                Console.WriteLine("erro informe um valor positivo");
                            }
                        } while (bas < 0);
                        do 
                        { 
                        
                        Console.WriteLine("informe a altura do retângulo: ");
                        alt = Convert.ToDouble(Console.ReadLine());
                            if (alt < 0)
                            {
                                Console.WriteLine("erro informe um valor positivo");
                            }
                        } while (alt < 0);
                        //mostrar mensagem tela
                        Console.WriteLine("area do retângulo é: " + exercicio.AreaRetangulo(bas,alt));
                        break;
                    case 5:
                        double totalEleitores;
                        double validos;
                        double nulos;
                        double brancos;

                        do
                        {
                            Console.WriteLine("informe o total de eleitores");
                            totalEleitores = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(totalEleitores) == false)
                            {
                                Console.WriteLine("informe um valor positivo");
                            }
                        } while (exercicio.Validar(totalEleitores) == false);

                        do
                        {
                            Console.WriteLine("informe os votos validos");
                            validos = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(validos) == false)
                            {
                                Console.WriteLine("informe um valor positivo");
                            }
                        } while (exercicio.Validar(validos) == false);

                        do
                        {
                            Console.WriteLine("informe o total de votos nulos");
                            nulos = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(nulos) == false)
                            {
                                Console.WriteLine("informe um valor positivo");
                            }
                        } while (exercicio.Validar(nulos) == false);

                        do
                        {
                            Console.WriteLine("informe o total de votos brancos");
                            brancos = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(brancos) == false)
                            {
                                Console.WriteLine("informe um valor positivo");
                            }
                        } while (exercicio.Validar(brancos) == false);

                        if(brancos+validos+nulos == totalEleitores)
                        {
                            Console.WriteLine("\nHá " + exercicio.PorcentagemVotos(brancos, totalEleitores) + "% de votos brancos"
                                              + "\nHá " + exercicio.PorcentagemVotos(nulos, totalEleitores) + "% de votos nulos"
                                              + "\nHá " + exercicio.PorcentagemVotos(validos, totalEleitores) + "% de votos validos");
                        }
                        else
                        {
                            Console.WriteLine("total de eleitores é diferente da soma de votos brancos,validos e nulos.");
                        }


                        break;

                    case 6:
                        double salario;
                        double pReajuste;
                        do
                        {
                            Console.WriteLine("informe o salário: ");
                            salario = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.salarioReajuste(salario) == false) 
                            {
                                Console.WriteLine("informe um valor positivo");
                            }


                        } while (exercicio.salarioReajuste(salario) == false);
                        do
                        {
                            Console.WriteLine("informe o percentual de reajuste: ");
                            pReajuste = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.salarioReajuste(pReajuste) == false)
                            {
                                Console.WriteLine("informe um valor positivo");
                            }
                        } while (exercicio.salarioReajuste(pReajuste) == false);
                        
                        
                        Console.WriteLine("o novo salário é: R$ " + salario+(salario * (pReajuste / 100)));




                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida");
                        break;
                }//fim do escolha
            } while (ConsultarOpcao != 0); //fim do while
        }

    }
}
