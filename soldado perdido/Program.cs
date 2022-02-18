using System;

namespace sargentooperdido

{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool resp;
            do
            {
                Console.WriteLine("Digite a coordenada x do canto superior da área: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a cordenada y do canto superior da área: ");
                double y = Convert.ToDouble(Console.ReadLine());

                string instrucoes;
                double px = 0;
                double py = 0;
                char pontocardeal;

                Console.Write("Digite a posição inical da coordenada x do sargento: ");
                px = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a posição inical da coordenada y do sargento: ");
                py = Convert.ToDouble(Console.ReadLine());

                do
                {
                    Console.WriteLine("Digite o dirção inicial do sargento: (N-norte, S-sul, L-leste, O-oeste");
                    pontocardeal = Convert.ToChar(Console.ReadLine());

                }
                while (pontocardeal != 'N' && pontocardeal != 'S' && pontocardeal != 'L' && pontocardeal != 'O');


                do
                {
                    Console.WriteLine("Digite as instruções do sargento: (M-mover, E-girar pra esquerda, D-girar para a direita ");
                    instrucoes = Console.ReadLine();

                } while (instrucoes != "M" && instrucoes != "E" && instrucoes != "D");

                char[] ed = instrucoes.ToCharArray();


                for (int i = 0; i < ed.Length; i++)
                {
                    while (ed[i] == 'E')
                    {
                        switch (pontocardeal)
                        {
                            case 'N':
                                pontocardeal = 'O';
                                break;
                            case 'S':
                                pontocardeal = 'L';
                                break;
                            case 'L':
                                pontocardeal = 'N';
                                break;
                            case 'O':
                                pontocardeal = 'S';
                                break;
                        }
                        break;
                    }


                    while (ed[i] == 'D')
                    {
                        switch (pontocardeal)
                        {
                            case 'N':
                                pontocardeal = 'L';
                                break;
                            case 'S':
                                pontocardeal = 'O';
                                break;
                            case 'L':
                                pontocardeal = 'S';
                                break;
                            case 'O':
                                pontocardeal = 'N';
                                break;
                        }
                        break;
                    }


                    while (ed[i] == 'M')
                    {
                        if (pontocardeal == 'N')
                        {
                            py = py + 1;
                            break;

                        }
                        else
                        {
                            if (pontocardeal == 'L')
                            {
                                px = px + 1;
                                break;
                            }
                            else
                            {
                                if (pontocardeal == 'S')
                                {
                                    py = py - 1;
                                    break;
                                }
                                else
                                {
                                    if (pontocardeal == 'O')
                                    {
                                        px = px - 1;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                Console.WriteLine(px + " " + py + " " + pontocardeal);

                Console.Write("Deseja instruir mais um sargento? Digite S para sim e N para não: ");
                char continuar = Convert.ToChar(Console.ReadLine());

                resp = continuar == 'S';









            } while (resp == true);

        }
    }
}
