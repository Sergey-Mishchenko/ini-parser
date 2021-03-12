#if NET35
using System.Linq;

namespace IniParser
{
    /// <summary>
    /// Методы расширения для класса string
    /// </summary>
    static class StringExtentions
    {
        /// <summary>
        /// TRUE - строка пустая или содержит одни символы-разделители, FASLE - в противном случае
        /// </summary>
        /// <param name="s">Проверяемая строка</param>
        public static bool IsNullOrWhiteSpace(string s)
        {
            return string.IsNullOrEmpty(s) || s.All(ch => char.IsWhiteSpace(ch));
        }
    }
}
#endif