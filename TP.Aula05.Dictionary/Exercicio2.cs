using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.Aula05.Dictionary
{
    public class Exercicio2
    {
        //Usando dicionários, faça um robô que traduza uma linha de comando c#
        //para seu respectivo comando em português usando a tabela abaixo.
        //Alguns exemplos estão listados ao final.
        public void ExercicioDois()
        {
            Dictionary<string, string> tradutor = new Dictionary<string, string>();
            tradutor.Add("if", "se");
            tradutor.Add("while", "enquanto");
            tradutor.Add(">", "maior que");
            tradutor.Add("<", "menor que");
            tradutor.Add(">=", "maior igual que");
            tradutor.Add("<=", "menor igual que");
            tradutor.Add("==", "igual a");
            tradutor.Add("!=", "diferente de");
           
            Console.Write("Digite o comando que deseja traduzir: ");
            string linhaComando = Console.ReadLine().ToLower();
            string[] comandoSeparado = linhaComando.Split(" ");
            foreach (string s in comandoSeparado)
            {
                if (tradutor.ContainsKey(s))
                {
                    Console.Write(tradutor.GetValueOrDefault(s));
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(s + " ");
                }
            }
            Console.WriteLine("\nDeseja fazer outra tradução? (s/n)");
            if (Console.ReadLine() == "s")
            {
                Console.Clear();
                ExercicioDois();
            }
            else
            {
                Console.WriteLine("\nDeseja voltar ao Menu? (s/n)");
                if (Console.ReadLine() == "s")
                {
                    Console.Clear();
                    Menu telaMenu = new Menu();
                    telaMenu.MenuSelect();
                }
            }
        }
    }
}
