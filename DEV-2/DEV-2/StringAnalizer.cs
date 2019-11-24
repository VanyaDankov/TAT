

namespace DEV_2
{
        public class StringAnalizer
        {
        public static int MaxOfDifferentSimbols(string str)
        {
            if (str.Length == 0)
            {
                return 0;
            }
            int result = 1;
            int count = 1;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    count = 0;
                }
                count++;
                if (count > result)
                {
                    result = count;
                }
            }
            return result;
        }
        public static int MaxOfIdentialNumbers(string str)
        {
 
            int result = 0;
            int count = 1;
            if (str.Length == 1)
            {
                if (str[0] >= 48 && str[0] <= 57)
                {
                    result = 1;
                }
            }

            for (int i = 0; i < str.Length - 1; i++)
            {
                if  (str[i] >= 48 && str[i] <= 57)
                {
                    if (str[i] == str[i + 1])
                    {
                        count++;
                       
                    }
                    if (count > result)
                    {
                        result = count;
                    }
                }
                else
                {
                    count = 1;
                }

            }
            return result;
        }
        public static int MaxOfLatinSimbols(string str)
        {
            int result = 0;
            int count = 1;
            if (str.Length == 1)
            {
                if ((str[0] >= 65 && str[0] <= 90) || (str[0] >= 97 && str[0] <= 122))
                {
                    result = 1;
                }
            }
            for (int i = 0; i < str.Length - 1; i++)
            {

                if ((str[i] >= 65 && str[i] <= 90) || (str[i] >= 97 && str[i] <= 122))
                    {
                        if (str[i] == str[i + 1])
                        { 
                            count++;
                            

                        }
                    if (count > result)
                    {
                        result = count;
                    }
                }
                else
                {
                    count = 1;
                }

            }
            return result;
        }

    }
}
