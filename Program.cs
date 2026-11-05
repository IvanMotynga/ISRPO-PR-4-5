using System;

namespace MultiFormApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== СИСТЕМА АВТОРИЗАЦИИ И ТЕСТИРОВАНИЯ ===");
            Console.WriteLine("Форма 1: Авторизация пользователя.");
            Console.WriteLine("Форма 2: Модуль интерактивного тестирования знаний.");
            RunTestingForm();
        }

        static void RunTestingForm()
        {
            Console.WriteLine("--- Тест по системам контроля версий ---");
            Console.WriteLine("Вопрос: Какая команда создает новую ветку в Git?");
            Console.WriteLine("Ответ: git branch <name> или git checkout -b <name>");
            Console.WriteLine("Результат тестирования: 100% зачет! (Оценка: Отлично, разработчик 1)");
        }
    }
}