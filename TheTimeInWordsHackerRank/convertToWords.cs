namespace TheTimeInWordsHackerRank
{
    public static class ConvertToWords
    {
        public static string ToWords(int h, int m)
        {
            string temp;

            string[] time = new string[]
            {
                "None",
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine",
                "ten",
                "eleven",
                "twelve",
                "thirteen",
                "fourteen",
                "quarter",
                "sixteen",
                "seventeen",
                "eighteen",
                "nineteen",
                "twenty",
            };

            switch (m)
            {
                case 00:
                    temp = $"{time[h]} o' clock";
                    break;

                case 01:
                    temp = $"one minute past {time[h]}";
                    break;

                case 30:
                    temp = $"half past {time[h]}";
                    break;

                case <= 30:
                    if (20 < m & m <= 29)
                    {
                        var numb = m / 10;
                        temp = $"{time[numb * 10]} {time[m % 10]} minutes past {time[h]}";
                        break;
                    }

                    if (m == 15)
                    {
                        temp = $"{time[m]} past {time[h]}";
                        break;
                    }

                    temp = $"{time[m]} minutes past {time[h]}";
                    break;

                case > 30:
                    if (30 < m & m <= 39)
                    {
                        var numb = (m / 10) - 1;
                        temp = $"{time[numb * 10]} {time[10 - (m % 10)]} minutes to {time[h + 1]}";
                        break;
                    }

                    if (m == 45)
                    {
                        temp = $"{time[60 - m]} to {time[h + 1]}";
                        break;
                    }

                    temp = $"{time[60 - m]} minutes to {time[h + 1]}";
                    break;
            }

            return temp;
        }
    }
}
