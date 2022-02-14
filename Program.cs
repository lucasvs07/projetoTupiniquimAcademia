using System;

namespace tupiniquimAula.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //identificação de variáveis
            Console.WriteLine("PROJETO TUPINIQUIM");
            Console.WriteLine();
            Console.WriteLine("Para a movimentação de ambos os robôs, considere a área como um plano cartesiano.");
            Console.WriteLine("Você deve usar as letras E para virar o robô para a esquerda e D para virar a direita.");
            Console.WriteLine("E usar as letras N, S, L e O. Para indicar o sentido que a face do robô está virada.");
            Console.WriteLine("Sendo, respectivamente, Norte, Sul, Leste e Oeste.");
            Console.WriteLine();

            Console.WriteLine("Defina o tamanho da área a ser explorada:");
            Console.WriteLine("Qual a coordenada X do canto superior direito da área:");
            string xMaximo = Console.ReadLine();
            Console.WriteLine("Qual a coordenada Y do canto superior direito da área:");
            string yMaximo = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Para a movimentação do robô I:");
            Console.WriteLine("Qual a coordenada X onde está o robô:");
            string strlocalizacoXRobo1 = Console.ReadLine();
            int localizacaoXRobo1 = Convert.ToInt32(strlocalizacoXRobo1);

            Console.WriteLine("Qual a coordenada Y onde está o robô:");
            string strlocalizacaoYRobo1 = Console.ReadLine();
            int localizacaoYRobo1 = Convert.ToInt32(strlocalizacaoYRobo1);

            Console.WriteLine("Qual o sentido para onde o robô está virado:");
            string strsentidoRobo1 = Console.ReadLine();
            char sentidoRobo1 = Convert.ToChar(strsentidoRobo1);

            Console.WriteLine();

            Console.WriteLine("Digite o comando para a movimentação do robô 1:");
            string comandoRobo1 = Console.ReadLine();

            char[] instrucoes1 = comandoRobo1.ToCharArray();

            for(int posicao1 = 0; posicao1 < instrucoes1.Length; posicao1++)
            {
               if (instrucoes1[posicao1] == 'E' && sentidoRobo1 == 'N')
                    sentidoRobo1 = 'O';

                else if (instrucoes1[posicao1] == 'D' && sentidoRobo1 == 'N')
                    sentidoRobo1 = 'L';

                else if (instrucoes1[posicao1] == 'E' && sentidoRobo1 == 'S')
                    sentidoRobo1 = 'L';

                else if (instrucoes1[posicao1] == 'D' && sentidoRobo1 == 'S')
                    sentidoRobo1 = 'O';

                else if (instrucoes1[posicao1] == 'E' && sentidoRobo1 == 'L')
                    sentidoRobo1 = 'N';

                else if (instrucoes1[posicao1] == 'D' && sentidoRobo1 == 'L')
                    sentidoRobo1 = 'S';

                else if (instrucoes1[posicao1] == 'E' && sentidoRobo1 == 'O')
                    sentidoRobo1 = 'S';

                else if (instrucoes1[posicao1] == 'D' && sentidoRobo1 == 'O')
                    sentidoRobo1 = 'N';

                if (instrucoes1[posicao1] == 'M')
                {
                    
                    if (sentidoRobo1 == 'N')
                        localizacaoYRobo1 = localizacaoYRobo1 + 1;

                    else if (sentidoRobo1 == 'S')
                        localizacaoYRobo1 = localizacaoYRobo1 - 1;

                    else if (sentidoRobo1 == 'L')
                        localizacaoXRobo1 = localizacaoXRobo1 + 1;

                    else if (sentidoRobo1 == 'O')
                        localizacaoXRobo1 = localizacaoXRobo1 - 1;
                   
                }
                
                
            }

            Console.WriteLine(localizacaoXRobo1 + ", " + localizacaoYRobo1 + ", " + sentidoRobo1);
            Console.ReadKey();





        }
    }
}
