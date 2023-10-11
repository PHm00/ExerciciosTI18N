using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_TI18N
{
    class ModelExercicio
    {
        public ModelExercicio() {

        }//fim consultar
        
        public double MediaDuasNotas(double nota1, double nota2)
        { 
            return(nota1 + nota2); 
        }//fim


        //Método de validação
        public Boolean ValidarNotas(double nota)
        {
            if ((nota < 0) || (nota > 10))
            {
                return true;
            }
            else
            {
                return false;
            }



        }//fim
        public int comparar(int num1, int num2)
        {
            if (num1 > num2)

            {
                return num1;
            }
            else
            {
                return num2;
            }

        }//fim

        //exercício 3- Antecessor
        public int Antecessor(int num)
        {
            return num - 1;
        }//fim Antecessor

        public double AreaRetangulo(double numA, double numB) 
        {
            return numA * numB;
        }

    }

}
