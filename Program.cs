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
            var diretor2 = new Diretor(hamburguer);

            diretor.ConstruirHamburguer("bovina","italiano","parmezao");
            diretor2.ConstruirHamburguer("Suina", "tres queijos", "chedar");

            var meuHamburguer = hamburguer.obterHamburguer();
            var seuHamburguer = hamburguer.obterHamburguer();

            Console.WriteLine($"Pão de hamburguer: {meuHamburguer.pao}\nCarne: {meuHamburguer.carne}\nQueijo: {meuHamburguer.queijo}");
            Console.WriteLine($"Pão de hamburguer: {seuHamburguer.pao}\nCarne: {seuHamburguer.carne}\nQueijo: {seuHamburguer.queijo}");


        }
    }
}
