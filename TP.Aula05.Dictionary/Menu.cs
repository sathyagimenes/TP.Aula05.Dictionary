using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.Aula05.Dictionary
{
    internal class Menu
    {
        public void MenuSelect()
        {
            string answer;

            do
            {
                Console.WriteLine("Qual exercicio deseja testar? (1/2)");
                answer = Console.ReadLine();
            } while (answer != "1" && answer != "2");
            if (answer == "1")
            {
                Exercicio1 exercutarExUm = new Exercicio1();
                exercutarExUm.ExercicioUm();
            }
            else if (answer == "2")
            {
                Exercicio2 exercutarExDois = new Exercicio2();
                exercutarExDois.ExercicioDois();
            }
        }
    }
}
