using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2.    Обязательная задача*. Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. 
             * Знаки препинания не используются. Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра
             * (пример палиндрома – «А роза упала на лапу Азора»).*/
            
            Console.WriteLine("Введите строку текста на проверку палиндрома:");
            string inputString = Console.ReadLine();
            
            inputString = inputString.ToLowerInvariant(); //Строку в нижний регистр
            inputString = inputString.Replace(" ", "");  //Убираем пробелы
            int numberChar = inputString.Length; // Длина строки
            char[] array = inputString.ToCharArray(); //создаем символьный массив
            int j = numberChar-1;
            bool flag = false;

            for (int i = 0; i < numberChar/2; i++) //проверка на совпадение первого и последнего символа
            {
                if (array[i]!=array[j])
                {
                    Console.WriteLine("Это не палиндром !");
                    flag = true;
                    break;
                }
                j--;

            }

            if (flag == false) //Вывод результата, если все ОК
            {
                Console.WriteLine("Введенный текст является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
