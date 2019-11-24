using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    public class Translate
    {
        private string result;
        string[] latin = { "Yu", "Ya","A", "B", "V", "G", "D", "E", "Yo", "Zh", "Z", "I", "L", "M", "N", "O", "P",
                                    "R", "U", "F", "Kh", "Ts", "Sch", "Ch", "Sh", "", "", "E",  "Y", "Y", "K", "T", "S",
            "yu", "ya","a", "b", "v", "g", "d", "e", "yo", "zh", "z", "i", "l", "m", "n", "o", "p",
                                  "r", "u", "f", "kh", "ts", "sch", "ch", "sh", "", "", "e",  "y", "y", "k", "t", "s" };
        string[] russian = { "Ю", "Я","А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Л", "М", "Н", "О", "П",
                                      "Р", "У", "Ф", "Х", "Ц", "Щ", "Ч", "Ш", "Ъ", "Ь", "Э",  "Й", "Ы", "К", "Т", "С",
                "ю", "я","а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "л", "м", "н", "о", "п",
                                     "р", "у", "ф", "х", "ц", "щ", "ч", "ш", "ъ", "ь", "э",  "й", "ы", "к", "т", "с"};
        public string TranslateString(string str)
        {
            result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (TranslateToLatin(str[i]))
                {
                    continue;
                }
                if (i + 1 < str.Length)       //translate to russian two simbols
                {
                    string abc = Convert.ToString(str[i]);
                    abc += Convert.ToString(str[i + 1]);
                    if (TranslateToRussian2Simbols(abc))
                    {
                        i++;
                        continue;
                    }

                }                 
                if (i + 2 < str.Length)      //translate Sch && sch
                {
                    string abc = Convert.ToString(str[i]);
                    abc += Convert.ToString(str[i + 1]);
                    abc += Convert.ToString(str[i + 2]);
                    if (TranslateToRussian3Simbols(abc))
                    {
                        i+=2;
                        continue;
                    }
                    

                }
                if (TranslateToRussian1Simbols(str[i]))
                {
                    continue;
                }
                result += str[i];
            }

            return result;
        }
        private bool TranslateToLatin(char element)
        {
            for (int j = 0; j < russian.Length; j++)
            {
                if (russian[j] == Convert.ToString(element))          //translate to Latin
                {
                    result += latin[j];
                    return true;
                }
            }
            return false;
        }
        private bool TranslateToRussian2Simbols(string abc)
        {
            for (int j = 0; j < latin.Length; j++)
            {

                if (latin[j] == abc)
                {
                    result += russian[j];
                    
                    return true;
                }

            }
            return false;
        }
        private bool TranslateToRussian3Simbols(string abc)
        {
            if ("sch" == abc)
            {
                result += "щ";
                return true;
            }
            if ("Sch" == abc)
            {
                result += "Щ";
                return true;
            }
            return false;
        }
        private bool TranslateToRussian1Simbols(char element)
        {
            for (int j = 0; j < latin.Length; j++)
            {
                if (latin[j] == Convert.ToString(element))          //translate to Latin
                {
                    result += russian[j];
                    return true;
                }
            }
            return false;
        }
    }
}
