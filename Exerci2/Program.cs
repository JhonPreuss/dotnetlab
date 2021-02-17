using System;
/*Faça um algoritmo que calcule e exiba o salário reajustado de dez funcionários de acordo com a seguinte regra: Salário até 300, reajuste de 50%; Salários maiores que 300, reajuste de 30%.*/
namespace Exerci2
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Salario = 0.0;
            Double SalarioAjustado = 0;
            Console.WriteLine("Digite o salário a ser reajustado: \n");
            Salario = Convert.ToDouble(Console.ReadLine());
            if(Salario <= 300.00)
            {
                SalarioAjustado = Salario + (Salario*0.5);
            }
            else
            {
                SalarioAjustado = Salario + (Salario*0.3);
            }
            Console.WriteLine("Salário Antigo: R$ "+Salario+"\n Salário reajustado: R$ "+SalarioAjustado);


        }
    }
}
