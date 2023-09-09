using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Base stock = new Base();
            while (true)
            {
                string command = Console.ReadLine();
                Console.WriteLine(determineCommand(command, stock));
            }

        }
        static public string determineCommand(string command, Base stock)
        {
            if (command.StartsWith("ADD"))
            {
                command = command.Substring(command.IndexOf('(') + 1, command.Length - 6);
                string[] arrCommand = command.Split(',');
                stock.add(arrCommand[0], arrCommand[1], int.Parse(arrCommand[2]), int.Parse(arrCommand[3]));
                return "Строка добавлена";
            }
            if ((command.StartsWith("SELECT")))
            {
                return stock.select();
            }
            return "Ошибка в ключевом слове.";

        }
    }
}
