using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var hamburguer = new ConstrutorHamburguer();
            var diretor = new Diretor(hamburguer);

            diretor.ConstruirHamburguer("bovina","italiano","parmezao");

            var meuHamburguer = hamburguer.obterHamburguer();

            Console.WriteLine($"Pão de hamburguer: {meuHamburguer.pao}\nCarne: {meuHamburguer.carne}\nQueijo: {meuHamburguer.queijo}");


        }
    }
}
