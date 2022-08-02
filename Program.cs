using System;

namespace Hometask
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = "Fevral";
            switch (month)
            {
                case "Fevral":
                    Console.WriteLine("28");
                    break;
                case "Yanvar":
                case "Mart":
                case "May":
                case "Iyul":
                case "Avqust":
                case "Oktyabr":
                case "Dekabr":
                    Console.WriteLine("31");
                    break;
                case "Sentyabr":
                case "Noyabr":
                case "Aprel":
                case "Iyun":
                    Console.WriteLine("30");
                    break;

            }
        }
    }
}
