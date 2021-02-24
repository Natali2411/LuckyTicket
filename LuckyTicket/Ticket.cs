using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyTicket
{
    public static class Ticket
    {

        public static int countNumbersSum(string numString)
        {
            int sum = 0;
            for (int i = 0; i < numString.Length; i++)
            {
                sum += numString[i];
            }
            return sum;
        }

        public static void getLuckyTicket()
        {
            Console.WriteLine("Enter a ticket number to check it or '0' to exit from the program:");
            string ticket = Console.ReadLine();
            int ticketLength = ticket.Length;
            if (ticket == "0")
            {
                Console.WriteLine("The program is ended");
                return;
            }
            else if (ticketLength > 8 || ticketLength < 4)
            {
                Console.WriteLine("The length of your ticket number is out of range from 4 to 8 digits");
                getLuckyTicket();
            }
            int num;
            bool isConverted = Int32.TryParse(ticket, out num);
            if (isConverted)
            {
                if (ticketLength % 2 != 0)
                {
                    ticket = ticket.Insert(0, "0");
                    ticketLength = ticket.Length;
                }
                string part1 = ticket.Substring(0, ticketLength / 2);
                string part2 = ticket.Substring(ticketLength / 2);
                if (countNumbersSum(part1) == countNumbersSum(part2))
                {
                    Console.WriteLine($"Your ticket with number {ticket} is lucky");
                }
                else
                {
                    Console.WriteLine($"Your ticket with number {ticket} is not lucky");
                }
            }
            else
            {
                Console.WriteLine($"Your ticket with number {ticket} can't b converted into number");
            }
            getLuckyTicket();
        }
    }
}
