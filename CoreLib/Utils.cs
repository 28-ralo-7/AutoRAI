using System;

namespace CoreLib
{
    public class Utils
    { 
        /// <param name="name"></param>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public string Identity(string name, DateTime dateTime)
        {

            string text = name;
            text = text.Trim();
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length == 3)
            {
                text = words[0].Substring(0, 1).ToUpper() + words[0].Substring(1, words[0].Length - 1).ToLower() + "_" + words[1].Substring(0, 1).ToUpper() +
                 "." + words[2].Substring(0, 1).ToUpper() + "._" + dateTime.ToString("MM.dd.yyyy_H_mm");
            }
            else
            {
                text = "Исходная строка имеет неверный формат";
            }
            return text;

        }
    }
}
