using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern
{
    public interface IConstrutorHamburguer
    {
        void tipoCarne(string carne);
        void tipoPao(string pao);
        void tipoQueijo(string queijo);

        Hamburguer obterHamburguer();
    }
}
