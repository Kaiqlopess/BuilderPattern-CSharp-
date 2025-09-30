using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern
{
    internal class Diretor
    { 
        private IConstrutorHamburguer _construtorHamburguer;

        public Diretor(IConstrutorHamburguer construtorHamburguer)
        {
            _construtorHamburguer = construtorHamburguer;
        }

        public void ConstruirHamburguer(string carne,string pao, string queijo)
        {
            _construtorHamburguer.tipoCarne(carne);
            _construtorHamburguer.tipoPao(pao);
            _construtorHamburguer.tipoQueijo(queijo);
        }
    }
}
