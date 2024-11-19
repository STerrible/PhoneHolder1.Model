using System.Linq;

namespace PhoneHolder.View
{
    public static class Validator
    {
        public static string TextBoxCheck(string value)
        {
            const string allowedChars = ".1234567890";
            return new string(value.Where(character => allowedChars.Contains(character)).ToArray());
        }
    }
}
