using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exercício 5 – Foi realizada uma pesquisa de algumas características físicas da população de certa
         região, a qual coletou os seguintes dados referentes a cada habitante para serrem analisados:
         • Sexo (M- masculino ou F- Feminino)
         • Cor dos olhos (Azuis, Verdes ou Castanhos)
         • Cor dos cabelos (Louros, Castanhos ou Pretos)
         • Idade
         • Altura
         • Peso
         Apresente a média da idade dos participantes, a média do peso e da altura de seus habitantes, a
         porcentagem de pessoas do sexo feminino e a porcentagem de pessoas do sexo masculino. Quantas
         pessoas possuem olhos verdes e cabelo louro? A cada iteração deverá ser perguntado para o usuário
         se deseja continuar ou não. Os resultados deverão ser apresentados apenas quando o usuário não
         desejar mais inserir dados.  */

            int idade = 0, i = 0, CLOV = 0, somaidade = 0, numM = 0, numF = 0;
            double altura = 0, somaaltura = 0, somapeso = 0, peso = 0;
            char sexo = ' ', opcao = ' ', olhos = ' ', cabelos = ' ';
            bool check = true;

            do
            {
                Console.Write("\nDigite o sexo [M] para Masculino ou [F] para Feminino: ");
                sexo = char.Parse(Console.ReadLine().ToUpper());

                if (!(sexo.Equals('M') || sexo.Equals('F')))
                {
                    Console.WriteLine("O sexo digitado é invalido.");
                }
                else
                {
                    if (sexo.Equals('M'))
                    {
                        numM++;
                    }
                    else
                    {
                        numF++;
                    }
                    Console.Write("Digite a cor dos olhos? [C] para Castanhos, [A] para Azuis ou [V] para Verdes: ");
                    olhos = char.Parse(Console.ReadLine().ToUpper());
                    if (olhos.Equals('C') || olhos.Equals('A') || olhos.Equals('V'))
                    {

                        Console.Write("Digite a cor dos cabelos? [C] para Castanhos, [P] para Pretos ou [L] para Louros: ");
                        cabelos = char.Parse(Console.ReadLine().ToUpper());
                        if (cabelos.Equals('C') || cabelos.Equals('P') || cabelos.Equals('L'))
                        {
                            Console.Write("Digite a idade: ");
                            idade = int.Parse(Console.ReadLine());
                            if (idade >= 0)
                            {

                                Console.Write("Digite a altura em metros: ");
                                altura = double.Parse(Console.ReadLine());
                                if (altura > 0)
                                {

                                    Console.Write("Digite o peso (kg): ");
                                    peso = double.Parse(Console.ReadLine());
                                    if (peso > 0)
                                    {
                                        somaaltura += altura;
                                        somaidade += idade;
                                        somapeso += peso;
                                        i++;
                                        if (cabelos.Equals('L') && olhos.Equals('V'))
                                        {
                                            CLOV++;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("O valor digitado é inválido.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("O valor digitado é inválido.");

                                }
                            }
                            else
                            {

                                Console.WriteLine("O valor digitado é inválido.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("A opção digitada é inválida.");

                        }
                    }
                    else
                    {
                        Console.WriteLine("A opção digitada é inválida.");


                    }

                }


                do
                {
                    Console.WriteLine("\nDeseja continuar? [S] para Sim ou [N] para não");
                    opcao = char.Parse(Console.ReadLine().ToUpper());
                } while (!(opcao.Equals('S') || opcao.Equals('N')));


            } while (opcao != 'N');

            Console.WriteLine("\nA média de idade dos participantes é: " + (somaidade / i) + " anos.");
            Console.WriteLine("A média de peso dos participantes é: " + (somapeso / i) + " kg.");
            Console.WriteLine("A média de altura dos participantes é: " + ((somaaltura / i) / 100) + " m.");
            Console.WriteLine("A porcentagem de mulheres é: " + ((numF * 100) / i) + "%.");
            Console.WriteLine("A porcentagem de homens é: " + ((numM * 100) / i) + "%.");
            Console.WriteLine("O número de pessoas que possuem cabelo louro e olhos verdes é: " + CLOV + ".");
            Console.ReadKey();
        }
    }
}
