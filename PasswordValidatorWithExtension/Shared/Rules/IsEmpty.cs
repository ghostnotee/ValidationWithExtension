using System;
using PasswordValidatorWithExtension.Shared.Rules.Interfaces;

namespace PasswordValidatorWithExtension.Shared.Rules
{
    public class IsEmpty : IRules
    {
        public bool Rule(string str)
        {
            return !String.IsNullOrEmpty(str);
        }
    }
}