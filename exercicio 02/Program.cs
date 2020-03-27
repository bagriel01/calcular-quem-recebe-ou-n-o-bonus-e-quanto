using System;

namespace exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            int anotrab;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Boas vindas a Central de RH ACME. Se você veio checar se receberá o bônus, veio ao Lugar certo!");
            Console.WriteLine("Esteja ciente que se você trabalhar mais de 5 anos, receberá 20% de Bônus.");
            Console.WriteLine("Se trabalhar menos de 5 anos, receberá 10% de Bônus.");
            Console.WriteLine("Primeiro, Digite qual o ano que você começou a trabalhar nas empresas ACME (Exemplo : 1997)");
            anotrab = int.Parse(Console.ReadLine());
            Console.WriteLine("Perfeito. Agora digite o valor de seu salário sem números quebrados (Exemplo: 2.500)");
            salario = double.Parse(Console.ReadLine());

            if (anotrab > 2015)
            {
                salario = salario+salario * 0.1;
                Console.WriteLine("Parabéns! Seu novo salário será " + salario);
            } 
            else
            {
                salario = salario+salario * 0.2;
                Console.WriteLine("Parabéns! Seu novo salário será " + salario);
            }

        }
    }
}
