bool isValid = true;

while (isValid)

{
    Console.WriteLine("Введіть ім'я:");
    string name = Console.ReadLine();

    Console.WriteLine("Введіть прізвище:");
    string surname = Console.ReadLine();

    string firstLetterOfName = name.Substring(0, 1).ToUpper();
    string firstLetterOfSurname = surname.Substring(0, 1).ToUpper();

    // Перевірка на правильність вводу
    if (name.Length < 2 || surname.Length < 2)
    {
        Console.WriteLine("\nІм'я та прізвище повинні містити принаймні 2 символи.");
        continue; 
    }

    
    if (firstLetterOfName == firstLetterOfSurname)
    {
        Console.WriteLine("\nПерше ім'я та прізвище починаються з однієї літери.");
    }

    else
    {
        Console.WriteLine("\nПерше ім'я та прізвище не починаються з однієї літери.");
    }

    // Запит користувача, чи хоче він перевірити ще раз
    {
        Console.WriteLine("\nБажаєте перевірити ще раз? (y/n)");

        string userAnswer = Console.ReadLine().ToLower();
        if (userAnswer == "n" || userAnswer == "no")
        {
            isValid = false;
            Console.WriteLine("Дякуємо за використання програми!");
        }
        else if (userAnswer == "y" || userAnswer == "yes")
        {
            Console.Clear();
            isValid = true;
        }

        else
        {
            Console.WriteLine("\nНевірний ввід. Будь ласка, введіть 'y' або 'n'.");
        }
    }
}


