using System;


namespace ProgramaçãoEstruturada.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] valores = new int[10];
            

            //Digitar os valores da sequencia
            DigitarOsValoresSequencia(valores);
            Console.WriteLine("=================================================\n");
            //maior valor da sequencia 
            EncontrarMaiorValor(valores);
            Console.WriteLine("=================================================\n");
            //menor valor da sequencia 
            EncontrarMenorNumero(valores);
            Console.WriteLine("=================================================\n");
            //Valor medio
            EncontrarMédia(valores);
            Console.WriteLine("=================================================\n");
            //Encontrar os 3 maiores valores da sequencia 
            EncontrarTresMaiores(valores);
            Console.WriteLine("=================================================\n");
            //Os numeros negativos 
            MostrarNumerosNegativos(valores);
            Console.WriteLine("=================================================\n");
            //Mostrar os valores da Sequencia 
            MostrarSequencia(valores);
            Console.WriteLine("=================================================\n");
            //Retirar um valor da sequencia
            RetirarValorSequencia(valores);
            Console.WriteLine("=================================================\n");
            Console.ReadLine();
        }

        private static void RetirarValorSequencia(int[] valores)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string valoresretirado = "";
            Console.WriteLine("Digite a posição que deseja retirar da sequencia:");
            int retirar = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < valores.Length; i++)
            {
                if (i == retirar-1)
                {
                    continue;
                }
                else
                valoresretirado = (valoresretirado + " " + valores[i].ToString());
            }
            Console.WriteLine(valoresretirado);
            Console.WriteLine("Deseja retirar numeros algum numero em específico?\n1-sim\n2-não");
            string valoresretirado2 = "";
            int opcao = Convert.ToInt32(Console.ReadLine());
            if (opcao == 1)
            {
                Console.WriteLine("Digite o valor que deseja retirar:");
                int retirar2 = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < valores.Length; i++)
                {
                    if (i == retirar -1 || valores[i] == retirar2)
                    {
                        continue;
                    }
                    else
                        valoresretirado2 = (valoresretirado2 + " " + valores[i].ToString());
                }
            }
            Console.WriteLine(valoresretirado2);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void MostrarNumerosNegativos(int[] valores)
        {
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine("Todos os valores negativos:");
            int quantidadeNegativos = 0;
            int contador = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                
                if(valores[i] < 0)
                {
                 quantidadeNegativos++;   
                }
                
            }
            int[] numerosNegativos = new int[quantidadeNegativos];
            for (int i = 0; i < valores.Length; i++)
            {
                if(valores[i] < 0)
                {
                    numerosNegativos[contador] =valores[i];
                    contador++;
                }
            }
            for (int i = 0; i < numerosNegativos.Length; i++)
            {
                Console.Write( numerosNegativos[i] + "\n");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void MostrarSequencia(int[] valores)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Todos os valores da Sequencia:");
            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine((i + 1) + "º valor: " + valores[i]);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void EncontrarTresMaiores(int[] valores)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            int[] tresMaiores = new int[10];
            for (int i = 0; i < 10; i++)
            {
                tresMaiores[i] = valores[i];
            }
            Array.Sort(tresMaiores);
            Array.Reverse(tresMaiores);
            Console.WriteLine("Os tres maiores:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write((i + 1) + "º " + tresMaiores[i] + "\n");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void EncontrarMédia(int[] valores)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            double media = 0;
            for (int i = 0; i < 10; i++)
            {
                media += valores[i];
            }
            media = media / valores.Length;
            Console.WriteLine("A MÉDIA dos valores é " + media);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void EncontrarMenorNumero(int[] valores)
        {
            int menorValor = valores[0];
            for (int i = 0; i < 10; i++)
            {
                if (valores[i] < menorValor)
                    menorValor = valores[i];
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("O MENOR Valor da Sequencia é " + menorValor);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void EncontrarMaiorValor(int[] valores)
        {
            int maiorValor=valores[0];
            for (int i = 0; i < 10; i++)
            {

                if (valores[i] > maiorValor)
                    maiorValor = valores[i];
            }
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine("O MAIOR Valor da Sequencia é " + maiorValor);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void DigitarOsValoresSequencia(int[] valores)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Digite uma sequencia de numeros:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o valor da posição " + (i + 1));
                valores[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
