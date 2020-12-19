using System;

namespace PasswordValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordValidator validation = new PasswordValidator();
            Console.WriteLine("The total of passwords valid is: {0}", validation.CountValidPasswords(false));
            Console.WriteLine("The total of passwords valid according to the new policy is: {0}", validation.CountValidPasswords(true));
        }
    }
}
