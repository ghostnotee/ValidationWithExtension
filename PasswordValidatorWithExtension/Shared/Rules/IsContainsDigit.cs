using System;
using System.Linq;
using PasswordValidatorWithExtension.Shared.Rules.Interfaces;

namespace PasswordValidatorWithExtension.Shared.Rules
{
    public class IsContainsDigit:IRules
    {
        public bool Rule(string str)
        {
            return str.Any(char.IsDigit);
        }
    }
}