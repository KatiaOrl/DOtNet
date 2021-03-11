using System;

namespace Zadanie1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программирование в среде DOtNet");
            Console.WriteLine("Лкекция №1          Задание 1-1");
            Console.WriteLine("Связный список:создание, удаление, добавление элементов, реверс списка");
            Console.WriteLine("Выполнила: Орлова Е.В.  гр 7305");
            LinkedList<string> linkedList = new LinkedList<string>();

            Console.WriteLine(new string('-', 40));
            //Ввод элементов списка
            Console.Write("Введите элементы списка: ");
            var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            
            // добавление элементов
            Console.WriteLine("Добавление элементов:");
            for (int i = 0; i < parts.Length; i++) {
                linkedList.Add(parts[i]);
            }
            
            // выводим элементы
            foreach(var item in linkedList) {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Удаление элементов");
            // удаляем элемент
            Console.Write("Введите элементы для удаления: ");
            parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            
            for (int i = 0; i < parts.Length; i++) {
                Console.WriteLine($"Удаляем элемент: {parts[i]} - {(linkedList.Remove(parts[i])  ? "ok" : "отсутствует")}");
            }
            linkedList.printList();

            // проверяем наличие элемента
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Проверяем наличие элемента");
            Console.Write("Введите элементы для проверки: ");
            parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            
            for (int i = 0; i < parts.Length; i++) {
                Console.WriteLine($"Элемент: {parts[i]} {(linkedList.Contains(parts[i])  ? "присутствует" : "отсутствует")}");
            }
            
            // добавляем элемент в начало            
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Добавляем элементы в начало");
            Console.Write("Введите элементы для добавления в начало: ");
            parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            
            for (int i = 0; i < parts.Length; i++) {
                linkedList.AppendFirst(parts[i]);
            }
            linkedList.printList();

            // Выводим Список в обратном порядке            
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Список в обратном порядке:");
            linkedList.printReversed();
        }
    }
}