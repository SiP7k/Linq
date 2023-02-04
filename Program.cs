using Linq;
using System;
using System.Runtime.InteropServices;

namespace Linq
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            var sortedContacts = phoneBook.OrderBy(x => x.Name).ThenBy(x => x.LastName);

            bool isWorking = true;

            while (isWorking)
            {
                Console.WriteLine("Введите номер страницы (1-3) для вывода контактов или команду exit для выхода из контактов");

                switch (Console.ReadLine())
                {
                    case "1":
                        foreach (var contact in sortedContacts.Take(2))
                        {
                            Console.WriteLine(contact.Name + " " + contact.LastName + ": " + contact.PhoneNumber);
                        }
                        break;
                    case "2":
                        foreach (var contact in sortedContacts.Skip(2).Take(2))
                        {
                            Console.WriteLine(contact.Name + " " + contact.LastName + ": " + contact.PhoneNumber);
                        }
                        break;
                    case "3":
                        foreach (var contact in sortedContacts.Skip(4))
                        {
                            Console.WriteLine(contact.Name + " " + contact.LastName + ": " + contact.PhoneNumber);
                        }
                        break;
                    case "exit":
                        isWorking = false;
                        Console.WriteLine("Вы вышли из программы");
                        break;
                    default:
                        Console.WriteLine("Неверный ввод данных");
                        break;
                }
            }
        }

    }
}