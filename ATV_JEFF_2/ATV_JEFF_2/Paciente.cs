using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV_JEFF_2
{
    internal class Paciente
    { 
            public string Nome;
            public int Idade;
            public bool Preferencial;

        public Paciente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            Preferencial = idade >= 60;
        }
    }
}