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

                if (Btn == "1")
                {
                    fila.Cadastro();
                }
                else if (Btn == "2")
                {
                    fila.Listar();
                }
                else if (Btn == "3")
                {
                    fila.Atender();
                }
                else if (Btn == "4")
                {
                    fila.Alterar();
                }
                else if (Btn == "q")
                {
                    Loop = false;
                    Console.WriteLine("");
                    Console.WriteLine("...Encerrando Progama...");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("//--Comando Invalido--//");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
