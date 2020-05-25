using System;
using System.Collections.Generic;
using System.Text;

namespace Aluguel
{
    class Quartos
    {
        public string NomeEstudante { get;  set; }
        public string EmailEstudante { get;  set; }
        public int nQuarto { get;  set; }

        public Quartos(string nome, string email, int quarto)
        {
            NomeEstudante = nome;
            EmailEstudante = email;
            nQuarto = quarto;
        }
    }
}
