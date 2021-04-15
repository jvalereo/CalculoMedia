using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treinamento - Aula18 , Calcula a media do aluno, tipo double
           //Jonas Valereo - Técnico em Informática

            //Declarando as variaveis tipo double

            double nota1, nota2, nota3, media;

            //Declarando entrada de dado no console, método ReadLine

            Console.WriteLine("Digite a nota de portugues:");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a nota de matemática:");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a nota de ciência: ");
            nota3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine();
            



            //Declarando a variavel media  das notas1, notas2, notas3

            media = (nota1 + nota2 + nota3) / 3;



            //imprimir saida de dados no console,método WhriteLine, concatenação

            //Declarando estrutura condicional simples, if e else 

            if (media >= 7)
            {

                Console.WriteLine("A media do aluno: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine();
                Console.WriteLine("Parabéns, Aluno Aprovado...");

            }
            else
            {

                Console.WriteLine("A media do aluno: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine();
                Console.WriteLine("Infelizmente, Aluno Reprovado...");

            }

            // saida da aplicação,  console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();
            
            //Fim do programa

        }
    }
}
