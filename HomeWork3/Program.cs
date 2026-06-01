namespace HomeWork3
{
    class Program
    {
        static void Main()
        {
            DoLoginPasswordVerification();
            VowelsCount();
            GradeByScore();
        }
        static void DoLoginPasswordVerification()
        {
            string correctLogin = "Alex";
            string correctPassword = "qwerty";
            int remainingAttempts = 3; //amounts number
            bool isLoggedIn = false;

            do
            {
                Console.WriteLine("Input Login:");
                Console.WriteLine($"{remainingAttempts} attempts left.");
                string login = Console.ReadLine() ?? string.Empty;

                Console.WriteLine("Input Password:");
                string password = Console.ReadLine() ?? string.Empty;

                if (correctLogin == login && correctPassword == password)
                {
                    isLoggedIn = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Login or Password!");
                    remainingAttempts--;
                }
            } while (remainingAttempts != 0);

            if (isLoggedIn)
            {
                Console.WriteLine("Success sign in!");
            }
            else
            {
                Console.WriteLine("No more attempts left!");
            }
        }
        static void VowelsCount()
        {

            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine() ?? string.Empty; 
            string lowerText = text.ToLower();

            int vowelsCount = 0;

            char[] vawelsArray = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };

            foreach (char stringItem in lowerText)
            {
                for (int i = 0; i < vawelsArray.Length; i++)
                {
                    if (stringItem == vawelsArray[i])
                    {
                        vowelsCount++;
                    }
                }
            }

            Console.WriteLine($"Всего гласных: {vowelsCount}.");

        }
        static void GradeByScore()
        {
            int score = 80;

            string grade = score switch
            {
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                _ => "F"
            };

            Console.WriteLine(grade);

        }
    }
}
