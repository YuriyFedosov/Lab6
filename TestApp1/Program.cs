using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.    Обязательная задача*. Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. 
             * Знаки препинания не используются. Найти самое длинное слово в строке.*/
            
            Console.WriteLine("Введите строку для оценки длины слов в выбора наибольшего по длине слова:");
            string inputString = Console.ReadLine();
            string[] wordList = inputString.Split(); //массив слов

            int totalChar = wordList.Length;
            int wawa = wordList[0].Length; //Начальная длина первого слова для сравнения
            int wawaPos = 0;
            for (int i = 0; i < totalChar; i++) //Определяем наличие более длинных, чем первый
            {
                if(wordList[i].Length > wawa)
                {
                    wawa=wordList[i].Length;
                    wawaPos = i;
                }
                
            }
            Console.WriteLine("Слово \"{0}\" является самым длинным в строке и содержит {1} символов", wordList[wawaPos], wawa);  //Результат
            Console.ReadKey();

        }
    }
}
