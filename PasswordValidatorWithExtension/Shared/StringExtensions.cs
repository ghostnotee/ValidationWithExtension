using PasswordValidatorWithExtension.Shared.Rules.Interfaces;

namespace PasswordValidatorWithExtension.Shared
{
    public static class StringExtensions
    {
        public static bool IsValidPassword(this string str, params IRules[] rules)
        {
            foreach (var rule in rules)
            {
                if (!rule.Rule(str))
                    return false;
            }

            return true;
        }
    }
}