using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Control_Ver_Plus
{
    class Program
    {
        public static int qtd = 100;
        public static string[] Nomes = new string[qtd];
        public static int[] Bancs = new int[qtd];

        static void Main(string[] args)
        {
            int i, Banc, opcao_menu, varassento;
            string Doc;
            DateTime dta = DateTime.Now;

            for (i = 0; i < qtd; i++)
            {
                Console.WriteLine();
                Console.WriteLine("********************************************************");
                Console.WriteLine("*            Sistema I-Control Plus                    *");
                Console.WriteLine("********************************************************");
                Console.WriteLine("*             INFORME O CÓDIGO DA FUNÇÃO               *");
                Console.WriteLine("*                                                      *");
                Console.WriteLine("*            1 - Reservar Para Professor               *");
                Console.WriteLine("*            2 - Reservar Para convidado               *");
                Console.WriteLine("*            3 - Reservar Para PcD                     *");
                Console.WriteLine("*            4 - Reservar para público em geral        *");
                Console.WriteLine("*            5 - Consultar cadeiras reservadas         *");
                Console.WriteLine("*            6 - Sortear cadeira                       *");
                Console.WriteLine("*                                                      *");
                Console.WriteLine("********************************************************");
                Console.WriteLine();

                string opcao_digitada = Convert.ToString(Console.ReadLine());

                opcao_menu = Convert.ToInt32(opcao_digitada);

                if (opcao_menu < 1 || opcao_menu > 6)
                {
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();

                    continue;
                }

                switch (opcao_menu)
                {

                    case 1:
                        while (true)
                        {
                            if (opcao_menu >= 1 || opcao_menu <= 4)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Informe seu nome: ");
                                Nomes[i] = Console.ReadLine();

                                Console.WriteLine();
                                Console.WriteLine("Informe seu documento :");
                                Doc = Console.ReadLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Informe o assento de 1 a 10");
                            varassento = Convert.ToInt32(Console.ReadLine());
                            if (Verifica(varassento, opcao_menu) == true)
                            {
                                Console.WriteLine();
                                Bancs[i] = varassento;
                                Console.WriteLine(Nomes[i] + " Seu assento é " + Bancs[i] + "   " + dta);
                                Console.WriteLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine();
                                Bancs[i] = varassento;
                                Console.WriteLine("Erro - O assento já está reservado para outra pessoa!");
                                Console.WriteLine("Pressione qualquer tecla para continuar...");
                                Console.ReadKey();
                                break;
                            }
                        }
                        break;

                    case 2:
                        while (true)
                        {
                            if (opcao_menu >= 1 || opcao_menu <= 4)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Informe seu nome: ");
                                Nomes[i] = Console.ReadLine();

                                Console.WriteLine();
                                Console.WriteLine("Informe seu documento :");
                                Doc = Console.ReadLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Informe o assento de 11 a 20");
                            varassento = Convert.ToInt32(Console.ReadLine());

                            if (Verifica(varassento, opcao_menu) == true)
                            {
                                Console.WriteLine();
                                Bancs[i] = varassento;
                                Console.WriteLine(Nomes[i] + " Seu assento é " + Bancs[i] + "   " + dta);
                                Console.WriteLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine();
                                Bancs[i] = varassento;
                                Console.WriteLine("Erro - O assento já está reservado para outra pessoa!");
                                Console.WriteLine("Pressione qualquer tecla para continuar...");
                                Console.ReadKey();
                                break;
                            }

                        }
                        break;

                    case 3:
                        while (true)
                        {
                            if (opcao_menu >= 1 || opcao_menu <= 4)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Informe seu nome: ");
                                Nomes[i] = Console.ReadLine();

                                Console.WriteLine();
                                Console.WriteLine("Informe seu documento :");
                                Doc = Console.ReadLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Informe o assento de 21 a 30");
                            varassento = Convert.ToInt32(Console.ReadLine());
                            if (Verifica(varassento, opcao_menu) == true)
                            {
                                Console.WriteLine();
                                Bancs[i] = varassento;
                                Console.WriteLine(Nomes[i] + " Seu assento é " + Bancs[i] + "   " + dta);
                                Console.WriteLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine();
                                Bancs[i] = varassento;
                                Console.WriteLine("Erro - O assento já está reservado para outra pessoa!");
                                Console.WriteLine("Pressione qualquer tecla para continuar...");
                                Console.ReadKey();
                                break;
                            }
                        }
                        break;

                    case 4:
                        while (true)
                        {
                            if (opcao_menu >= 1 || opcao_menu <= 4)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Informe seu nome: ");
                                Nomes[i] = Console.ReadLine();

                                Console.WriteLine();
                                Console.WriteLine("Informe seu documento :");
                                Doc = Console.ReadLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Informe o assento de 31 a 100");
                            varassento = Convert.ToInt32(Console.ReadLine());
                            if (Verifica(varassento, opcao_menu) == true)
                            {
                                Console.WriteLine();
                                Bancs[i] = varassento;
                                Console.WriteLine(Nomes[i] + " Seu assento é " + Bancs[i] + "   " + dta);
                                Console.WriteLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine();
                                Bancs[i] = varassento;
                                Console.WriteLine("Erro - O assento já está reservado para outra pessoa!");
                                Console.WriteLine("Pressione qualquer tecla para continuar...");
                                Console.ReadKey();
                                break;
                            }
                        }
                        break;


                    case 5:
                        while (true)
                        {

                            Console.Write(" Informe o assento que deseja informação:");
                            Banc = Convert.ToInt32(Console.ReadLine());

                            for (i = 0; i <= 4; i++)
                            {
                                if (Bancs[i] == Banc)
                                {
                                    Console.WriteLine(" Assento " + Banc + " é :" + Nomes[i]);

                                }



                            }
                            break;
                        }
                        break;

                    //sorteio
                    case 6:
                        while (true)
                        {
                            int assento_sorteado = 0;
                            Random rnd = new Random();
                            assento_sorteado = rnd.Next(i);
                                                       
                            

                                if (!(Bancs[assento_sorteado] >= 11 && Bancs[assento_sorteado] <= 20))
                                {
                                    Console.WriteLine(" Numer sorteado = banco:" + Bancs[assento_sorteado] + " nome :" + Nomes[assento_sorteado]);
                                    Console.ReadKey();
                                    Environment.Exit(-1);

                                }
                            

                            
                           

                        }

                }

                Console.ReadKey();
                Console.Clear();


            }


        }

        static Boolean Verifica(int x, int PPP)
        {
            Boolean esta_disponivel;
            Boolean continua;
            int i;
            continua = false;

            if (PPP == 1)
            {
                if (x >= 1 && x <= 10)
                {
                    continua = true;
                }
            }
            else if (PPP == 2)
            {
                if (x >= 11 && x <= 20)
                {
                    continua = true;
                }
            }
            else if (PPP == 3)
            {
                if (x >= 21 && x <= 30)
                {
                    continua = true;
                }
            }
            else
            {
                if (x >= 31 && x <= 100)
                {
                    continua = true;
                }
            }


            esta_disponivel = continua;
            if (continua)
            {
                for (i = 0; i < qtd; i++)
                {
                    if (x == Bancs[i])
                    {
                        esta_disponivel = false;
                        break;
                    }
                }
            }

            return esta_disponivel;
        }

    }
} 
