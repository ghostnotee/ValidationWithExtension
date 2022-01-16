using System;
using System.Linq;
using PasswordValidatorWithExtension.Shared.Rules.Interfaces;

namespace PasswordValidatorWithExtension.Shared.Rules
{
    public class IsContainCharacter : IRules
    {
        public bool Rule(string str)
        {
            return str.Any(char.IsLower) && str.Any(char.IsUpper);
        }
    }
}