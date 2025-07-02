bool isValid = true;
bool askAgain = true;

while (isValid)

{
    Console.WriteLine("Введіть ім'я:");
    string name = Console.ReadLine();

    Console.WriteLine("Введіть прізвище:");
    string surname = Console.ReadLine();

    // Перевірка на правильність вводу
    
    if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
    {
       Console.WriteLine("\nІм'я та прізвище не можуть бути порожніми.");
        Console.WriteLine();
        continue;
    }

    if (name.Length < 2 || surname.Length < 2)
    {
        Console.WriteLine("\nІм'я та прізвище повинні містити принаймні 2 символи.");
        continue;
    }

    string firstLetterOfName = name.Substring(0, 1).ToUpper();
    string firstLetterOfSurname = surname.Substring(0, 1).ToUpper();


    // Перевірка на те, чи ім'я та прізвище починаються з однієї літери
    if (firstLetterOfName == firstLetterOfSurname)
    {
        Console.WriteLine("\nІм'я та прізвище починаються з однієї літери.");
        isValid = true;
        askAgain = true;
    }

    if (firstLetterOfName != firstLetterOfSurname)
    {
        Console.WriteLine("\nІм'я та прізвище не починаються з однієї літери.");
        askAgain = true;
        isValid = false;
    }

    // Запит користувача, чи хоче він перевірити ще раз
    while (askAgain)
    {
        Console.WriteLine("\nБажаєте перевірити ще раз? (y/n)");

        string userAnswer = Console.ReadLine().ToLower();

        if (userAnswer == "n" || userAnswer == "no")
        {
            isValid = false;
            askAgain = false;
            Console.WriteLine("Дякуємо за використання програми!");
        }
        else if (userAnswer == "y" || userAnswer == "yes")
        {
            Console.Clear();
            isValid = true;
            askAgain = false;
        }
        else
        {
            Console.WriteLine("\nНевірний ввід. Будь ласка, введіть 'y' або 'n'.");    
            askAgain = true;
        }

    }
}


