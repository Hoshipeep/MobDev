using System;
using System.Collections.Generic;

public class Program
{
    
    public void CreateDeck()
    {
        string[] suits = { "Heart", "Spade", "Diamond", "Clover" };
        string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        foreach (string suit in suits)
        {
            foreach (string rank in ranks)
            {
                Deck.Add($"{rank} of {suit}");
            }
        }

    }

    public void DisplayDeck()
    {
        Console.WriteLine("\nCurrent Deck:");
        foreach (string card in Deck)
        {
            Console.WriteLine(card);
        }
    }

    public void Deal(int numCards)
    {
        if(numCards > Deck.Count)
        {
            Console.WriteLine("Not enough cards in the deck.");
        }
        else
        {
            while(numCards > 0)
            {
            Console.WriteLine(Deck[0]);
            Deck.RemoveAt(0);
            numCards--;
            }
        }

    }
    
    public List<string> Deck { get; } = new List<string>();
    public static void Main()
    {
        Program deck = new Program();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create Deck");
            Console.WriteLine("2. Shuffle Deck");
            Console.WriteLine("3. Deal Cards");
            Console.WriteLine("4. Display Deck");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an action (1-5): ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                deck.CreateDeck();
            }
            else if (choice == "2")
            {
                //deck.Shuffle();
            }
            else if (choice == "3")
            {
                Console.Write("Enter number of cards to deal: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int numCards))
                {
                    deck.Deal(numCards);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            else if (choice == "4")
            {
                deck.DisplayDeck();
            }
            else if (choice == "5")
            {
                exit = true;
                Console.WriteLine("Exiting...");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose again.");
            }
        }
    }
}