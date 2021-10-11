using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_MVC.FormataValores
{
    public class FormatarTexto
    {
        public static string FormataMaiusculo(string valor)
        {
            return valor.ToUpper().Trim();
        } 
    }
}
