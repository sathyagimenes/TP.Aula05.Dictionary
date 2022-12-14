using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.Aula05.Dictionary
{
    public class Exercicio1
    {

        public void ExercicioUm()
        {
            // Enunciado Exercício 1
            // Faça um script que leia uma frase do usuário e use um dicionário que
            // apresente as vogais e a frequência de sua aparição na frase.

            Console.Write("Escreva uma frase para descobrir sua quantidade de vogais: ");
            string frase = Console.ReadLine().ToLower().Normalize(System.Text.NormalizationForm.FormD);
            char[] letras = frase.ToCharArray();
            int freqA = 0;
            int freqE = 0;
            int freqI = 0;
            int freqO = 0;
            int freqU = 0;
            foreach (char c in letras)
            {
                switch (c)
                {
                    case 'a':
                        freqA++;
                        break;
                    case 'e':
                        freqE++;
                        break;
                    case 'i':
                        freqI++;
                        break;
                    case 'o':
                        freqO++;
                        break;
                    case 'u':
                        freqU++;
                        break;
                }
            }

            Dictionary<char, int> frequenciaVogal = new Dictionary<char, int>();
            frequenciaVogal.Add('a', freqA);
            frequenciaVogal.Add('e', freqE);
            frequenciaVogal.Add('i', freqI);
            frequenciaVogal.Add('o', freqO);
            frequenciaVogal.Add('u', freqU);
            foreach (KeyValuePair<char, int> pair in frequenciaVogal)
            {
                Console.WriteLine($"A letra {pair.Key} aparece {pair.Value} vezes na frase");
            }
            Console.WriteLine("\nDeseja fazer outra consulta? (s/n)");
            if (Console.ReadLine() == "s")
            {
                Console.Clear();
                ExercicioUm();
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
