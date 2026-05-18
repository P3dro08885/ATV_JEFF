using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV_JEFF_2
{
    internal class Fila
    {
        Paciente[] fila = new Paciente[100];
        int PacienteNum = 0;

        public void Cadastro()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Paciente paciente = new Paciente(nome, idade);

            if (idade >= 60)
            {
                for (int i = PacienteNum; i > 0; i--)
                {
                    fila[i] = fila[i - 1];
                }

                fila[0] = paciente;
            }
            else
            {
                fila[PacienteNum] = paciente;
            }

            PacienteNum++;

            Console.WriteLine("Paciente cadastrado!");
            Console.WriteLine(" ");
        }


        public void Listar()
        {
            if (PacienteNum == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("FIla Vazia");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                for (int i = 0; i < PacienteNum; i++)
                {
                    Console.WriteLine("Paciente numero " + i + ":" + fila[i].Nome + " Idade:" + fila[i].Idade);
                }

                Console.WriteLine("");
            }
        }

        public void Atender()
        {
            if (PacienteNum == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Fila vazia");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Atendendo: " + fila[0].Nome);
                Console.WriteLine("...");
                Console.WriteLine("Paciente Atendido(a)");
                Console.WriteLine("...");

                for (int i = 0; i < PacienteNum - 1; i++)
                {
                    fila[i] = fila[i + 1];
                }

                PacienteNum--;
            }
        }
        public void Alterar()
        {
            if (PacienteNum == 0)
            {
                Console.WriteLine("...");
                Console.WriteLine("Fila vazia!");
                Console.WriteLine("...");
            }

            Listar();

            Console.Write("Digite a posição do paciente: ");
            int pos = int.Parse(Console.ReadLine());
            if (pos < 0 || pos >= PacienteNum)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Posição inválida!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
            }
            else
            {

                Console.Write("Novo nome: ");
                fila[pos].Nome = Console.ReadLine();

                Console.Write("Nova idade: ");
                fila[pos].Idade = int.Parse(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("Dados alterados!");
                Console.WriteLine("");
            }
        }
    }
}