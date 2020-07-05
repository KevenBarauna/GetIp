//using IdentityModel.Client;
using System;
using System.Net;

namespace IP
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n");
            Console.WriteLine("Dados do computador:");
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Nome do host: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                string NomePc = Dns.GetHostName();
                Console.WriteLine(NomePc.ToString());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(" ERRO: ");
                Console.Write(e.Message);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            try {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("IP de rede:");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(" IPV6 ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string nome = Dns.GetHostName();
            IPAddress[] ip = Dns.GetHostAddresses(nome);
            Console.WriteLine(ip[1].ToString());
            }
            catch (Exception e) {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(" ERRO: ");
                Console.Write(e.Message);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("\n\n");

        }
    }
}
