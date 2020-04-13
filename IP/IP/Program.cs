//using IdentityModel.Client;
using System;
using System.Net;

namespace IP
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("177.16.242.3");

            Console.WriteLine("Seu IP da rede: IPV6");
            string nome = Dns.GetHostName();
            IPAddress[] ip = Dns.GetHostAddresses(nome);
            Console.WriteLine(ip[1].ToString());

            Console.WriteLine("NomePC");
            string NomePc = Dns.GetHostName();
            Console.WriteLine(NomePc.ToString());

            // String IP = Request.UserHostAddress;
        }
    }
}
