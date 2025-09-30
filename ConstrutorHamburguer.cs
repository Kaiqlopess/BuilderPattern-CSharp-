using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern
{
    public class ConstrutorHamburguer : IConstrutorHamburguer
    {
        private Hamburguer _hamburguer = new Hamburguer();

        public void tipoCarne(string carne)
        {
            _hamburguer.carne = carne;
        }

        public void tipoPao(string pao)
        {
            _hamburguer.pao = pao;
        }

        public void tipoQueijo(string queijo)
        {
            _hamburguer.queijo = queijo;
        }

        public Hamburguer obterHamburguer()
        {
            return _hamburguer;
        }

    }
}
