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
                               "7. Exercicio 07\n" +
                               "8. Exercicio 08\n" +
                               "9. Exercicio 09\n" +
                               "10.Exercicio 10\n" +
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
                            if (exercicio.AjusteSalario(salario) == false) 
                            {
                                Console.WriteLine("informe um valor positivo");
                            }


                        } while (exercicio.AjusteSalario(salario) == false);
                        do
                        {
                            Console.WriteLine("informe o percentual de reajuste: ");
                            pReajuste = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.AjusteSalario(pReajuste) == false)
                            {
                                Console.WriteLine("informe um valor positivo");
                            }
                        } while (exercicio.AjusteSalario(pReajuste) == false);


                        Console.WriteLine("o novo salário é: R$ " + exercicio.AjusteSalario(salario, pReajuste));

                        break;
                    case 7:
                        double impostos;
                        double distribuidor;
                        double custoFabrica;
                        do
                        {
                            Console.WriteLine("informe o percentual de impostos: ");
                            impostos = Convert.ToDouble(Console.ReadLine());
                            if (impostos <= 0)
                            {
                                Console.WriteLine("o valor informado não é valido");
                            }//


                        } while (impostos <= 0);

                        do
                        { 
                            Console.WriteLine("informe o percentual do distribuidor: ");
                            distribuidor = Convert.ToDouble(Console.ReadLine());
                            if (distribuidor < 0)
                            {
                                Console.WriteLine("O número digitado não é válido");
                            }//

                        } while (distribuidor < 0);

                        do
                        {
                            Console.WriteLine("informe o custo de fábrica: ");
                            custoFabrica = Convert.ToDouble(Console.ReadLine());
                            if (custoFabrica < 0)
                            {
                                Console.WriteLine("O número digitado não é válido");
                            }//

                        } while (custoFabrica < 0);

                        Console.WriteLine("o custo final é : R$" + exercicio.CustoCarro(impostos, distribuidor, custoFabrica));

                        break;
                        
                        
                    case 8:
                        double numeroCarros;
                        double totalVendas;
                        double salarioFixo;
                        double valorPorCarro;
                        double comissao;
                        double salarioFinal;

                        do
                        {

                            Console.WriteLine("informe o salário fixo: ");
                            salarioFixo = Convert.ToDouble(Console.ReadLine());
                            if (salarioFixo < 0)
                            {
                                Console.WriteLine("o numero digitado não é válido");
                            }//
                        } while (salarioFixo < 0);
                        do
                        {

                            Console.WriteLine("informe o numero de carros vendidos: ");
                            numeroCarros = Convert.ToDouble(Console.ReadLine());
                            if (numeroCarros < -1)
                            {
                                Console.WriteLine("o numero digitado não é válido");
                            }//
                        } while (numeroCarros < -1);
                        do
                        {

                            Console.WriteLine("informe o total de vendas: ");
                            totalVendas = Convert.ToDouble(Console.ReadLine());
                            if (totalVendas < -1)
                            {
                                Console.WriteLine("o numero digitado não é válido");
                            }//
                        } while (totalVendas < -1);
                        do
                        {

                            Console.WriteLine("informe o valor por carro : ");
                            valorPorCarro = Convert.ToDouble(Console.ReadLine());
                            if (valorPorCarro < 0)
                            {
                                Console.WriteLine("o numero digitado não é válido");
                            }//
                        } while (valorPorCarro < 0);
                        do
                        {

                            Console.WriteLine("informe a comissao: ");
                            comissao = Convert.ToDouble(Console.ReadLine());
                            if (comissao < 0)
                            {
                                Console.WriteLine("o numero digitado não é válido");
                            }//
                        } while (comissao < 0);

                        Console.WriteLine("o salário do funcionário é: " + (salarioFinal = salarioFixo + (valorPorCarro * numeroCarros) + (totalVendas * (comissao / 100))));

                        break;
                    case 9:
                        double notaA;
                        double notaB;
                        double notaC;
                        double media;

                        do
                        {
                            Console.WriteLine("informe a primeira nota: ");
                            notaA = Convert.ToDouble(Console.ReadLine());
                            if (notaA <0)
                            {
                                Console.WriteLine("informe uma nota de 0 a 10");
                            }
                        }while (notaA < 0);
                        
                        do
                        {
                            Console.WriteLine("informe a segunda nota: ");
                            notaB = Convert.ToDouble(Console.ReadLine());
                            if (notaB < 0)
                            {
                                Console.WriteLine("informe uma nota de 0 a 10");
                            }
                        } while (notaB < 0);
                        
                        do
                        {
                            Console.WriteLine("informe a terceira nota: ");
                            notaC = Convert.ToDouble(Console.ReadLine());
                            if (notaC < 0)
                            {
                                Console.WriteLine("informe uma nota de 0 a 10");
                            }
                        } while (notaC < 0);

                        Console.WriteLine("Sua média foi: " + exercicio.calcNotas(notaA, notaB, notaC));
                        media = (notaA + notaB + notaC) / 3;

                        if (media < 5)
                        {
                            Console.WriteLine("você está de recuperação, e precisa de " + (10 - media + 2));

                        }
                        else
                        {
                            if (media < 7)
                            {
                                Console.WriteLine("Você vai para a prova final, e precisa de ", (10 - media));
                            }
                            else
                            {
                                if (media < 8)
                                {
                                    Console.WriteLine("Você vai para conselho");
                                }
                                else 
                                { 
                                    Console.WriteLine("Você está aprovado");
                                }
                            }
                        }//fim repita
               
                        break;//fim exercicio
                    case 10:
                               "1. Exercicio 01\n" +
                               "2. Exercicio 02\n" +
                               "3. Exercicio 03\n" +
                               "4. Exercicio 04\n" +




                    break;

                    default:
                        Console.WriteLine("Opção escolhida não é válida");
                        break;
                }//fim do escolha
            } while (ConsultarOpcao != 0); //fim do while
        }

    }
}
