using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitText
{
    public class Program
    {
        /// <summary>
        /// Метод, разделяющий текст на слова.
        /// </summary>
        /// <param name="text">Тект введённый пользователем.</param>
        /// <returns>Массив слов взятых из введённого текста.</returns>
        public static string[] SplitText(string text)
        {
            char[] traps = new char[] {' ', ',', '.', '?', '!', '\t'};
            string[] words = text.Split(traps, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }

        /// <summary>
        /// Метод, выводящий слова в консоль построчно из массива.
        /// </summary>
        /// <param name="words">Массив слов.</param>
        static void PrintWords(string[] words) 
        {
            Console.WriteLine("\nРезультат: ");
            foreach (string word in words) 
            { 
                Console.WriteLine(word);
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Введите предложение для вывода слов построчно: ");
             
            PrintWords(SplitText(Console.ReadLine()));

            Console.WriteLine("\nСпасибо за внимание!");
            Console.ReadKey();
        }
    }
}
