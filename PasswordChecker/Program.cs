using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            int score = 0;
            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;
            bool hasSpecial = false;

            string specialChars = "!@#$%^&*()_-+={[}]|:;'<,>.?/";

            // Check password properties
            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                else if (char.IsLower(c)) hasLower = true;
                else if (char.IsDigit(c)) hasDigit = true;
                else if (specialChars.Contains(c)) hasSpecial = true;
            }

            // Add to score based on checks
            if (password.Length >= 8) score++;
            if (hasUpper) score++;
            if (hasLower) score++;
            if (hasDigit) score++;
            if (hasSpecial) score++;

            // Display results
            switch (score)
            {
                case 1:
                    Console.WriteLine("Your password strength is weak.");
                    break;
                case 2:
                    Console.WriteLine("Your password strength is medium.");
                    break;
                case 3:
                    Console.WriteLine("Your password strength is strong.");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Your password is extremely strong!");
                    break;
            }

            Console.WriteLine($"Score: {score}/5");
        }
    }
}
