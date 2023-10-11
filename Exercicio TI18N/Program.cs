using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_TI18N
{
     class Program
    {
        static void Main(string[] args)

        {
            //conectar a contrl com a program
            consultarFormulario control = new consultarFormulario();//instaniando variavel
            control.Operacao();


            Console.ReadLine();
        }//fim Main
    }//fim class program
}//fim do projeto
