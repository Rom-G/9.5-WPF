using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversWords
{
    public class Program
    {

        /// <summary>
        /// Метод, разделяющий текст на слова.
        /// </summary>
        /// <param name="text">Тект введённый пользователем.</param>
        /// <returns>Массив слов взятых из введённого текста.</returns>
        static string[] SplitText(string text)
        {
            char[] traps = new char[] { ' ', ',', '.', '?', '!', '\t' };
            string[] words = text.Split(traps, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }

        /// <summary>
        /// Метод, выводящий слова в обратной последовательности.
        /// </summary>
        /// <param name="text">Предложение, в котором необходимо переставить слова.</param>
        public static string Reverse(string text)
        {
            string[] words = SplitText(text);
            Array.Reverse(words);

            string resultString = string.Join(" ", words);

            return resultString;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Реверс слов в предложении. Введите предложение: ");

            Console.WriteLine($"\nВот что получилось:\n" + (Reverse(Console.ReadLine())));
            Console.ReadKey();
        }
    }
}
