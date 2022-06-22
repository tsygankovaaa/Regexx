using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Regtext_;

namespace Regtext_
{
    public class Regextext
    {
        public bool regtext(string str)
        {
            Regex regex = new Regex("code");

            return regex.IsMatch(str);
        }
        public string regreplace(string str)
        {
            string pattern = @"\W?(а)";
            string replacement1 = "о";
            return Regex.Replace(str, pattern, replacement1);
        }
        public int regciv(string str)
        {
            Regex regex = new Regex(@"\d");
            return regex.Matches(str).Count;
        }

        public bool regmail(string email)// EMAIL
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }
        public bool regsnils(string snils) //CНИЛС
        {
            
            
            string pattern = (@"\d{3}-\d{3}-\d{4}\s\d{2}$");
            //Match match = regex.Match(snils);
            return Regex.IsMatch(snils, pattern, RegexOptions.IgnoreCase);

        }
        public bool regnomer(string nomer)
        {
            string pattern = (@"(+7|8){1}9\d{9}$");
            return Regex.IsMatch(nomer, pattern, RegexOptions.IgnoreCase);

        }
        //public class Class212
        //{
        //    //public double regperevod()
        //    //{


        //    //}

            public double regperevod(double xy, double x)
            {
                //double xy = Convert.ToDouble(Console.ReadLine());
                //double x = Convert.ToInt32(Console.ReadLine());
                switch (xy)
                {
                    case 0:                                             //"Байты в килобайты" || "байты в килобайты":
                        return x / 1024;
                    case 1:                                              //"Байты в мегабайты || байты в мегабайты":
                        return x / 1024 / 1024;
                    case 2:                                              //"Байты в гигабайты || байты в гигабайты":
                        return x / 1024 / 1024 / 1024;
                    case 3:                                              //"Килобайты в мегабайты || килобайты в мегабайты":
                        return x / 1024;
                    case 4:                                               //"Килобайты в гигабайты || килобайты в гигабайты":
                        return x / 1024 / 1024;
                    case 5:                                               //"Мегабайты в гигабайты || мегабайты в гигабайты":
                        return x * 1024;
                }
                return x;
            }
        //}

        public static double itog;
        public int regperevod2()
        {
            string xy = Convert.ToString(Console.ReadLine()).ToLower();
            double x = Convert.ToDouble(Console.ReadLine());
            //int itog;
            if (xy == "байты в килобайты" || xy == "килобайты в байты")
            {
                return (int)(x / 1024);
            }
            else if (xy == "байты в мегабайты" || xy == "мегабайты в байты")
            {
               return (int)(x / 1024 / 1024);

            }
            else if (xy == "байты в гигабайты" || xy == "гигабайты в байты")
            {
                return (int)(x / 1024 / 1024 / 1024);
            }
            else if (xy == "килобайты в мегабайты" || xy == "мегабайты в килобайты")
            {
                return (int)(x / 1024);
            }
            else if (xy == "килобайты в гигабайты" || xy == "гигабайты в килобайты")
            {
                return (int)(x / 1024 / 1024);
            }
            else if (xy == "мегабайты в гигабайты" || xy == "гигабайты в мегабайты")
            {
                return (int)(x * 1024);
            }
            else
            {
                Console.WriteLine("Неверный ввод информации");
            }
            return (int)itog;
            
        }
        public bool regpasport(string pasport) //ПАСПОРТ
        {
            string pattern = (@"\d{4}\s\d{6}$");
            //Match match = regex.Match(snils);
            return Regex.IsMatch(pasport, pattern, RegexOptions.IgnoreCase);
        }
        public int reguserid(string str)
        {
            Regex regex = new Regex(@"^user=(\d+)");
            Match match = regex.Match(str);
            int d = 0;
            while (match.Success)
            {
                d = Convert.ToInt32(match.Groups[1].Value);
                match = match.NextMatch();
            }
            return d;
        }
        public int regwcount(string str)
        {
            Regex regex = new Regex(@"(\w+\s*)");
            Match match = regex.Match(str);
            int d = 0;
            if (match.Success)
            {
                d += Convert.ToInt32(regex.Matches(str).Count);
                match = match.NextMatch();
            }
            return d;

        }
    }
}
