using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV_JEFF_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Btn;
            bool Loop;
            Loop = true;
            Fila fila = new Fila();

            while (Loop == true)
            {
                Console.WriteLine("--Menu Pacientes--");

                Console.WriteLine("[1] Cadastrar Paciente na Fila");
                Console.WriteLine("[2] Listar Paciente na Fila");
                Console.WriteLine("[3] Atender Paciente na Fila");
                Console.WriteLine("[4] Alterar Dados de Paciente na Fila");
                Console.WriteLine("[Q] Sair");
                Console.WriteLine("----------");

                Btn = Console.ReadLine();

                switch (Btn)
                {
                    case
                        "1":
                       fila.Cadastro();
                        break;
                    case
                        "2":
                            fila.Listar();
                        break;
                    case
                        "3":
                            fila.Atender();
                        break;
                    case
                        "4":
                              fila.Alterar();
                        break;
                    case
                        "q":
                    Loop = false;
                        Console.WriteLine("");
                        Console.WriteLine("...Encerrando Progama...");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("//--Comando Invalido--//");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
        }
    }
}
