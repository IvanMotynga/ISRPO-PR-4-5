using System;

namespace MultiFormApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== СИСТЕМА АВТОРИЗАЦИИ И ТЕСТИРОВАНИЯ ===");
            Console.WriteLine("Форма 1: Авторизация пользователя.");
            Console.Write("Введите логин: ");
            string login = "student";
            Console.WriteLine(login);
            Console.WriteLine("Успешный вход в систему!");
        }
    }
}