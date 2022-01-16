using System;
using PasswordValidatorWithExtension.Shared;
using PasswordValidatorWithExtension.Shared.Rules;
using PasswordValidatorWithExtension.Shared.Rules.Interfaces;

namespace PasswordValidatorWithExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;
            Console.WriteLine("şifre giriniz");
            password = Console.ReadLine();

            IRules[] rules = {new IsContainsDigit(), new IsContainCharacter()};

            var result = password.IsValidPassword(rules);

            var mesaj = result
                ? "şifre kombinasyonu geçerli"
                : "şifre boş olmamalı. Büyük küçük harf ve rakam içermeli.";

            Console.WriteLine(mesaj);
        }
    }
}