using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exercicio_TI18N
{
    class ModelExercicio
    {
        public ModelExercicio() {

        }//fim consultar

        public double MediaDuasNotas(double nota1, double nota2)
        {
            return (nota1 + nota2);
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

        public double AreaRetangulo(double bas, double alt)
        {
            return bas * alt;
        }//fim metodo

        public double PorcentagemVotos(double votos, double total)
        {
            return (votos * 100) / total;
        }

        public Boolean Validar(double num)
        {
            if (num < 0)
            {
                return false;
            }
            else
            {
                return true;
            }//fim validar

        }//fim
        public Boolean salarioReajuste(double num1)
        {
            if (num1 < 0)
            {
                return false;
            }
            else
            {
                return true;
            } 
                    
        }//fim 
                        
    }

}
